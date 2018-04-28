using System;
using System.Collections.Generic;
using System.Linq;

namespace FF1Lib
{
	public struct Coordinate
	{
		private readonly short _identityValue;
		public readonly byte X;
		public readonly byte Y;
		public Coordinate(byte x, byte y)
		{
			X = x;
			Y = y;
			_identityValue = (short)(x * 256 + y);
		}
	}
	public struct LocationRequirement
	{
		public readonly IEnumerable<MapChange> MapChanges;
		public readonly Tuple<MapLocation, AccessRequirement> TeleportLocation;
		public LocationRequirement(IEnumerable<MapChange> mapChanges)
		{
			MapChanges = mapChanges.ToList();
			TeleportLocation = null;
		}
		public LocationRequirement(Tuple<MapLocation, AccessRequirement> teleportLocation)
		{
			MapChanges = null;
			TeleportLocation = teleportLocation;
		}
	}
	public struct TeleportDestination
	{
        public readonly MapLocation Destination;
		public readonly MapIndex Index;
		public readonly byte CoordinateX;
		public readonly byte CoordinateY;
		public readonly IEnumerable<TeleportIndex> Teleports;
		public readonly ExitTeleportIndex Exit;
		public string SpoilerText =>
		$"{Enum.GetName(typeof(MapLocation), Destination)}" +
		$"{string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - Enum.GetName(typeof(MapLocation), Destination).Length)).ToList())}";
		public TeleportDestination(MapLocation destination, MapIndex index, Coordinate coordinates, IEnumerable<TeleportIndex> teleports = null, ExitTeleportIndex exits = ExitTeleportIndex.None)
		{
			Destination = destination;
			Index = index;
			CoordinateX = coordinates.X;
			CoordinateY = coordinates.Y;
			Teleports = teleports?.ToList() ?? new List<TeleportIndex>();
			Exit = exits;
		}
		public TeleportDestination(MapLocation destination, MapIndex index, Coordinate coordinates, TeleportIndex teleport) 
			: this(destination, index, coordinates, new List<TeleportIndex> { teleport })
		{
		}
		public TeleportDestination(MapLocation destination, MapIndex index, Coordinate coordinates, ExitTeleportIndex exit) 
			: this(destination, index, coordinates, exits:exit)
		{
		}
	}
	public enum MapLocation
	{
		StartingLocation,
		AirshipLocation,
		Coneria,
		Pravoka,
		Elfland,
		Melmond,
		CresentLake,
		Gaia,
		Onrac,
		Lefein,
		Caravan,
		ConeriaCastle1,
		ConeriaCastle2,
		ConeriaCastleRoom1,
		ConeriaCastleRoom2,
		ElflandCastle,
		ElflandCastleRoom1,
		NorthwestCastle,
		NorthwestCastleRoom2,
		CastleOrdeals1,
		CastleOrdealsMaze,
		CastleOrdealsTop,
		EarthCave1,
		EarthCave2,
		EarthCaveVampire,
		EarthCave4,
		EarthCaveLich,
		GurguVolcano1,
		GurguVolcano2,
		GurguVolcano3,
		GurguVolcano4,
		GurguVolcano5,
		GurguVolcano6,
		GurguVolcanoKary,
		IceCave1,
		IceCave2,
		IceCave3,
		IceCavePitRoom,
		IceCave5,
		IceCaveBackExit,
		IceCaveFloater,
		Cardia1,
		Cardia2,
		BahamutCave1,
		BahamutCave2,
		Cardia4,
		Cardia5,
		Cardia6,
		Waterfall,
		DwarfCave,
		DwarfCaveRoom3,
		MatoyasCave,
		SardasCave,
		MarshCave1,
		MarshCave2,
		MarshCave3,
		MarshCaveBottom,
		MarshCaveBottomRoom13,
		MarshCaveBottomRoom14,
		MarshCaveBottomRoom16,
		MirageTower1,
		MirageTower2,
		MirageTower3,
		SeaShrine1,
		SeaShrine2,
		SeaShrine2Room2,
		SeaShrineMermaids,
		SeaShrine4,
		SeaShrine5,
		SeaShrine6,
		SeaShrine7,
		SeaShrine8,
		SeaShrineKraken,
		SkyPalace1,
		SkyPalace2,
		SkyPalace3,
		SkyPalaceMaze,
		SkyPalaceTiamat,
		TempleOfFiends1,
		TempleOfFiends1Room1,
		TempleOfFiends1Room2,
		TempleOfFiends1Room3,
		TempleOfFiends1Room4,
		TempleOfFiends2,
		TempleOfFiends3,
		TempleOfFiendsPhantom,
		TempleOfFiendsEarth,
		TempleOfFiendsFire,
		TempleOfFiendsWater,
		TempleOfFiendsAir,
		TempleOfFiendsChaos,
		TitansTunnelEast,
		TitansTunnelWest,
	}
	public struct PlacedTeleport
	{
		public readonly OverworldTeleportIndex OverworldPlacement;
		public readonly Teleporter Teleporter;
		public readonly TeleportDestination Teleport;
		public PlacedTeleport(TeleportDestination destination, OverworldTeleportIndex overworldIndex, Teleporter standardIndex = Teleporter.Overworld)
		{
			OverworldPlacement = overworldIndex;
			Teleporter = standardIndex;
			Teleport = destination;
		}
	}
	
