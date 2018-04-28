﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using RomUtilities;

namespace FF1Lib
{
	public struct MapEdit
	{
		public byte X { get; set; }
		public byte Y { get; set; }
		public byte Tile { get; set; }
	}

	public class OverworldMap
	{
		private readonly FF1Rom _rom;
		public OverworldMap(FF1Rom rom, IMapEditFlags flags)
		{
			_rom = rom;
			var mapLocationRequirements = ItemLocations.MapLocationRequirements.ToDictionary(x => x.Key, x => x.Value.ToList());
			var floorLocationRequirements = ItemLocations.MapLocationFloorRequirements.ToDictionary(x => x.Key, x => x.Value);

			if (flags.MapOnracDock)
			{
				MapEditsToApply.Add(OnracDock);
				mapLocationRequirements[MapLocation.Onrac].Add(MapChange.Ship | MapChange.Canal);
				mapLocationRequirements[MapLocation.Caravan].Add(MapChange.Ship | MapChange.Canal | MapChange.Canoe);
				mapLocationRequirements[MapLocation.Waterfall].Add(MapChange.Ship | MapChange.Canal | MapChange.Canoe);
			}
			if (flags.MapMirageDock)
			{
				MapEditsToApply.Add(MirageDock);
				mapLocationRequirements[MapLocation.MirageTower1].Add(MapChange.Ship | MapChange.Canal | MapChange.Chime);
				//mapLocationRequirements[MapLocation.Lefein].Add(MapChange.Ship | MapChange.Canal | MapChange.Chime);
			}
			if (flags.MapVolcanoIceRiver)
			{
				MapEditsToApply.Add(VolcanoIceRiver);
				mapLocationRequirements[MapLocation.GurguVolcano1].Add(MapChange.Bridge | MapChange.Canoe);
				mapLocationRequirements[MapLocation.CresentLake].Add(MapChange.Bridge | MapChange.Canoe);
				mapLocationRequirements[MapLocation.Elfland].Add(MapChange.Bridge | MapChange.Canoe);
				mapLocationRequirements[MapLocation.ElflandCastle].Add(MapChange.Bridge | MapChange.Canoe);
				mapLocationRequirements[MapLocation.NorthwestCastle].Add(MapChange.Bridge | MapChange.Canoe);
				mapLocationRequirements[MapLocation.MarshCave1].Add(MapChange.Bridge | MapChange.Canoe);
				mapLocationRequirements[MapLocation.AirshipLocation].Add(MapChange.Bridge | MapChange.Canoe);
				if(flags.MapCanalBridge)
					mapLocationRequirements[MapLocation.DwarfCave].Add(MapChange.Bridge | MapChange.Canoe);
			}
			if (flags.MapConeriaDwarves)
			{
				MapEditsToApply.Add(ConeriaToDwarves);
				mapLocationRequirements[MapLocation.DwarfCave].Add(MapChange.None);
				if(flags.MapCanalBridge)
				{
					mapLocationRequirements[MapLocation.GurguVolcano1].Add(MapChange.Canoe);
					mapLocationRequirements[MapLocation.CresentLake].Add(MapChange.Canoe);
					mapLocationRequirements[MapLocation.Elfland].Add(MapChange.Canoe);
					mapLocationRequirements[MapLocation.ElflandCastle].Add(MapChange.Canoe);
					mapLocationRequirements[MapLocation.NorthwestCastle].Add(MapChange.Canoe);
					mapLocationRequirements[MapLocation.MarshCave1].Add(MapChange.Canoe);
					mapLocationRequirements[MapLocation.AirshipLocation].Add(MapChange.Canoe);
					if (flags.MapVolcanoIceRiver)
					{
						mapLocationRequirements[MapLocation.IceCave1].Add(MapChange.Canoe);
						mapLocationRequirements[MapLocation.Pravoka].Add(MapChange.Canoe);
						mapLocationRequirements[MapLocation.MatoyasCave].Add(MapChange.Canoe);
					}
				}
			}
			
			if (flags.TitansTrove)
			{
				mapLocationRequirements[MapLocation.TitansTunnelWest] = new List<MapChange> {
					MapChange.Canal | MapChange.Ship | MapChange.TitanFed, MapChange.Airship | MapChange.TitanFed };
			}
			
			if (flags.CrownlessOrdeals)
			{
				floorLocationRequirements[MapLocation.CastleOrdealsMaze] = new Tuple<MapLocation, AccessRequirement>(MapLocation.CastleOrdeals1, AccessRequirement.None);
			}
			
			MapLocationRequirements = mapLocationRequirements;
			FloorLocationRequirements = floorLocationRequirements;
		}

