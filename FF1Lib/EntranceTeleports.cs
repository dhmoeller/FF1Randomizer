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
	public struct Teleport
	{
        public readonly MapLocation TeleportDestination;
		public readonly MapIndex Index;
		public readonly byte CoordinateX;
		public readonly byte CoordinateY;
		public readonly OverworldExit Exit;
		public readonly bool Forked;
		public string SpoilerText =>
		$"{Enum.GetName(typeof(MapLocation), TeleportDestination)}" +
		$"{string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - Enum.GetName(typeof(MapLocation), TeleportDestination).Length)).ToList())}";
		public Teleport(MapLocation destination, MapIndex index, Coordinate coordinates, OverworldExit exit = OverworldExit.None, bool isForked = false)
		{
			TeleportDestination = destination;
			Index = index;
			CoordinateX = coordinates.X;
			CoordinateY = coordinates.Y;
			Exit = exit;
			Forked = isForked;
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
		public readonly Teleport Teleport;
		public PlacedTeleport(Teleport destination, OverworldTeleportIndex overworldIndex, Teleporter standardIndex = Teleporter.Overworld)
		{
			OverworldPlacement = overworldIndex;
			Teleporter = standardIndex;
			Teleport = destination;
		}
	}
	public static class TeleportShuffle
	{
		public static Teleport Coneria => new Teleport(MapLocation.Coneria, MapIndex.ConeriaTown, new Coordinate(16, 23));
		public static Teleport Pravoka => new Teleport(MapLocation.Pravoka, MapIndex.Pravoka, new Coordinate(19, 32));
		public static Teleport Elfland => new Teleport(MapLocation.Elfland, MapIndex.Elfland, new Coordinate(41, 22));
		public static Teleport Melmond => new Teleport(MapLocation.Melmond, MapIndex.Melmond, new Coordinate(1, 16));
		public static Teleport CrescentLake => new Teleport(MapLocation.CresentLake, MapIndex.CrescentLake, new Coordinate(11, 23));
		public static Teleport Gaia => new Teleport(MapLocation.Gaia, MapIndex.Gaia, new Coordinate(61, 61));
		public static Teleport Onrac => new Teleport(MapLocation.Onrac, MapIndex.Onrac, new Coordinate(1, 12));
		public static Teleport Lefein => new Teleport(MapLocation.Lefein, MapIndex.Lefein, new Coordinate(19, 23));
		public static Teleport ConeriaCastle1 => new Teleport(MapLocation.ConeriaCastle1, MapIndex.ConeriaCastle1F, new Coordinate(12, 35), OverworldExit.ExitCastleConeria);
		public static Teleport ElflandCastle => new Teleport(MapLocation.ElflandCastle, MapIndex.ElflandCastle, new Coordinate(16, 31));
		public static Teleport NorthwestCastle => new Teleport(MapLocation.NorthwestCastle, MapIndex.NorthwestCastle, new Coordinate(22, 24));
		public static Teleport CastleOrdeals1 => new Teleport(MapLocation.CastleOrdeals1, MapIndex.CastleOrdeals1F, new Coordinate(12, 21), OverworldExit.ExitCastleOrdeals);
		public static Teleport TempleOfFiends => new Teleport(MapLocation.TempleOfFiends1, MapIndex.TempleOfFiends, new Coordinate(20, 30));
		public static Teleport DwarfCave => new Teleport(MapLocation.DwarfCave, MapIndex.DwarfCave, new Coordinate(22, 11));
		public static Teleport MatoyasCave => new Teleport(MapLocation.MatoyasCave, MapIndex.MatoyasCave, new Coordinate(15, 11));
		public static Teleport SardasCave => new Teleport(MapLocation.SardasCave, MapIndex.SardasCave, new Coordinate(18, 13));
		public static Teleport Cardia1 => new Teleport(MapLocation.Cardia1, MapIndex.Cardia, new Coordinate(30, 18));
		public static Teleport Cardia2 => new Teleport(MapLocation.Cardia2, MapIndex.Cardia, new Coordinate(12, 15));
		public static Teleport BahamutCaveB1 => new Teleport(MapLocation.BahamutCave1, MapIndex.BahamutCaveB1, new Coordinate(2, 2));
		public static Teleport BahamutCaveB2 => new Teleport(MapLocation.BahamutCave2, MapIndex.BahamutCaveB2, new Coordinate(23, 45));
		public static Teleport Cardia4 => new Teleport(MapLocation.Cardia4, MapIndex.Cardia, new Coordinate(19, 36));
		public static Teleport Cardia5 => new Teleport(MapLocation.Cardia5, MapIndex.Cardia, new Coordinate(43, 29));
		public static Teleport Cardia6 => new Teleport(MapLocation.Cardia6, MapIndex.Cardia, new Coordinate(58, 55));
		public static Teleport IceCave1 => new Teleport(MapLocation.IceCave1, MapIndex.IceCaveB1, new Coordinate(7, 1));
		public static Teleport IceCave2 => new Teleport(MapLocation.IceCave2, MapIndex.IceCaveB2, new Coordinate(30, 2));
		public static Teleport IceCave3 => new Teleport(MapLocation.IceCave3, MapIndex.IceCaveB3, new Coordinate(3, 2));
		public static Teleport IceCavePitRoom => new Teleport(MapLocation.IceCavePitRoom, MapIndex.IceCaveB2, new Coordinate(55, 5), OverworldExit.ExitIceCave);
		public static Teleport Waterfall => new Teleport(MapLocation.Waterfall, MapIndex.Waterfall, new Coordinate(57, 56));
		public static Teleport TitansTunnelEast => new Teleport(MapLocation.TitansTunnelEast, MapIndex.TitansTunnel, new Coordinate(11, 14), OverworldExit.ExitTitanE);
		public static Teleport TitansTunnelWest => new Teleport(MapLocation.TitansTunnelWest, MapIndex.EarthCaveB1, new Coordinate(23, 24), OverworldExit.ExitTitanW);
		public static Teleport EarthCave1 => new Teleport(MapLocation.EarthCave1, MapIndex.EarthCaveB1, new Coordinate(23, 24));
		public static Teleport EarthCave2 => new Teleport(MapLocation.EarthCave2, MapIndex.EarthCaveB2, new Coordinate(10, 9));
		public static Teleport EarthCaveVampire => new Teleport(MapLocation.EarthCaveVampire, MapIndex.EarthCaveB3, new Coordinate(27, 45));
		public static Teleport EarthCave4 => new Teleport(MapLocation.EarthCave4, MapIndex.EarthCaveB4, new Coordinate(61, 33));
		public static Teleport EarthCaveLich => new Teleport(MapLocation.EarthCaveLich, MapIndex.EarthCaveB5, new Coordinate(25, 53), OverworldExit.ExitEarthCave);
		public static Teleport GurguVolcano1 => new Teleport(MapLocation.GurguVolcano1, MapIndex.GurguVolcanoB1, new Coordinate(27, 15));
		public static Teleport GurguVolcano2 => new Teleport(MapLocation.GurguVolcano2, MapIndex.GurguVolcanoB2, new Coordinate(30, 32));
		public static Teleport GurguVolcano3 => new Teleport(MapLocation.GurguVolcano3, MapIndex.GurguVolcanoB3, new Coordinate(18, 2));
		public static Teleport GurguVolcano4 => new Teleport(MapLocation.GurguVolcano4, MapIndex.GurguVolcanoB4, new Coordinate(3, 23));
		public static Teleport GurguVolcano5 => new Teleport(MapLocation.GurguVolcano5, MapIndex.GurguVolcanoB3, new Coordinate(46, 23));
		public static Teleport GurguVolcano6 => new Teleport(MapLocation.GurguVolcano6, MapIndex.GurguVolcanoB4, new Coordinate(35, 6));
		public static Teleport GurguVolcanoKary => new Teleport(MapLocation.GurguVolcanoKary, MapIndex.GurguVolcanoB5, new Coordinate(32, 31), OverworldExit.ExitGurguVolcano);
		public static Teleport MarshCave1 => new Teleport(MapLocation.MarshCave1, MapIndex.MarshCaveB1, new Coordinate(21, 27), isForked: true);
		public static Teleport MarshCave2 => new Teleport(MapLocation.MarshCave2, MapIndex.MarshCaveB2, new Coordinate(18, 16));
		public static Teleport MarshCaveBottom => new Teleport(MapLocation.MarshCaveBottom, MapIndex.MarshCaveB3, new Coordinate(5, 6));
		public static Teleport MirageTower1 => new Teleport(MapLocation.MirageTower1, MapIndex.MirageTower1F, new Coordinate(17, 31));
		public static Teleport MirageTower2 => new Teleport(MapLocation.MirageTower2, MapIndex.MirageTower2F, new Coordinate(16, 31));
		public static Teleport MirageTower3 => new Teleport(MapLocation.MirageTower3, MapIndex.MirageTower3F, new Coordinate(8, 1));
		public static Teleport SeaShrineMermaids => new Teleport(MapLocation.SeaShrineMermaids, MapIndex.SeaShrineB1, new Coordinate(12, 26));
		public static Teleport SeaShrine2 => new Teleport(MapLocation.SeaShrine2, MapIndex.SeaShrineB2, new Coordinate(45, 8));
		public static Teleport SeaShrine1 => new Teleport(MapLocation.SeaShrine1, MapIndex.SeaShrineB3, new Coordinate(21, 31), isForked:true);
		public static Teleport SeaShrine4 => new Teleport(MapLocation.SeaShrine4, MapIndex.SeaShrineB4, new Coordinate(61, 49));
		public static Teleport SeaShrine5 => new Teleport(MapLocation.SeaShrine5, MapIndex.SeaShrineB3, new Coordinate(47, 39));
		public static Teleport SeaShrine6 => new Teleport(MapLocation.SeaShrine6, MapIndex.SeaShrineB2, new Coordinate(54, 41));
		public static Teleport SeaShrine7 => new Teleport(MapLocation.SeaShrine7, MapIndex.SeaShrineB3, new Coordinate(48, 10));
		public static Teleport SeaShrine8 => new Teleport(MapLocation.SeaShrine8, MapIndex.SeaShrineB4, new Coordinate(45, 20));
		public static Teleport SeaShrineKraken => new Teleport(MapLocation.SeaShrineKraken, MapIndex.SeaShrineB5, new Coordinate(50, 48), OverworldExit.ExitSeaShrine);
		public static Teleport SkyPalace2 => new Teleport(MapLocation.SkyPalace2, MapIndex.SkyPalace2F, new Coordinate(19, 4));
		public static Teleport SkyPalace3 => new Teleport(MapLocation.SkyPalace3, MapIndex.SkyPalace3F, new Coordinate(24, 23));
		public static Teleport SkyPalaceMaze => new Teleport(MapLocation.SkyPalaceMaze, MapIndex.SkyPalace4F, new Coordinate(3, 3));
		public static Teleport SkyPalaceTiamat => new Teleport(MapLocation.SkyPalaceTiamat, MapIndex.SkyPalace5F, new Coordinate(7, 54), OverworldExit.ExitSkyPalace);
		public static List<Teleport> FloorTeleports =>
		 	new List<Teleport>
			{
				Coneria, Pravoka, Elfland, Melmond, CrescentLake, Gaia, Onrac, Lefein, 
				ConeriaCastle1, ElflandCastle, NorthwestCastle, CastleOrdeals1, TempleOfFiends, 
				DwarfCave, MatoyasCave, SardasCave, Cardia1, Cardia2, BahamutCaveB1, BahamutCaveB2, Cardia4, Cardia5, Cardia6, 
				IceCave1, IceCave2, IceCave3, IceCavePitRoom, 
				Waterfall, TitansTunnelEast, TitansTunnelWest, 
				EarthCave1, EarthCave2, EarthCaveVampire, EarthCave4, EarthCaveLich, 
				GurguVolcano1, GurguVolcano2, GurguVolcano3, GurguVolcano4, GurguVolcano5, GurguVolcano6, GurguVolcanoKary, 
				MarshCave1, MarshCave2, MarshCaveBottom, 
				MirageTower1, MirageTower2, MirageTower3, 
				SeaShrineMermaids, SeaShrine2, SeaShrine1, SeaShrine4, SeaShrine5, SeaShrine6, SeaShrine7, SeaShrine8, SeaShrineKraken, 
				SkyPalace2, SkyPalace3, SkyPalaceMaze, SkyPalaceTiamat
			};
		public static List<Teleport> ForkedFloorTeleports =>
			FloorTeleports.Where(x => x.Forked).ToList();
		public static List<Teleport> ExitFloorTeleports =>
			FloorTeleports.Where(x => x.Exit != OverworldExit.None).ToList();
		public static List<Teleport> EndFloors =>
			new List<Teleport>
			{
				Coneria, Pravoka, Elfland, Melmond, CrescentLake, Gaia, Lefein, 
				ConeriaCastle1, ElflandCastle, NorthwestCastle, CastleOrdeals1, TempleOfFiends, 
				DwarfCave, MatoyasCave, SardasCave, Cardia1, Cardia2, BahamutCaveB2, Cardia4, Cardia5, Cardia6,
				IceCavePitRoom, Waterfall, TitansTunnelEast, TitansTunnelWest, EarthCaveLich, GurguVolcanoKary,
				MarshCave2, MarshCaveBottom, SeaShrineMermaids, SeaShrineKraken, SkyPalaceTiamat
			};
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
		public static Teleport GetExitTeleport(OverworldTeleportIndex teleport) 
			=> new Teleport(OverworldMapLocations[teleport], MapIndex.Overworld, OverworldCoordinates[teleport]);
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