	public enum ExitTeleportIndex : byte
	{
		ExitTitanE = 0,
		ExitTitanW = 1,
		ExitIceCave = 2,
		ExitCastleOrdeals = 3,
		ExitCastleConeria = 4,
		ExitEarthCave = 5,
		ExitGurguVolcano = 6,
		ExitSeaShrine = 7,
		ExitSkyPalace = 8,
		ExitUnused1 = 9,
		ExitUnused2 = 10,
		ExitUnused3 = 11,
		ExitUnused4 = 12,
		ExitUnused5 = 13,
		ExitUnused6 = 14,
		ExitUnused7 = 15,
		None = 255
	}
	public enum TeleportIndex : byte
	{
		ConeriaCastle1 = 0, // to go upstairs
		TimeWarp = 1,
		MarshCave1 = 2,
		MarshCave2 = 3,
		MarshCave3 = 4,
		EarthCave1 = 5,
		EarthCave2 = 6,
		EarthCave3 = 7,
		EarthCave4 = 8,
		Gurgu1 = 9,
		Gurgu2 = 10,
		Gurgu3 = 11,
		Gurgu4 = 12,
		Gurgu5 = 13,
		Gurgu6 = 14,
		IceCave1 = 15,
		IceCave2 = 16,
		IceCave3 = 17,
		IceCave4 = 18,
		IceCave5 = 19,
		IceCave6 = 20,
		IceCave7 = 21,
		CastleOrdeals1 = 22,
		CastleOrdeals2 = 23,
		CastleOrdeals3 = 24,
		BahamutsRoom = 25,
		CastleOrdeals4 = 26,
		CastleOrdeals5 = 27,
		CastleOrdeals6 = 28,
		CastleOrdeals7 = 29,
		CastleOrdeals8 = 30,
		CastleOrdeals9 = 31,
		SeaShrine1 = 32,
		SeaShrine2 = 33,
		SeaShrine3 = 34,
		SeaShrine4 = 35,
		SeaShrine5 = 36,
		SeaShrine6 = 37,
		SeaShrine7 = 38,
		SeaShrine8 = 39,
		SeaShrine9 = 40,
		MirageTower1 = 41,
		MirageTower2 = 42,
		SkyPalace1 = 43,
		SkyPalace2 = 44,
		SkyPalace3 = 45,
		SkyPalace4 = 46,
		SkyPalace5 = 47,
		TempleOfFiends1 = 48,
		TempleOfFiends2 = 49,
		TempleOfFiends3 = 50,
		TempleOfFiends4 = 51,
		TempleOfFiends5 = 52,
		TempleOfFiends6 = 53,
		TempleOfFiends7 = 54,
		TempleOfFiends8 = 55,
		TempleOfFiends9 = 56,
		TempleOfFiends10 = 57,
		CastleOrdeals10 = 58,
		CastleOrdeals11 = 59,
		CastleOrdeals12 = 60,
		CastleOrdeals13 = 61,
		ConeriaCastle = 62, // going back down
		RescuePrincess = 63,
		Overworld = 255
	}
	public static class TeleportShuffle
	{
		//public static TeleportDestination Hack => new TeleportDestination(MapLocation.Coneria, MapIndex.CastleOrdeals2F, new Coordinate(20, 20));
		public static TeleportDestination Coneria => new TeleportDestination(MapLocation.Coneria, MapIndex.ConeriaTown, new Coordinate(16, 23));
		public static TeleportDestination Pravoka => new TeleportDestination(MapLocation.Pravoka, MapIndex.Pravoka, new Coordinate(19, 32));
		public static TeleportDestination Elfland => new TeleportDestination(MapLocation.Elfland, MapIndex.Elfland, new Coordinate(41, 22));
		public static TeleportDestination Melmond => new TeleportDestination(MapLocation.Melmond, MapIndex.Melmond, new Coordinate(1, 16));
		public static TeleportDestination CrescentLake => new TeleportDestination(MapLocation.CresentLake, MapIndex.CrescentLake, new Coordinate(11, 23));
		public static TeleportDestination Gaia => new TeleportDestination(MapLocation.Gaia, MapIndex.Gaia, new Coordinate(61, 61));
		public static TeleportDestination Onrac => new TeleportDestination(MapLocation.Onrac, MapIndex.Onrac, new Coordinate(1, 12), TeleportIndex.SeaShrine1);
		public static TeleportDestination Lefein => new TeleportDestination(MapLocation.Lefein, MapIndex.Lefein, new Coordinate(19, 23));
		public static TeleportDestination ConeriaCastle1 => new TeleportDestination(MapLocation.ConeriaCastle1, MapIndex.ConeriaCastle1F, new Coordinate(12, 35), ExitTeleportIndex.ExitCastleConeria);
		public static TeleportDestination ConeriaCastle2 => new TeleportDestination(MapLocation.ConeriaCastle2, MapIndex.ConeriaCastle2F, new Coordinate(12, 18)); // Could be used if the teleporter here is turned into warp stairs
		public static TeleportDestination ElflandCastle => new TeleportDestination(MapLocation.ElflandCastle, MapIndex.ElflandCastle, new Coordinate(16, 31));
		public static TeleportDestination NorthwestCastle => new TeleportDestination(MapLocation.NorthwestCastle, MapIndex.NorthwestCastle, new Coordinate(22, 24));
		public static TeleportDestination CastleOrdeals1 => new TeleportDestination(MapLocation.CastleOrdeals1, MapIndex.CastleOrdeals1F, new Coordinate(12, 21), ExitTeleportIndex.ExitCastleOrdeals);
		public static TeleportDestination CastleOrdealsMaze => new TeleportDestination(MapLocation.CastleOrdealsMaze, MapIndex.CastleOrdeals2F, new Coordinate(12, 12), TeleportIndex.CastleOrdeals2);
		public static TeleportDestination CastleOrdealsTop => new TeleportDestination(MapLocation.CastleOrdealsTop, MapIndex.CastleOrdeals3F, new Coordinate(22, 22), TeleportIndex.CastleOrdeals3);
		public static TeleportDestination TempleOfFiends => new TeleportDestination(MapLocation.TempleOfFiends1, MapIndex.TempleOfFiends, new Coordinate(20, 30));
		public static TeleportDestination DwarfCave => new TeleportDestination(MapLocation.DwarfCave, MapIndex.DwarfCave, new Coordinate(22, 11));
		public static TeleportDestination MatoyasCave => new TeleportDestination(MapLocation.MatoyasCave, MapIndex.MatoyasCave, new Coordinate(15, 11));
		public static TeleportDestination SardasCave => new TeleportDestination(MapLocation.SardasCave, MapIndex.SardasCave, new Coordinate(18, 13));
		public static TeleportDestination Cardia1 => new TeleportDestination(MapLocation.Cardia1, MapIndex.Cardia, new Coordinate(30, 18));
		public static TeleportDestination Cardia2 => new TeleportDestination(MapLocation.Cardia2, MapIndex.Cardia, new Coordinate(12, 15));
		public static TeleportDestination BahamutCaveB1 => new TeleportDestination(MapLocation.BahamutCave1, MapIndex.BahamutCaveB1, new Coordinate(2, 2), TeleportIndex.BahamutsRoom);
		public static TeleportDestination BahamutCaveB2 => new TeleportDestination(MapLocation.BahamutCave2, MapIndex.BahamutCaveB2, new Coordinate(23, 55));
		public static TeleportDestination Cardia4 => new TeleportDestination(MapLocation.Cardia4, MapIndex.Cardia, new Coordinate(19, 36));
		public static TeleportDestination Cardia5 => new TeleportDestination(MapLocation.Cardia5, MapIndex.Cardia, new Coordinate(43, 29));
		public static TeleportDestination Cardia6 => new TeleportDestination(MapLocation.Cardia6, MapIndex.Cardia, new Coordinate(58, 55));
		public static TeleportDestination IceCave1 => new TeleportDestination(MapLocation.IceCave1, MapIndex.IceCaveB1, new Coordinate(7, 1), TeleportIndex.IceCave1);
		public static TeleportDestination IceCave2 => new TeleportDestination(MapLocation.IceCave2, MapIndex.IceCaveB2, new Coordinate(30, 2), TeleportIndex.IceCave2);
		public static TeleportDestination IceCave3 => new TeleportDestination(MapLocation.IceCave3, MapIndex.IceCaveB3, new Coordinate(3, 2), TeleportIndex.IceCave3);
		public static TeleportDestination IceCavePitRoom => new TeleportDestination(MapLocation.IceCavePitRoom, MapIndex.IceCaveB2, new Coordinate(55, 5), ExitTeleportIndex.ExitIceCave);
		public static TeleportDestination Waterfall => new TeleportDestination(MapLocation.Waterfall, MapIndex.Waterfall, new Coordinate(57, 56));
		public static TeleportDestination TitansTunnelEast => new TeleportDestination(MapLocation.TitansTunnelEast, MapIndex.TitansTunnel, new Coordinate(11, 14), ExitTeleportIndex.ExitTitanE);
		public static TeleportDestination TitansTunnelWest => new TeleportDestination(MapLocation.TitansTunnelWest, MapIndex.TitansTunnel, new Coordinate(5, 3), ExitTeleportIndex.ExitTitanW);
		public static TeleportDestination EarthCave1 => new TeleportDestination(MapLocation.EarthCave1, MapIndex.EarthCaveB1, new Coordinate(23, 24), TeleportIndex.EarthCave1);
		public static TeleportDestination EarthCave2 => new TeleportDestination(MapLocation.EarthCave2, MapIndex.EarthCaveB2, new Coordinate(10, 9), TeleportIndex.EarthCave2);
		public static TeleportDestination EarthCaveVampire => new TeleportDestination(MapLocation.EarthCaveVampire, MapIndex.EarthCaveB3, new Coordinate(27, 45), TeleportIndex.EarthCave3);
		public static TeleportDestination EarthCave4 => new TeleportDestination(MapLocation.EarthCave4, MapIndex.EarthCaveB4, new Coordinate(61, 33), TeleportIndex.EarthCave4);
		public static TeleportDestination EarthCaveLich => new TeleportDestination(MapLocation.EarthCaveLich, MapIndex.EarthCaveB5, new Coordinate(25, 53), ExitTeleportIndex.ExitEarthCave);
		public static TeleportDestination GurguVolcano1 => new TeleportDestination(MapLocation.GurguVolcano1, MapIndex.GurguVolcanoB1, new Coordinate(27, 15), TeleportIndex.Gurgu1);
		public static TeleportDestination GurguVolcano2 => new TeleportDestination(MapLocation.GurguVolcano2, MapIndex.GurguVolcanoB2, new Coordinate(30, 32), TeleportIndex.Gurgu2);
		public static TeleportDestination GurguVolcano3 => new TeleportDestination(MapLocation.GurguVolcano3, MapIndex.GurguVolcanoB3, new Coordinate(18, 2), TeleportIndex.Gurgu3);
		public static TeleportDestination GurguVolcano4 => new TeleportDestination(MapLocation.GurguVolcano4, MapIndex.GurguVolcanoB4, new Coordinate(3, 23), TeleportIndex.Gurgu4);
		public static TeleportDestination GurguVolcano5 => new TeleportDestination(MapLocation.GurguVolcano5, MapIndex.GurguVolcanoB3, new Coordinate(46, 23), TeleportIndex.Gurgu5);
		public static TeleportDestination GurguVolcano6 => new TeleportDestination(MapLocation.GurguVolcano6, MapIndex.GurguVolcanoB4, new Coordinate(35, 6), TeleportIndex.Gurgu6);
		public static TeleportDestination GurguVolcanoKary => new TeleportDestination(MapLocation.GurguVolcanoKary, MapIndex.GurguVolcanoB5, new Coordinate(32, 31), ExitTeleportIndex.ExitGurguVolcano);
		public static TeleportDestination MarshCave1 => new TeleportDestination(MapLocation.MarshCave1, MapIndex.MarshCaveB1, new Coordinate(21, 27), new List<TeleportIndex> { TeleportIndex.MarshCave1, TeleportIndex.MarshCave2});
		public static TeleportDestination MarshCave2 => new TeleportDestination(MapLocation.MarshCave2, MapIndex.MarshCaveB2, new Coordinate(18, 16));
		public static TeleportDestination MarshCave3 => new TeleportDestination(MapLocation.MarshCave3, MapIndex.MarshCaveB2, new Coordinate(34, 37), TeleportIndex.MarshCave3);
		public static TeleportDestination MarshCaveBottom => new TeleportDestination(MapLocation.MarshCaveBottom, MapIndex.MarshCaveB3, new Coordinate(5, 6));
		public static TeleportDestination MirageTower1 => new TeleportDestination(MapLocation.MirageTower1, MapIndex.MirageTower1F, new Coordinate(17, 31), TeleportIndex.MirageTower1);
		public static TeleportDestination MirageTower2 => new TeleportDestination(MapLocation.MirageTower2, MapIndex.MirageTower2F, new Coordinate(16, 31), TeleportIndex.MirageTower2);
		public static TeleportDestination MirageTower3 => new TeleportDestination(MapLocation.MirageTower3, MapIndex.MirageTower3F, new Coordinate(8, 1), TeleportIndex.SkyPalace1);
		public static TeleportDestination SeaShrineMermaids => new TeleportDestination(MapLocation.SeaShrineMermaids, MapIndex.SeaShrineB1, new Coordinate(12, 26));
		public static TeleportDestination SeaShrine2 => new TeleportDestination(MapLocation.SeaShrine2, MapIndex.SeaShrineB2, new Coordinate(45, 8), TeleportIndex.SeaShrine4);
		public static TeleportDestination SeaShrine1 => new TeleportDestination(MapLocation.SeaShrine1, MapIndex.SeaShrineB3, new Coordinate(21, 42), new List<TeleportIndex>{TeleportIndex.SeaShrine2, TeleportIndex.SeaShrine3});
		public static TeleportDestination SeaShrine4 => new TeleportDestination(MapLocation.SeaShrine4, MapIndex.SeaShrineB4, new Coordinate(61, 49), TeleportIndex.SeaShrine5);
		public static TeleportDestination SeaShrine5 => new TeleportDestination(MapLocation.SeaShrine5, MapIndex.SeaShrineB3, new Coordinate(47, 39), TeleportIndex.SeaShrine6);
		public static TeleportDestination SeaShrine6 => new TeleportDestination(MapLocation.SeaShrine6, MapIndex.SeaShrineB2, new Coordinate(54, 41), TeleportIndex.SeaShrine7);
		public static TeleportDestination SeaShrine7 => new TeleportDestination(MapLocation.SeaShrine7, MapIndex.SeaShrineB3, new Coordinate(48, 10), TeleportIndex.SeaShrine8);
		public static TeleportDestination SeaShrine8 => new TeleportDestination(MapLocation.SeaShrine8, MapIndex.SeaShrineB4, new Coordinate(45, 20), TeleportIndex.SeaShrine9);
		public static TeleportDestination SeaShrineKraken => new TeleportDestination(MapLocation.SeaShrineKraken, MapIndex.SeaShrineB5, new Coordinate(50, 48), ExitTeleportIndex.ExitSeaShrine);
		public static TeleportDestination SkyPalace1 => new TeleportDestination(MapLocation.SkyPalace1, MapIndex.SkyPalace1F, new Coordinate(19, 21), TeleportIndex.SkyPalace2);
		public static TeleportDestination SkyPalace2 => new TeleportDestination(MapLocation.SkyPalace2, MapIndex.SkyPalace2F, new Coordinate(19, 4), TeleportIndex.SkyPalace3);
		public static TeleportDestination SkyPalace3 => new TeleportDestination(MapLocation.SkyPalace3, MapIndex.SkyPalace3F, new Coordinate(24, 23), TeleportIndex.SkyPalace4);
		public static TeleportDestination SkyPalaceMaze => new TeleportDestination(MapLocation.SkyPalaceMaze, MapIndex.SkyPalace4F, new Coordinate(3, 3), TeleportIndex.SkyPalace5);
		public static TeleportDestination SkyPalaceTiamat => new TeleportDestination(MapLocation.SkyPalaceTiamat, MapIndex.SkyPalace5F, new Coordinate(7, 54), ExitTeleportIndex.ExitSkyPalace);
		public static List<MapIndex> InRoomMaps = new List<MapIndex> { MapIndex.SkyPalace1F, MapIndex.MarshCaveB3, MapIndex.CastleOrdeals2F };
		public static Dictionary<TeleportIndex, AccessRequirement> TeleportRestrictions = 
			new Dictionary<TeleportIndex, AccessRequirement>
			{
				{TeleportIndex.CastleOrdeals1, AccessRequirement.Crown},
				{TeleportIndex.SkyPalace1, AccessRequirement.Cube},
				{TeleportIndex.SeaShrine1, AccessRequirement.Oxyale},
				{TeleportIndex.EarthCave3, AccessRequirement.Rod},
				{TeleportIndex.TempleOfFiends1, AccessRequirement.BlackOrb}, // needs to be verified
				{TeleportIndex.TempleOfFiends4, AccessRequirement.Lute} // needs to be verified
			};
		
