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
	public static class TeleportShuffle
	{
		public static Teleport Coneria => new Teleport(MapLocation.Coneria, MapIndex.ConeriaTown, new Coordinate(16, 23));
		public static Teleport Pravoka => new Teleport(MapLocation.Coneria, MapIndex.Pravoka, new Coordinate(19, 32));
		public static Teleport Elfland => new Teleport(MapLocation.Coneria, MapIndex.Elfland, new Coordinate(41, 22));
		public static Teleport Melmond => new Teleport(MapLocation.Coneria, MapIndex.Melmond, new Coordinate(1, 16));
		public static Teleport CrescentLake => new Teleport(MapLocation.Coneria, MapIndex.CrescentLake, new Coordinate(11, 23));
		public static Teleport Gaia => new Teleport(MapLocation.Coneria, MapIndex.Gaia, new Coordinate(61, 61));
		public static Teleport Onrac => new Teleport(MapLocation.Coneria, MapIndex.Onrac, new Coordinate(1, 12));
		public static Teleport Lefein => new Teleport(MapLocation.Coneria, MapIndex.Lefein, new Coordinate(19, 23));
		public static Teleport ConeriaCastle1F => new Teleport(MapLocation.Coneria, MapIndex.ConeriaCastle1F, new Coordinate(12, 35), OverworldExit.ExitCastleConeria);
		public static Teleport ElflandCastle => new Teleport(MapLocation.Coneria, MapIndex.ElflandCastle, new Coordinate(16, 31));
		public static Teleport NorthwestCastle => new Teleport(MapLocation.Coneria, MapIndex.NorthwestCastle, new Coordinate(22, 24));
		public static Teleport CastleOrdeals1F => new Teleport(MapLocation.Coneria, MapIndex.CastleOrdeals1F, new Coordinate(12, 21), OverworldExit.ExitCastleOrdeals);
		public static Teleport TempleOfFiends => new Teleport(MapLocation.Coneria, MapIndex.TempleOfFiends, new Coordinate(20, 30));
		public static Teleport DwarfCave => new Teleport(MapLocation.Coneria, MapIndex.DwarfCave, new Coordinate(22, 11));
		public static Teleport MatoyasCave => new Teleport(MapLocation.Coneria, MapIndex.MatoyasCave, new Coordinate(15, 11));
		public static Teleport SardasCave => new Teleport(MapLocation.Coneria, MapIndex.SardasCave, new Coordinate(18, 13));
		public static Teleport Cardia1 => new Teleport(MapLocation.Coneria, MapIndex.Cardia, new Coordinate(30, 18));
		public static Teleport Cardia2 => new Teleport(MapLocation.Coneria, MapIndex.Cardia, new Coordinate(12, 15));
		public static Teleport BahamutCaveB1 => new Teleport(MapLocation.Coneria, MapIndex.BahamutCaveB1, new Coordinate(2, 2));
		public static Teleport BahamutCaveB2 => new Teleport(MapLocation.Coneria, MapIndex.BahamutCaveB2, new Coordinate(23, 45));
		public static Teleport Cardia4 => new Teleport(MapLocation.Coneria, MapIndex.Cardia, new Coordinate(19, 36));
		public static Teleport Cardia5 => new Teleport(MapLocation.Coneria, MapIndex.Cardia, new Coordinate(43, 29));
		public static Teleport Cardia6 => new Teleport(MapLocation.Coneria, MapIndex.Cardia, new Coordinate(58, 55));
		public static Teleport IceCaveB1A => new Teleport(MapLocation.Coneria, MapIndex.IceCaveB1, new Coordinate(7, 1));
		public static Teleport IceCaveB2A => new Teleport(MapLocation.Coneria, MapIndex.IceCaveB2, new Coordinate(30, 2));
		public static Teleport IceCaveB3 => new Teleport(MapLocation.Coneria, MapIndex.IceCaveB3, new Coordinate(3, 2));
		public static Teleport IceCaveB2B => new Teleport(MapLocation.Coneria, MapIndex.IceCaveB2, new Coordinate(55, 5), OverworldExit.ExitIceCave);
		public static Teleport Waterfall => new Teleport(MapLocation.Coneria, MapIndex.Waterfall, new Coordinate(57, 56));
		public static Teleport TitansTunnelEast => new Teleport(MapLocation.Coneria, MapIndex.TitansTunnel, new Coordinate(11, 14), OverworldExit.ExitTitanE);
		public static Teleport TitansTunnelWest => new Teleport(MapLocation.Coneria, MapIndex.EarthCaveB1, new Coordinate(23, 24), OverworldExit.ExitTitanW);
		public static Teleport EarthCaveB1 => new Teleport(MapLocation.Coneria, MapIndex.EarthCaveB1, new Coordinate(23, 24));
		public static Teleport EarthCaveB2 => new Teleport(MapLocation.Coneria, MapIndex.EarthCaveB2, new Coordinate(10, 9));
		public static Teleport EarthCaveB3 => new Teleport(MapLocation.Coneria, MapIndex.EarthCaveB3, new Coordinate(27, 45));
		public static Teleport EarthCaveB4 => new Teleport(MapLocation.Coneria, MapIndex.EarthCaveB4, new Coordinate(61, 33));
		public static Teleport EarthCaveLich => new Teleport(MapLocation.Coneria, MapIndex.EarthCaveB5, new Coordinate(25, 53), OverworldExit.ExitEarthCave);
		public static Teleport GurguVolcanoB1 => new Teleport(MapLocation.Coneria, MapIndex.GurguVolcanoB1, new Coordinate(27, 15));
		public static Teleport GurguVolcanoB2 => new Teleport(MapLocation.Coneria, MapIndex.GurguVolcanoB2, new Coordinate(30, 32));
		public static Teleport GurguVolcanoB3A => new Teleport(MapLocation.Coneria, MapIndex.GurguVolcanoB3, new Coordinate(18, 2));
		public static Teleport GurguVolcanoB4A => new Teleport(MapLocation.Coneria, MapIndex.GurguVolcanoB4, new Coordinate(3, 23));
		public static Teleport GurguVolcanoB3B => new Teleport(MapLocation.Coneria, MapIndex.GurguVolcanoB3, new Coordinate(46, 23));
		public static Teleport GurguVolcanoB4B => new Teleport(MapLocation.Coneria, MapIndex.GurguVolcanoB4, new Coordinate(35, 6));
		public static Teleport GurguVolcanoKary => new Teleport(MapLocation.Coneria, MapIndex.GurguVolcanoB5, new Coordinate(32, 31), OverworldExit.ExitGurguVolcano);
		public static Teleport MarshCaveB1 => new Teleport(MapLocation.Coneria, MapIndex.MarshCaveB1, new Coordinate(21, 27), isForked: true);
		public static Teleport MarshCaveB2 => new Teleport(MapLocation.Coneria, MapIndex.MarshCaveB2, new Coordinate(18, 16));
		public static Teleport MarshCaveBottom => new Teleport(MapLocation.Coneria, MapIndex.MarshCaveB3, new Coordinate(5, 6));
		public static Teleport MirageTower1F => new Teleport(MapLocation.Coneria, MapIndex.MirageTower1F, new Coordinate(17, 31));
		public static Teleport MirageTower2F => new Teleport(MapLocation.Coneria, MapIndex.MirageTower2F, new Coordinate(16, 31));
		public static Teleport MirageTower3F => new Teleport(MapLocation.Coneria, MapIndex.MirageTower3F, new Coordinate(8, 1));
		public static Teleport SeaShrineMermaids => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB1, new Coordinate(12, 26));
		public static Teleport SeaShrineB2A => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB2, new Coordinate(45, 8));
		public static Teleport SeaShrineB3A => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB3, new Coordinate(21, 31), isForked:true);
		public static Teleport SeaShrineB4 => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB4, new Coordinate(61, 49));
		public static Teleport SeaShrineB3B => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB3, new Coordinate(47, 39));
		public static Teleport SeaShrineB2B => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB2, new Coordinate(54, 41));
		public static Teleport SeaShrineB3C => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB3, new Coordinate(48, 10));
		public static Teleport SeaShrineB4B => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB4, new Coordinate(45, 20));
		public static Teleport SeaShrineKraken => new Teleport(MapLocation.Coneria, MapIndex.SeaShrineB5, new Coordinate(50, 48), OverworldExit.ExitSeaShrine);
		public static Teleport SkyPalace2F => new Teleport(MapLocation.Coneria, MapIndex.SkyPalace2F, new Coordinate(19, 4));
		public static Teleport SkyPalace3F => new Teleport(MapLocation.Coneria, MapIndex.SkyPalace3F, new Coordinate(24, 23));
		public static Teleport SkyPalaceMaze => new Teleport(MapLocation.Coneria, MapIndex.SkyPalace4F, new Coordinate(3, 3));
		public static Teleport SkyPalaceTiamat => new Teleport(MapLocation.Coneria, MapIndex.SkyPalace5F, new Coordinate(7, 54), OverworldExit.ExitSkyPalace);
		public static List<Teleport> FloorTeleports =>
		 	new List<Teleport>
			{
				Coneria, Pravoka, Elfland, Melmond, CrescentLake, Gaia, Onrac, Lefein, 
				ConeriaCastle1F, ElflandCastle, NorthwestCastle, CastleOrdeals1F, TempleOfFiends, 
				DwarfCave, MatoyasCave, SardasCave, Cardia1, Cardia2, BahamutCaveB1, BahamutCaveB2, Cardia4, Cardia5, Cardia6, 
				IceCaveB1A, IceCaveB2A, IceCaveB3, IceCaveB2B, 
				Waterfall, TitansTunnelEast, TitansTunnelWest, 
				EarthCaveB1, EarthCaveB2, EarthCaveB3, EarthCaveB4, EarthCaveLich, 
				GurguVolcanoB1, GurguVolcanoB2, GurguVolcanoB3A, GurguVolcanoB4A, GurguVolcanoB3B, GurguVolcanoB4B, GurguVolcanoKary, 
				MarshCaveB1, MarshCaveB2, MarshCaveBottom, 
				MirageTower1F, MirageTower2F, MirageTower3F, 
				SeaShrineMermaids, SeaShrineB2A, SeaShrineB3A, SeaShrineB4, SeaShrineB3B, SeaShrineB2B, SeaShrineB3C, SeaShrineB4B, SeaShrineKraken, 
				SkyPalace2F, SkyPalace3F, SkyPalaceMaze, SkyPalaceTiamat
			};
		public static List<Teleport> ForkedFloorTeleports =>
			FloorTeleports.Where(x => x.Forked).ToList();
		public static List<Teleport> ExitFloorTeleports =>
			FloorTeleports.Where(x => x.Exit != OverworldExit.None).ToList();
		public static List<Teleport> EndFloors =>
			new List<Teleport>
			{
				Coneria, Pravoka, Elfland, Melmond, CrescentLake, Gaia, Lefein, 
				ConeriaCastle1F, ElflandCastle, NorthwestCastle, CastleOrdeals1F, TempleOfFiends, 
				DwarfCave, MatoyasCave, SardasCave, Cardia1, Cardia2, BahamutCaveB2, Cardia4, Cardia5, Cardia6,
				IceCaveB2B, Waterfall, TitansTunnelEast, TitansTunnelWest, EarthCaveLich, GurguVolcanoKary,
				MarshCaveB2, MarshCaveBottom, SeaShrineMermaids, SeaShrineKraken, SkyPalaceTiamat
			};
		public static Dictionary<MapLocation, Coordinate> OverworldCoordinates =>
			new Dictionary<MapLocation, Coordinate>
			{
				{MapLocation.Coneria,new Coordinate(152, 162)},
				{MapLocation.Pravoka,new Coordinate(210, 150)},
				{MapLocation.Elfland,new Coordinate(136, 222)},
				{MapLocation.Melmond,new Coordinate(81, 160)},
				{MapLocation.CresentLake,new Coordinate(219, 218)},
				{MapLocation.Gaia,new Coordinate(221, 28)}, // requires airship
				{MapLocation.Onrac,new Coordinate(62, 56)},
				{MapLocation.Lefein,new Coordinate(235, 99)},
				{MapLocation.ConeriaCastle1,new Coordinate(153, 159)},
				{MapLocation.ElflandCastle,new Coordinate(136, 221)},
				{MapLocation.NorthwestCastle,new Coordinate(103, 186)},
				{MapLocation.CastleOrdeals1,new Coordinate(130, 45)}, // requires canoe
				{MapLocation.TempleOfFiends1,new Coordinate(130, 123)},
				{MapLocation.EarthCave1,new Coordinate(65, 187)},
				{MapLocation.GurguVolcano1,new Coordinate(188, 205)},
				{MapLocation.IceCave1,new Coordinate(197, 183)},
				{MapLocation.Cardia1,new Coordinate(92, 48)},
				{MapLocation.Cardia2,new Coordinate(79, 49)}, // requires airship
				{MapLocation.BahamutCave1,new Coordinate(96, 51)},
				{MapLocation.Cardia4,new Coordinate(93, 58)}, // requires airship
				{MapLocation.Cardia5,new Coordinate(105, 59)}, // requires airship
				{MapLocation.Cardia6,new Coordinate(116, 66)}, // requires airship
				{MapLocation.Waterfall,new Coordinate(54, 29)}, // requires canoe
				{MapLocation.DwarfCave,new Coordinate(100, 155)},
				{MapLocation.MatoyasCave,new Coordinate(168, 117)},
				{MapLocation.SardasCave,new Coordinate(30, 190)},
				{MapLocation.MarshCave1,new Coordinate(102, 236)},
				{MapLocation.MirageTower1,new Coordinate(194, 59)}, // requires chime
				{MapLocation.TitansTunnelEast,new Coordinate(42, 174)},
				{MapLocation.TitansTunnelWest,new Coordinate(30, 175)}
			};
		public static Teleport GetExitTeleport(MapLocation mapLocation) 
			=> new Teleport(mapLocation, MapIndex.Overworld, OverworldCoordinates[mapLocation]);
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