		const int teleportEntranceXOffset = 0x2C00;
		const int teleportEntranceYOffset = 0x2C20;
		const int teleportEntranceMapIndexOffset = 0x2C40;
		const int teleportExitXOffset = 0x2C60;
		const int teleportExitYOffset = 0x2C70;
		
		const int teleportTilesetOffset = 0x2CC0;
		
		const int teleportXOffset = 0x2D00;
		const int teleportYOffset = 0x2D40;
		const int teleportMapIndexOffset = 0x2D80;

		public void PutOverworldTeleport(OverworldTeleportIndex index, TeleportDestination teleport)
		{
			if(teleport.Index == MapIndex.Overworld)
			{
				throw new InvalidOperationException("Cannot teleport from overworld to overworld map");
			}
			_rom[teleportEntranceXOffset + (byte)index] = teleport.CoordinateX;
			_rom[teleportEntranceYOffset + (byte)index] = teleport.CoordinateY;
			_rom[teleportEntranceMapIndexOffset + (byte)index] = (byte)teleport.Index;
		}
		public void PutStandardTeleport(TeleportIndex index, TeleportDestination teleport)
		{
			if(teleport.Index == MapIndex.Overworld)
			{
				_rom[teleportExitXOffset + (byte)teleport.Exit] = teleport.CoordinateX;
				_rom[teleportExitYOffset + (byte)teleport.Exit] = teleport.CoordinateY;
				return;
			}
			_rom[teleportXOffset + (byte)index] = teleport.CoordinateX;
			_rom[teleportYOffset + (byte)index] = teleport.CoordinateY;
			_rom[teleportMapIndexOffset + (byte)index] = (byte)teleport.Index;
		}
		