		public static List<TeleportDestination> NonTownForcedTopFloors =>
		 	new List<TeleportDestination>
			{
				TitansTunnelEast, TitansTunnelWest, ConeriaCastle1, CastleOrdeals1
			};
		public static List<TeleportDestination> TownTeleports =>
		 	new List<TeleportDestination>
			{
				Coneria, Pravoka, Elfland, Melmond, CrescentLake, Gaia, Onrac, Lefein
			};
		public static List<TeleportDestination> ForcedTopFloors =>
		 	TownTeleports.Concat(NonTownForcedTopFloors).ToList();
		public static List<TeleportDestination> FreePlacementFloors => 
		 	new List<TeleportDestination>
			{
				ElflandCastle, NorthwestCastle, TempleOfFiends, 
				DwarfCave, MatoyasCave, SardasCave, Cardia1, Cardia2, BahamutCaveB1, BahamutCaveB2, Cardia4, Cardia5, Cardia6, 
				IceCave1, IceCave2, IceCave3, IceCavePitRoom, 
				Waterfall,
				EarthCave1, EarthCave2, EarthCaveVampire, EarthCave4, EarthCaveLich, 
				GurguVolcano1, GurguVolcano2, GurguVolcano3, GurguVolcano4, GurguVolcano5, GurguVolcano6, GurguVolcanoKary, 
				MarshCave1, MarshCave2, MarshCave3, MarshCaveBottom, 
				MirageTower1, MirageTower2, MirageTower3, 
				SeaShrineMermaids, SeaShrine2, SeaShrine1, SeaShrine4, SeaShrine5, SeaShrine6, SeaShrine7, SeaShrine8, SeaShrineKraken, 
				SkyPalace1, SkyPalace2, SkyPalace3, SkyPalaceMaze, SkyPalaceTiamat
			};
		public static List<TeleportDestination> FloorTeleports =>
		 	ForcedTopFloors.Concat(FreePlacementFloors).ToList();
			
		public static Dictionary<OverworldTeleportIndex, Coordinate> OverworldCoordinates =>
			new Dictionary<OverworldTeleportIndex, Coordinate>
			{
				{OverworldTeleportIndex.Coneria,new Coordinate(152, 162)},
				{OverworldTeleportIndex.Pravoka,new Coordinate(210, 150)},
				{OverworldTeleportIndex.Elfland,new Coordinate(136, 222)},
				{OverworldTeleportIndex.Melmond,new Coordinate(81, 160)},
				{OverworldTeleportIndex.CresentLake,new Coordinate(219, 218)},
				{OverworldTeleportIndex.Gaia,new Coordinate(221, 28)}, // requires airship
				{OverworldTeleportIndex.Onrac,new Coordinate(62, 56)},
				{OverworldTeleportIndex.Lefein,new Coordinate(235, 99)},
				{OverworldTeleportIndex.ConeriaCastle1,new Coordinate(153, 159)},
				{OverworldTeleportIndex.ElflandCastle,new Coordinate(136, 221)},
				{OverworldTeleportIndex.NorthwestCastle,new Coordinate(103, 186)},
				{OverworldTeleportIndex.CastleOrdeals1,new Coordinate(130, 45)}, // requires canoe
				{OverworldTeleportIndex.TempleOfFiends1,new Coordinate(130, 123)},
				{OverworldTeleportIndex.EarthCave1,new Coordinate(65, 187)},
				{OverworldTeleportIndex.GurguVolcano1,new Coordinate(188, 205)},
				{OverworldTeleportIndex.IceCave1,new Coordinate(197, 183)},
				{OverworldTeleportIndex.Cardia1,new Coordinate(92, 48)},
				{OverworldTeleportIndex.Cardia2,new Coordinate(79, 49)}, // requires airship
				{OverworldTeleportIndex.BahamutCave1,new Coordinate(96, 51)},
				{OverworldTeleportIndex.Cardia4,new Coordinate(93, 58)}, // requires airship
				{OverworldTeleportIndex.Cardia5,new Coordinate(105, 59)}, // requires airship
				{OverworldTeleportIndex.Cardia6,new Coordinate(116, 66)}, // requires airship
				{OverworldTeleportIndex.Waterfall,new Coordinate(54, 29)}, // requires canoe
				{OverworldTeleportIndex.DwarfCave,new Coordinate(100, 155)},
				{OverworldTeleportIndex.MatoyasCave,new Coordinate(168, 117)},
				{OverworldTeleportIndex.SardasCave,new Coordinate(30, 190)},
				{OverworldTeleportIndex.MarshCave1,new Coordinate(102, 236)},
				{OverworldTeleportIndex.MirageTower1,new Coordinate(194, 59)}, // requires chime
				{OverworldTeleportIndex.TitansTunnelEast,new Coordinate(42, 174)},
				{OverworldTeleportIndex.TitansTunnelWest,new Coordinate(30, 175)}
			};
		public static Dictionary<OverworldTeleportIndex, MapLocation> OverworldMapLocations =>
			new Dictionary<OverworldTeleportIndex, MapLocation>
			{
				{OverworldTeleportIndex.Coneria,MapLocation.Coneria},
				{OverworldTeleportIndex.Pravoka,MapLocation.Pravoka},
				{OverworldTeleportIndex.Elfland,MapLocation.Elfland},
				{OverworldTeleportIndex.Melmond,MapLocation.Melmond},
				{OverworldTeleportIndex.CresentLake,MapLocation.CresentLake},
				{OverworldTeleportIndex.Gaia,MapLocation.Gaia}, // requires airship
				{OverworldTeleportIndex.Onrac,MapLocation.Onrac},
				{OverworldTeleportIndex.Lefein,MapLocation.Lefein},
				{OverworldTeleportIndex.ConeriaCastle1,MapLocation.ConeriaCastle1},
				{OverworldTeleportIndex.ElflandCastle,MapLocation.ElflandCastle},
				{OverworldTeleportIndex.NorthwestCastle,MapLocation.NorthwestCastle},
				{OverworldTeleportIndex.CastleOrdeals1,MapLocation.CastleOrdeals1}, // requires canoe
				{OverworldTeleportIndex.TempleOfFiends1,MapLocation.TempleOfFiends1},
				{OverworldTeleportIndex.EarthCave1,MapLocation.EarthCave1},
				{OverworldTeleportIndex.GurguVolcano1,MapLocation.GurguVolcano1},
				{OverworldTeleportIndex.IceCave1,MapLocation.IceCave1},
				{OverworldTeleportIndex.Cardia1,MapLocation.Cardia1},
				{OverworldTeleportIndex.Cardia2,MapLocation.Cardia2}, // requires airship
				{OverworldTeleportIndex.BahamutCave1,MapLocation.BahamutCave1},
				{OverworldTeleportIndex.Cardia4,MapLocation.Cardia4}, // requires airship
				{OverworldTeleportIndex.Cardia5,MapLocation.Cardia5}, // requires airship
				{OverworldTeleportIndex.Cardia6,MapLocation.Cardia6}, // requires airship
				{OverworldTeleportIndex.Waterfall,MapLocation.Waterfall}, // requires canoe
				{OverworldTeleportIndex.DwarfCave,MapLocation.DwarfCave},
				{OverworldTeleportIndex.MatoyasCave,MapLocation.MatoyasCave},
				{OverworldTeleportIndex.SardasCave,MapLocation.SardasCave},
				{OverworldTeleportIndex.MarshCave1,MapLocation.MarshCave1},
				{OverworldTeleportIndex.MirageTower1,MapLocation.MirageTower1}, // requires chime
				{OverworldTeleportIndex.TitansTunnelEast,MapLocation.TitansTunnelEast},
				{OverworldTeleportIndex.TitansTunnelWest,MapLocation.TitansTunnelWest},
			};
		public static TeleportDestination GetExitTeleport(OverworldTeleportIndex teleport) 
			=> new TeleportDestination(OverworldMapLocations[teleport], MapIndex.Overworld, OverworldCoordinates[teleport]);