		public void ShuffleEntrancesAndFloors(MT19337 rng, bool includeTowns, bool allowUnsafe = false)
		{
			// Disable the Princess Warp back to Castle Coneria
			_rom.Put(0x392CA, Blob.FromHex("EAEAEA"));
			
			var defaultRequirements = MapLocationRequirements
				.ToDictionary(x => x.Key, x => new LocationRequirement(x.Value))
				.Concat(FloorLocationRequirements.ToDictionary(x => x.Key, x => new LocationRequirement(x.Value)))
				.ToDictionary(x => x.Key, x => x.Value);
			defaultRequirements[MapLocation.SardasCave] = new LocationRequirement(new List<MapChange> { MapChange.Airship });
			defaultRequirements[MapLocation.TitansTunnelWest] = new LocationRequirement(new List<MapChange> { MapChange.Airship });

			var placedMaps = new Dictionary<OverworldTeleportIndex, TeleportDestination> { 
				{ OverworldTeleportIndex.Coneria, TeleportShuffle.Coneria }
			};
			var placedFloors = new Dictionary<TeleportIndex, TeleportDestination> ();
			if (!includeTowns)
			{
				placedMaps.Add(OverworldTeleportIndex.Pravoka, TeleportShuffle.Pravoka);
				placedMaps.Add(OverworldTeleportIndex.Elfland, TeleportShuffle.Elfland);
				placedMaps.Add(OverworldTeleportIndex.Melmond, TeleportShuffle.Melmond);
				placedMaps.Add(OverworldTeleportIndex.CresentLake, TeleportShuffle.CrescentLake);
				placedMaps.Add(OverworldTeleportIndex.Onrac, TeleportShuffle.Onrac);
				placedMaps.Add(OverworldTeleportIndex.Gaia, TeleportShuffle.Gaia);
				placedFloors.Add(TeleportIndex.SeaShrine1, TeleportShuffle.FreePlacementFloors.PickRandom(rng));
			}
			var placedExits = new Dictionary<ExitTeleportIndex, Coordinate>();
			var placedDestinations = placedMaps.Values.Select(x => x.Destination).Concat(placedFloors.Values.Select(x => x.Destination)).ToList();

			var maps = Enum.GetValues(typeof(OverworldTeleportIndex)).Cast<OverworldTeleportIndex>().Where(x => !placedMaps.Keys.Contains(x) && x < OverworldTeleportIndex.Unused1).ToList();
			var mapCount = maps.Count;
			var destinations = TeleportShuffle.FreePlacementFloors.Where(x => !placedDestinations.Contains(x.Destination)).ToList();
			destinations.Shuffle(rng);
			while (destinations.Last().Teleports.Any())
			{
				destinations.Insert(0, destinations.Last());
				destinations.RemoveAt(destinations.Count - 1);
			}
			destinations = TeleportShuffle.ForcedTopFloors.Where(x => !placedDestinations.Contains(x.Destination)).Concat(destinations).ToList();
			
			
			var sanity = 0;
			Dictionary<OverworldTeleportIndex, TeleportDestination> shuffled;
			Dictionary<TeleportIndex, TeleportDestination> shuffledFloors;
			do
			{
				sanity++;
				if (sanity > 10000)
					throw new InvalidOperationException("Invalid flagset, entrances could not be sanely shuffled");
				var shuffleMaps = maps.ToList();
				var j = 0;
				shuffled = placedMaps.ToDictionary(x => x.Key, x => x.Value);
				shuffledFloors = placedFloors.ToDictionary(x => x.Key, x => x.Value);
				for (byte i = 0; i < mapCount; i++) {
					var destination = destinations[i];
					var owti = shuffleMaps.SpliceRandom(rng);
					shuffled.Add(owti, destination);
					if (destination.Exit != ExitTeleportIndex.None)
						placedExits[destination.Exit] = TeleportShuffle.OverworldCoordinates[owti];
					var teleports = destination.Teleports.Where(x => !placedFloors.Keys.Contains(x)).ToList();
					while (teleports.Any())
					{
						var teleport = teleports.SpliceRandom(rng);
						var floor = destinations[mapCount + j];
						teleports.AddRange(floor.Teleports.Where(x => !placedFloors.Keys.Contains(x)));
						shuffledFloors.Add(teleport, floor);
						j++;
						if (floor.Exit != ExitTeleportIndex.None)
							placedExits[floor.Exit] = TeleportShuffle.OverworldCoordinates[owti];
					}
				}
			} while (!CheckEntranceSanity(shuffled, allowUnsafe));

			Console.WriteLine($"\nShuffled Maps after sanity count: {sanity}");
			foreach (var map in shuffled.OrderBy(x => x.Key))
			{
				PutOverworldTeleport(map.Key, map.Value);
				var name = Enum.GetName(typeof(OverworldTeleportIndex), map.Key);
				name += string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - name.Length)).ToList());
				Console.WriteLine($"{name}{map.Value.SpoilerText}");
			}
			Console.WriteLine($"\nShuffled Floors:");
			foreach (var map in shuffledFloors.OrderBy(x => x.Key))
			{
				PutStandardTeleport(map.Key, map.Value);
				var name = Enum.GetName(typeof(TeleportIndex), map.Key);
				name += string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - name.Length)).ToList());
				Console.WriteLine($"{name}{map.Value.SpoilerText}");
			}
			foreach (var exit in placedExits)
			{
				_rom[teleportExitXOffset + (byte)exit.Key] = exit.Value.X;
				_rom[teleportExitYOffset + (byte)exit.Key] = exit.Value.Y;
			}

			var allTeleportLocations = shuffled.Select(x => x.Value.Destination).Concat(shuffledFloors.Select(x => x.Value.Destination)).Distinct().ToList();
			var titanEast = shuffled.Single(x => x.Value.Destination == MapLocation.TitansTunnelEast);
			var titanWest = shuffled.Single(x => x.Value.Destination == MapLocation.TitansTunnelWest);
			var walkableNodes = new List<List<OverworldTeleportIndex>> {
				new List<OverworldTeleportIndex>{OverworldTeleportIndex.ConeriaCastle1, OverworldTeleportIndex.Coneria, OverworldTeleportIndex.TempleOfFiends1},
				new List<OverworldTeleportIndex>{OverworldTeleportIndex.MatoyasCave, OverworldTeleportIndex.Pravoka},
				new List<OverworldTeleportIndex>{OverworldTeleportIndex.ElflandCastle, OverworldTeleportIndex.Elfland, OverworldTeleportIndex.NorthwestCastle, OverworldTeleportIndex.MarshCave1},
				new List<OverworldTeleportIndex>{OverworldTeleportIndex.Melmond, OverworldTeleportIndex.EarthCave1, OverworldTeleportIndex.TitansTunnelEast},
				new List<OverworldTeleportIndex>{OverworldTeleportIndex.SardasCave, OverworldTeleportIndex.TitansTunnelWest},
				new List<OverworldTeleportIndex>{OverworldTeleportIndex.Cardia1, OverworldTeleportIndex.BahamutCave1}
			};
			var canoeableNodes = new List<List<OverworldTeleportIndex>> {
				new List<OverworldTeleportIndex>{OverworldTeleportIndex.MatoyasCave, OverworldTeleportIndex.Pravoka, OverworldTeleportIndex.IceCave1},
				new List<OverworldTeleportIndex>{
				OverworldTeleportIndex.ElflandCastle, OverworldTeleportIndex.Elfland, OverworldTeleportIndex.NorthwestCastle, OverworldTeleportIndex.MarshCave1,
				OverworldTeleportIndex.CresentLake, OverworldTeleportIndex.GurguVolcano1, OverworldTeleportIndex.DwarfCave},
				new List<OverworldTeleportIndex>{OverworldTeleportIndex.Onrac, OverworldTeleportIndex.Waterfall}
			};
			var titanWalkLocations = walkableNodes.Where(x => x.Contains(titanEast.Key) || x.Contains(titanWest.Key)).SelectMany(x => x).Distinct().Select(x => shuffled[x].Destination);
			var titanCanoeLocations = canoeableNodes.Where(x => x.Contains(titanEast.Key) || x.Contains(titanWest.Key)).SelectMany(x => x).Distinct().Select(x => shuffled[x].Destination);

			var standardMapLookup = TeleportShuffle.StandardMapLocations;
			var destinationsByLocation = shuffled
				.Select(x => new KeyValuePair<MapLocation, TeleportDestination>((MapLocation)Enum.Parse(typeof(MapLocation), x.Key.ToString()), x.Value))
				.ToDictionary(x => x.Key, x => x.Value);
			destinationsByLocation = destinationsByLocation
				.Concat(shuffledFloors.Select(x => new KeyValuePair<MapLocation, TeleportDestination>(standardMapLookup[x.Key], x.Value)))
				.ToDictionary(x => x.Key, x => x.Value);
			var newRequirements = defaultRequirements
				.ToDictionary(x => !allTeleportLocations.Contains(x.Key) ? x.Key :
							  destinationsByLocation[x.Key].Destination,
							x => x.Value);


			MapLocationRequirements = newRequirements.Where(x => x.Value.MapChanges != null).ToDictionary(x => x.Key, x => x.Value.MapChanges.ToList());
			FloorLocationRequirements = newRequirements.Where(x => x.Value.MapChanges == null).ToDictionary(x => x.Key, x => x.Value.TeleportLocation);
			foreach(var key in titanWalkLocations)
			{
				MapLocationRequirements[key].Add(MapChange.TitanFed);
			}
			foreach(var key in titanCanoeLocations)
			{
				MapLocationRequirements[key].Add(MapChange.TitanFed | MapChange.Canoe);
			}
		}
		
		public bool CheckEntranceSanity(IEnumerable<KeyValuePair<OverworldTeleportIndex, TeleportDestination>> shuffledEntrances, 
										bool allowUnsafe = false) {
			var starterDestinations = new List<MapLocation> {
				MapLocation.TempleOfFiends1, MapLocation.Cardia6, MapLocation.Cardia4,
				MapLocation.Cardia2, MapLocation.MatoyasCave, MapLocation.DwarfCave,
				MapLocation.SeaShrineMermaids
			};
			var townsWithShops = new List<MapLocation> {
				MapLocation.Coneria
				//, MapLocation.Pravoka, MapLocation.Elfland, MapLocation.CresentLake, MapLocation.Gaia
			};
			var safeLocations = new List<MapLocation> {
				MapLocation.IceCave3, MapLocation.GurguVolcano4, MapLocation.GurguVolcano5, 
				MapLocation.SeaShrine5, MapLocation.SeaShrine6,
				MapLocation.BahamutCave1, MapLocation.BahamutCave2,
				MapLocation.ElflandCastle, MapLocation.NorthwestCastle, MapLocation.ConeriaCastle1,
				MapLocation.SardasCave, MapLocation.Cardia1, MapLocation.Cardia5, 
				MapLocation.Pravoka, MapLocation.Elfland, MapLocation.Melmond, 
				MapLocation.CresentLake, MapLocation.Gaia, MapLocation.Onrac, MapLocation.Lefein

			}.Concat(starterDestinations).Concat(townsWithShops).ToList();
			var connectedLocations = new List<OverworldTeleportIndex> {
				OverworldTeleportIndex.ConeriaCastle1, OverworldTeleportIndex.Coneria, OverworldTeleportIndex.TempleOfFiends1,
				OverworldTeleportIndex.MatoyasCave, OverworldTeleportIndex.Pravoka,
				OverworldTeleportIndex.ElflandCastle, OverworldTeleportIndex.Elfland, OverworldTeleportIndex.NorthwestCastle, OverworldTeleportIndex.MarshCave1,
				OverworldTeleportIndex.Melmond, OverworldTeleportIndex.EarthCave1, OverworldTeleportIndex.TitansTunnelEast, 
				OverworldTeleportIndex.SardasCave, OverworldTeleportIndex.TitansTunnelWest,
				OverworldTeleportIndex.Cardia1, OverworldTeleportIndex.BahamutCave1,
				OverworldTeleportIndex.GurguVolcano1, OverworldTeleportIndex.IceCave1,
				OverworldTeleportIndex.Onrac
			};
			var startingLocations = new List<OverworldTeleportIndex> {
				OverworldTeleportIndex.ConeriaCastle1, OverworldTeleportIndex.TempleOfFiends1
			};
			var townStart = 
				shuffledEntrances.Any(x => x.Key == OverworldTeleportIndex.Coneria && townsWithShops.Contains(x.Value.Destination));
			var starterLocation = 
				shuffledEntrances.Any(x => startingLocations.Contains(x.Key) && starterDestinations.Contains(x.Value.Destination));
			var dangerLocationAtConeriaCastle = 
				!shuffledEntrances.Any(x => x.Key == OverworldTeleportIndex.ConeriaCastle1 && safeLocations.Contains(x.Value.Destination));
			var dangerLocationAtToF = 
				!shuffledEntrances.Any(x => x.Key == OverworldTeleportIndex.TempleOfFiends1 && safeLocations.Contains(x.Value.Destination));
			var dangerLocationAtDwarf = 
				!shuffledEntrances.Any(x => x.Key == OverworldTeleportIndex.DwarfCave && safeLocations.Contains(x.Value.Destination));
			var dangerLocationAtMatoya = 
				!shuffledEntrances.Any(x => x.Key == OverworldTeleportIndex.MatoyasCave && safeLocations.Contains(x.Value.Destination));
			var titansConnections = 
				shuffledEntrances.Any(x => x.Value.Destination == MapLocation.TitansTunnelEast && connectedLocations.Contains(x.Key)) && 
				shuffledEntrances.Any(x => x.Value.Destination == MapLocation.TitansTunnelWest && connectedLocations.Contains(x.Key));
			var titanDirection =
				shuffledEntrances.FirstOrDefault(x => x.Value.Destination == MapLocation.TitansTunnelWest).Value.CoordinateX <=
				shuffledEntrances.FirstOrDefault(x => x.Value.Destination == MapLocation.TitansTunnelEast).Value.CoordinateX;
			var dangerDanger = dangerLocationAtConeriaCastle || dangerLocationAtToF || dangerLocationAtDwarf || dangerLocationAtMatoya;
				
			return townStart && starterLocation && titansConnections && titanDirection && (allowUnsafe || !dangerDanger);
		}
		
		public Dictionary<MapLocation, List<MapChange>> MapLocationRequirements;
		public Dictionary<MapLocation, Tuple<MapLocation, AccessRequirement>> FloorLocationRequirements;
		
		public const byte GrassTile = 0x00;
		public const byte GrassBottomRightCoast = 0x06;
		public const byte OceanTile = 0x17;
		public const byte RiverTile = 0x44;
		public const byte MountainTopLeft = 0x10;
		public const byte MountainTopMid = 0x11;
		public const byte MountainMid = 0x21;
		public const byte MountainBottomLeft = 0x30;
		public const byte MountainBottomMid = 0x31;
		public const byte MountainBottomRight = 0x33;
		public const byte ForestMid = 0x14;
		public const byte ForestBottomMid = 0x24;
		public const byte ForestBottomRight = 0x25;
		public const byte ForestBottomLeft = 0x23;
		public const byte DockBottomMid = 0x78;
		public const byte DockRightMid = 0x1F;

		public static List<MapEdit> OnracDock =
			new List<MapEdit>
			{
				new MapEdit{X = 50, Y = 78, Tile = ForestBottomRight},
				new MapEdit{X = 51, Y = 78, Tile = DockBottomMid},
				new MapEdit{X = 52, Y = 78, Tile = DockBottomMid},
				new MapEdit{X = 51, Y = 77, Tile = ForestBottomMid},
				new MapEdit{X = 52, Y = 77, Tile = ForestBottomMid},
				new MapEdit{X = 51, Y = 79, Tile = OceanTile},
				new MapEdit{X = 52, Y = 79, Tile = OceanTile}
			};
		public static List<MapEdit> MirageDock =
			new List<MapEdit>
			{
				new MapEdit{X = 208, Y = 90, Tile = DockBottomMid},
				new MapEdit{X = 209, Y = 90, Tile = DockBottomMid}
			};
		public static List<MapEdit> ConeriaToDwarves =
			new List<MapEdit>
			{
				new MapEdit{X = 124, Y = 138, Tile = MountainBottomLeft},
				new MapEdit{X = 124, Y = 139, Tile = GrassTile},
				new MapEdit{X = 125, Y = 139, Tile = MountainBottomLeft},
				new MapEdit{X = 125, Y = 140, Tile = GrassTile},
				new MapEdit{X = 126, Y = 140, Tile = MountainBottomLeft},
				new MapEdit{X = 127, Y = 140, Tile = MountainBottomMid},
				new MapEdit{X = 128, Y = 140, Tile = MountainBottomMid},
				new MapEdit{X = 129, Y = 140, Tile = MountainBottomMid},
				new MapEdit{X = 126, Y = 141, Tile = GrassTile},
				new MapEdit{X = 127, Y = 141, Tile = GrassTile},
				new MapEdit{X = 128, Y = 141, Tile = GrassTile},
				new MapEdit{X = 129, Y = 141, Tile = GrassTile},
				new MapEdit{X = 130, Y = 141, Tile = MountainBottomLeft}
			};
		public static List<MapEdit> VolcanoIceRiver =
			new List<MapEdit>
			{
				new MapEdit{X = 209, Y = 189, Tile = MountainBottomRight},
				new MapEdit{X = 210, Y = 189, Tile = GrassTile},
				new MapEdit{X = 208, Y = 190, Tile = RiverTile},
				new MapEdit{X = 209, Y = 190, Tile = RiverTile},
				new MapEdit{X = 210, Y = 190, Tile = RiverTile},
				new MapEdit{X = 211, Y = 190, Tile = RiverTile},
				new MapEdit{X = 209, Y = 191, Tile = MountainTopLeft},
				new MapEdit{X = 210, Y = 191, Tile = MountainTopMid},
				new MapEdit{X = 211, Y = 191, Tile = MountainTopMid}
			};
		public static List<MapEdit> CanalSoftLockMountain =
			new List<MapEdit>
			{
				new MapEdit{X = 101, Y = 161, Tile = MountainTopLeft},
				new MapEdit{X = 102, Y = 161, Tile = MountainTopMid},
				new MapEdit{X = 103, Y = 161, Tile = MountainMid},
				new MapEdit{X = 101, Y = 162, Tile = MountainBottomLeft},
				new MapEdit{X = 102, Y = 162, Tile = MountainBottomMid},
				new MapEdit{X = 103, Y = 162, Tile = MountainBottomRight}
			};
		public List<List<MapEdit>> MapEditsToApply = new List<List<MapEdit>>();

		const int bankStart = 0x4000;

		public List<List<byte>> GetCompressedMapRows()
		{

			var pointers = _rom.Get(bankStart, 512).ToUShorts().Select(x => x - bankStart);
			var mapRows = pointers.Select(x =>
			{
				var mapRow = _rom.Get(x, 256).ToBytes();
				var result = new List<byte>();
				var index = 0;
				while (index < 256 && mapRow[index] != 255)
				{
					result.Add(mapRow[index]);
					index++;
				}
				result.Add(mapRow[index]);
				return result;
			}).ToList();
			return mapRows;
		}

		public List<List<byte>> DecompressMapRows(List<List<byte>> compressedRows)
		{
			var mapRows = new List<List<byte>>();
			var run = 0;
			foreach (var compressedRow in compressedRows)
			{
				byte tile = 0;
				var row = new List<byte>();
				var tileIndex = 0;
				while (row.Count() < 256)
				{
					tile = compressedRow[tileIndex];
					if (tile < 0x80)
					{
						row.Add(tile);
					}
					else if (tile == 0xFF)
					{
						for (var i = tileIndex; i < 256; i++)
						{
							row.Add(0x17);
						}
					}
					else
					{
						tileIndex++;
						run = compressedRow[tileIndex];
						if (run == 0)
							run = 256;
						tile -= 0x80;
						for (var i = 0; i < run; i++)
						{
							row.Add(tile);
						}
					}
					tileIndex++;
				}
				mapRows.Add(row);
			}
			return mapRows;
		}

		public void DebugWriteDecompressedMap(List<List<byte>> decompressedRows)
		{
			foreach (var row in decompressedRows)
			{
				foreach (var tile in row)
				{
					Debug.Write($"{tile:X2}");
				}
				Debug.Write("\n");
			}
		}

		public void ApplyMapEdits()
		{
			var compresedMap = GetCompressedMapRows();
			var decompressedMap = DecompressMapRows(compresedMap);
			var editedMap = decompressedMap;
			foreach (var mapEdit in MapEditsToApply)
			{
				editedMap = ApplyMapEdits(editedMap, mapEdit);
			}
			var recompressedMap = CompressMapRows(editedMap);
			PutCompressedMapRows(recompressedMap);
		}

		public List<List<byte>> ApplyMapEdits(List<List<byte>> decompressedRows, List<MapEdit> mapEdits)
		{
			foreach (var mapEdit in mapEdits)
			{
				decompressedRows[mapEdit.Y][mapEdit.X] = mapEdit.Tile;
			}
			return decompressedRows;
		}

		public List<List<byte>> CompressMapRows(List<List<byte>> decompressedRows)
		{
			var outputMap = new List<List<byte>>();
			foreach (var row in decompressedRows)
			{
				var outputRow = new List<byte>();
				byte tile = 0;
				byte runCount = 1;
				if (row.Distinct().Count() == 1)
				{
					outputMap.Add(new List<byte> { 0x97, 0x00, 0xFF });
					continue;
				}
				for (var tileIndex = 0; tileIndex < 256; tileIndex++)
				{
					tile = row[tileIndex];
					if (tileIndex != 255 && tile == row[tileIndex + 1])
					{
						runCount++;
						continue;
					}
					if (runCount == 1)
					{
						outputRow.Add(tile);
						continue;
					}
					outputRow.Add((byte)(tile + 0x80));
					outputRow.Add(runCount);
					runCount = 1;
				}
				outputRow.Add(0xFF);
				outputMap.Add(outputRow);
			}
			return outputMap;
		}

		public void PutCompressedMapRows(List<List<byte>> compressedRows)
		{
			var pointerBase = 0x4000;
			var outputBase = 0x4200;
			var outputOffset = 0;
			for (int i = 0; i < compressedRows.Count; i++)
			{
				var outputRow = compressedRows[i];
				_rom.Put(pointerBase + i * 2, Blob.FromUShorts(new ushort[] { (ushort)(outputBase + pointerBase + outputOffset) }));
				_rom.Put(outputBase + outputOffset, outputRow.ToArray());
				outputOffset += outputRow.Count;
			}

			if (outputOffset > 0x4000)
				throw new InvalidOperationException("Modified map was too large to recompress and fit into a single bank.");
		}
	}
}