		public static Dictionary<TeleportIndex, MapLocation> StandardMapLocations =>
			new Dictionary<TeleportIndex, MapLocation>
			{
				{TeleportIndex.ConeriaCastle1, MapLocation.ConeriaCastle2},
				{TeleportIndex.TimeWarp, MapLocation.TempleOfFiends2},
				{TeleportIndex.MarshCave1, MapLocation.MarshCave2},
				{TeleportIndex.MarshCave2, MapLocation.MarshCave3},
				{TeleportIndex.MarshCave3, MapLocation.MarshCaveBottom},
				{TeleportIndex.EarthCave1, MapLocation.EarthCave2},
				{TeleportIndex.EarthCave2, MapLocation.EarthCaveVampire},
				{TeleportIndex.EarthCave3, MapLocation.EarthCave4},
				{TeleportIndex.EarthCave4, MapLocation.EarthCaveLich},
				{TeleportIndex.Gurgu1, MapLocation.GurguVolcano2},
				{TeleportIndex.Gurgu2, MapLocation.GurguVolcano3},
				{TeleportIndex.Gurgu3, MapLocation.GurguVolcano4},
				{TeleportIndex.Gurgu4, MapLocation.GurguVolcano5},
				{TeleportIndex.Gurgu5, MapLocation.GurguVolcano6},
				{TeleportIndex.Gurgu6, MapLocation.GurguVolcanoKary},
				{TeleportIndex.IceCave1, MapLocation.IceCave2},
				{TeleportIndex.IceCave2, MapLocation.IceCave3},
				{TeleportIndex.IceCave3, MapLocation.IceCavePitRoom},
				{TeleportIndex.CastleOrdeals1, MapLocation.CastleOrdealsMaze},
				{TeleportIndex.CastleOrdeals2, MapLocation.CastleOrdealsTop},
				{TeleportIndex.CastleOrdeals3, MapLocation.CastleOrdeals1},
				{TeleportIndex.BahamutsRoom, MapLocation.BahamutCave2},
				{TeleportIndex.SeaShrine1, MapLocation.SeaShrine1},
				{TeleportIndex.SeaShrine2, MapLocation.SeaShrine2},
				{TeleportIndex.SeaShrine3, MapLocation.SeaShrineMermaids},
				{TeleportIndex.SeaShrine4, MapLocation.SeaShrine4},
				{TeleportIndex.SeaShrine5, MapLocation.SeaShrine5},
				{TeleportIndex.SeaShrine6, MapLocation.SeaShrine6},
				{TeleportIndex.SeaShrine7, MapLocation.SeaShrine7},
				{TeleportIndex.SeaShrine8, MapLocation.SeaShrine8},
				{TeleportIndex.SeaShrine9, MapLocation.SeaShrineKraken},
				{TeleportIndex.MirageTower1, MapLocation.MirageTower2},
				{TeleportIndex.MirageTower2, MapLocation.MirageTower3},
				{TeleportIndex.SkyPalace1, MapLocation.SkyPalace1},
				{TeleportIndex.SkyPalace2, MapLocation.SkyPalace2},
				{TeleportIndex.SkyPalace3, MapLocation.SkyPalace3},
				{TeleportIndex.SkyPalace4, MapLocation.SkyPalaceMaze},
				{TeleportIndex.SkyPalace5, MapLocation.SkyPalaceTiamat}
			};
	}
    public struct EntranceTeleport
    {
        public readonly MapLocation TeleportDestination;
        public readonly byte MapIndex;
        public readonly byte EnterCoordinateX;
        public readonly byte EnterCoordinateY;
        public readonly byte Tileset;
        public readonly byte ExitIndex;
		public string SpoilerText =>
		$"{Enum.GetName(typeof(MapLocation), TeleportDestination)}" +
		$"{string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - Enum.GetName(typeof(MapLocation), TeleportDestination).Length)).ToList())}";
        public EntranceTeleport(MapLocation mapLocation, byte mapIndex, byte coordinateX, byte coordinateY,
                           byte tileset, byte exitIndex = 0xFF)
        {
            TeleportDestination = mapLocation;
            MapIndex = mapIndex;
            EnterCoordinateX = coordinateX;
            EnterCoordinateY = coordinateY;
            Tileset = tileset;
            ExitIndex = exitIndex;
        }
    }
    public static class EntranceTeleports
    {
        public static EntranceTeleport ConeriaTown = new EntranceTeleport(MapLocation.Coneria, 0, 16, 23, 0);
        public static EntranceTeleport Pravoka = new EntranceTeleport(MapLocation.Pravoka, 1, 19, 32, 0);
        public static EntranceTeleport ElflandTown = new EntranceTeleport(MapLocation.Elfland, 2, 41, 22, 0);
        public static EntranceTeleport Melmond = new EntranceTeleport(MapLocation.Melmond, 3, 1, 16, 0);
        public static EntranceTeleport CresentLake = new EntranceTeleport(MapLocation.CresentLake, 4, 11, 23, 0);
        public static EntranceTeleport Gaia = new EntranceTeleport(MapLocation.Gaia, 5, 61, 61, 0);
        public static EntranceTeleport Onrac = new EntranceTeleport(MapLocation.Onrac, 6, 1, 12, 0, 7);
        public static EntranceTeleport Lefein = new EntranceTeleport(MapLocation.Lefein, 7, 19, 23, 0);
        
        public static EntranceTeleport ConeriaCastle = new EntranceTeleport(MapLocation.ConeriaCastle1, 8, 12, 35, 1, 4);
        public static EntranceTeleport ElflandCastle = new EntranceTeleport(MapLocation.ElflandCastle, 9, 16, 31, 1);
        public static EntranceTeleport NorthwestCastle = new EntranceTeleport(MapLocation.NorthwestCastle, 10, 22, 24, 1);
        public static EntranceTeleport CastleOrdeals = new EntranceTeleport(MapLocation.CastleOrdeals1, 11, 12, 21, 1, 3);
        public static EntranceTeleport TempleOfFiends = new EntranceTeleport(MapLocation.TempleOfFiends1, 12, 20, 30, 5);
        
        public static EntranceTeleport EarthCave = new EntranceTeleport(MapLocation.EarthCave1, 13, 23, 24, 2, 5);
        public static EntranceTeleport GurguVolcano = new EntranceTeleport(MapLocation.GurguVolcano1, 14, 27, 15, 2, 6);
        public static EntranceTeleport IceCave = new EntranceTeleport(MapLocation.IceCave1, 15, 7, 1, 3, 2);
        public static EntranceTeleport Cardia1 = new EntranceTeleport(MapLocation.Cardia1, 16, 30, 18, 3);
        public static EntranceTeleport Cardia2 = new EntranceTeleport(MapLocation.Cardia2, 16, 12, 15, 3);
        public static EntranceTeleport Cardia3 = new EntranceTeleport(MapLocation.BahamutCave1, 17, 2, 2, 3);
        public static EntranceTeleport Cardia4 = new EntranceTeleport(MapLocation.Cardia4, 16, 19, 36, 3);
        public static EntranceTeleport Cardia5 = new EntranceTeleport(MapLocation.Cardia5, 16, 43, 29, 3);
        public static EntranceTeleport Cardia6 = new EntranceTeleport(MapLocation.Cardia6, 16, 58, 55, 3);
        public static EntranceTeleport Waterfall = new EntranceTeleport(MapLocation.Waterfall, 18, 57, 56, 3);
        public static EntranceTeleport DwarfCave = new EntranceTeleport(MapLocation.DwarfCave, 19, 22, 11, 3);
        public static EntranceTeleport MatoyasCave = new EntranceTeleport(MapLocation.MatoyasCave, 20, 15, 11, 3);
        public static EntranceTeleport SardasCave = new EntranceTeleport(MapLocation.SardasCave, 21, 18, 13, 3);
        public static EntranceTeleport MarshCave = new EntranceTeleport(MapLocation.MarshCave1, 22, 21, 27, 4);
        public static EntranceTeleport MirageTower = new EntranceTeleport(MapLocation.MirageTower1, 23, 17, 31, 4, 8);
        public static EntranceTeleport TitansTunnelA = new EntranceTeleport(MapLocation.TitansTunnelEast, 60, 11, 14, 2, 0);
        public static EntranceTeleport TitansTunnelB = new EntranceTeleport(MapLocation.TitansTunnelWest, 60, 5, 3, 2, 1);
        public static EntranceTeleport Empty = new EntranceTeleport(MapLocation.Coneria, 0, 0, 0, 0);
    }
}
