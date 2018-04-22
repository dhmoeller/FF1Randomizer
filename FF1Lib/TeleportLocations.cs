using System;
using System.Collections.Generic;
using System.Linq;

namespace FF1Lib
{
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
    public struct OWTeleportLocation
    {
        public readonly OverworldTeleportIndex TeleportIndex;
        public readonly byte CoordinateX;
        public readonly byte CoordinateY;
        public readonly string LocationName;
        public readonly EntranceTeleport PlacedTeleport;
        public string SpoilerText =>
        $"{LocationName}{string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - LocationName.Length)).ToList())}" +
        $"\t{PlacedTeleport.SpoilerText}";
        public OWTeleportLocation(OverworldTeleportIndex teleportIndex, byte coordinateX, byte coordinateY,
                                  EntranceTeleport placedLocation)
        {
            TeleportIndex = teleportIndex;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            PlacedTeleport = placedLocation;
			LocationName = Enum.GetName(typeof(OverworldTeleportIndex), TeleportIndex);
        }
        public OWTeleportLocation(OWTeleportLocation copyFromTeleportLocation,
                                  EntranceTeleport newPlacement)
        {
            TeleportIndex = copyFromTeleportLocation.TeleportIndex;
            CoordinateX = copyFromTeleportLocation.CoordinateX;
            CoordinateY = copyFromTeleportLocation.CoordinateY;
            PlacedTeleport = newPlacement;
			LocationName = Enum.GetName(typeof(OverworldTeleportIndex), TeleportIndex);
        }
    }
	public static class TeleportLocations
	{
		public static MapChange GetAccessRequirement(OverworldTeleportIndex owti) 
			=> owti == OverworldTeleportIndex.MirageTower1 ? MapChange.Chime : MapChange.None;
		public static AccessRequirement GetAccessRequirement(Teleporter t) 
			=> t == Teleporter.SeaShrine1 ? AccessRequirement.Oxyale : 
				t == Teleporter.TempleOfFiends1 ? AccessRequirement.BlackOrb : 
				t == Teleporter.EarthCave3 ? AccessRequirement.Rod : 
				t == Teleporter.SkyPalace1 ? AccessRequirement.Cube : 
				AccessRequirement.None;
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

		public static List<Teleport> FloorTeleports =>
			new List<Teleport>
			{
				new Teleport(MapIndex.ConeriaTown, new Coordinate(16, 23)),
				new Teleport(MapIndex.Pravoka, new Coordinate(19, 32)),
				new Teleport(MapIndex.Elfland, new Coordinate(41, 22)),
				new Teleport(MapIndex.Melmond, new Coordinate(1, 16)),
				new Teleport(MapIndex.CrescentLake, new Coordinate(11, 23)),
				new Teleport(MapIndex.Gaia, new Coordinate(61, 61)),
				new Teleport(MapIndex.Onrac, new Coordinate(1, 12)),
				new Teleport(MapIndex.Lefein, new Coordinate(19, 23)),
				new Teleport(MapIndex.ConeriaCastle1F, new Coordinate(12, 35)), // has exit teleport
				new Teleport(MapIndex.ElflandCastle, new Coordinate(16, 31)),
				new Teleport(MapIndex.NorthwestCastle, new Coordinate(22, 24)),
				new Teleport(MapIndex.CastleOrdeals1F, new Coordinate(12, 21)), // has exit teleport
				new Teleport(MapIndex.TemploOfFiends, new Coordinate(20, 30)), // has black orb block
				new Teleport(MapIndex.DwarfCave, new Coordinate(22, 11)),
				new Teleport(MapIndex.MatoyasCave, new Coordinate(15, 11)),
				new Teleport(MapIndex.SardasCave, new Coordinate(18, 13)),
				new Teleport(MapIndex.Cardia, new Coordinate(30, 18)),
				new Teleport(MapIndex.Cardia, new Coordinate(12, 15)),
				new Teleport(MapIndex.BahamutCaveB1, new Coordinate(2, 2)),
				new Teleport(MapIndex.BahamutCaveB2, new Coordinate(23, 45)),
				new Teleport(MapIndex.Cardia, new Coordinate(19, 36)),
				new Teleport(MapIndex.Cardia, new Coordinate(43, 29)),
				new Teleport(MapIndex.Cardia, new Coordinate(58, 55)),
				new Teleport(MapIndex.IceCaveB1, new Coordinate(7, 1)),
				new Teleport(MapIndex.IceCaveB2, new Coordinate(30, 2)),
				new Teleport(MapIndex.IceCaveB3, new Coordinate(3, 2)),
				new Teleport(MapIndex.IceCaveB2, new Coordinate(55, 5)), // has exit teleport
				new Teleport(MapIndex.Waterfall, new Coordinate(57, 56)),
				new Teleport(MapIndex.TitansTunnel, new Coordinate(11, 14)), // has exit teleport
				new Teleport(MapIndex.TitansTunnel, new Coordinate(5, 3)), // has exit teleport
				new Teleport(MapIndex.EarthCaveB1, new Coordinate(23, 24)),
				new Teleport(MapIndex.EarthCaveB2, new Coordinate(10, 9)),
				new Teleport(MapIndex.EarthCaveB3, new Coordinate(27, 45)), // has rod block
				new Teleport(MapIndex.EarthCaveB4, new Coordinate(61, 33)),
				new Teleport(MapIndex.EarthCaveB5, new Coordinate(25, 53)), // has exit teleport
				new Teleport(MapIndex.GurguVolcanoB1, new Coordinate(27, 15)),
				new Teleport(MapIndex.GurguVolcanoB2, new Coordinate(30, 32)),
				new Teleport(MapIndex.GurguVolcanoB3, new Coordinate(18, 2)),
				new Teleport(MapIndex.GurguVolcanoB4, new Coordinate(3, 23)),
				new Teleport(MapIndex.GurguVolcanoB3, new Coordinate(46, 23)),
				new Teleport(MapIndex.GurguVolcanoB4, new Coordinate(35, 6)),
				new Teleport(MapIndex.GurguVolcanoB5, new Coordinate(32, 31)), // has exit teleport
				new Teleport(MapIndex.MarshCaveB1, new Coordinate(21, 27)), // forked
				new Teleport(MapIndex.MarshCaveB2, new Coordinate(18, 16)),
				new Teleport(MapIndex.MarshCaveB3, new Coordinate(5, 6)),
				new Teleport(MapIndex.MirageTower1F, new Coordinate(17, 31)),
				new Teleport(MapIndex.MirageTower2F, new Coordinate(16, 31)),
				new Teleport(MapIndex.MirageTower3F, new Coordinate(8, 1)), // has cube block
				new Teleport(MapIndex.SeaShrineB1, new Coordinate(12, 26)), // mermaids (non-combat)
				new Teleport(MapIndex.SeaShrineB2, new Coordinate(45, 8)),
				new Teleport(MapIndex.SeaShrineB3, new Coordinate(21, 31)), // forked
				new Teleport(MapIndex.SeaShrineB4, new Coordinate(61, 49)),
				new Teleport(MapIndex.SeaShrineB3, new Coordinate(47, 39)),
				new Teleport(MapIndex.SeaShrineB2, new Coordinate(54, 41)),
				new Teleport(MapIndex.SeaShrineB3, new Coordinate(48, 10)),
				new Teleport(MapIndex.SeaShrineB4, new Coordinate(45, 20)),
				new Teleport(MapIndex.SeaShrineB5, new Coordinate(50, 48)), // has exit teleport
				new Teleport(MapIndex.SkyPalace2F, new Coordinate(19, 4)),
				new Teleport(MapIndex.SkyPalace3F, new Coordinate(24, 23)),
				new Teleport(MapIndex.SkyPalace4F, new Coordinate(3, 3)),
				new Teleport(MapIndex.SkyPalace5F, new Coordinate(7, 54)), // has exit teleport
			};
		public static OWTeleportLocation Cardia1 = new OWTeleportLocation(OverworldTeleportIndex.Cardia1, 92, 48, EntranceTeleports.Cardia1);
		public static OWTeleportLocation ConeriaTown = new OWTeleportLocation(OverworldTeleportIndex.Coneria, 152, 162,  EntranceTeleports.ConeriaTown);
		public static OWTeleportLocation Pravoka = new OWTeleportLocation(OverworldTeleportIndex.Pravoka, 210, 150, EntranceTeleports.Pravoka);
		public static OWTeleportLocation ElflandTown = new OWTeleportLocation(OverworldTeleportIndex.Elfland, 136, 222, EntranceTeleports.ElflandTown);
		public static OWTeleportLocation Melmond = new OWTeleportLocation(OverworldTeleportIndex.Melmond, 81, 160, EntranceTeleports.Melmond);
		public static OWTeleportLocation CresentLake = new OWTeleportLocation(OverworldTeleportIndex.CresentLake, 219, 218, EntranceTeleports.CresentLake);
		public static OWTeleportLocation Gaia = new OWTeleportLocation(OverworldTeleportIndex.Gaia, 221, 28, EntranceTeleports.Gaia);
		public static OWTeleportLocation Onrac = new OWTeleportLocation(OverworldTeleportIndex.Onrac, 62, 56, EntranceTeleports.Onrac);
		public static OWTeleportLocation Lefein = new OWTeleportLocation(OverworldTeleportIndex.Lefein, 235, 99, EntranceTeleports.Lefein);
		public static OWTeleportLocation ConeriaCastle = new OWTeleportLocation(OverworldTeleportIndex.ConeriaCastle1, 153, 159, EntranceTeleports.ConeriaCastle);
		public static OWTeleportLocation ElflandCastle = new OWTeleportLocation(OverworldTeleportIndex.ElflandCastle, 136, 221, EntranceTeleports.ElflandCastle);
		public static OWTeleportLocation NorthwestCastle = new OWTeleportLocation(OverworldTeleportIndex.NorthwestCastle, 103, 186, EntranceTeleports.NorthwestCastle);
		public static OWTeleportLocation CastleOrdeals = new OWTeleportLocation(OverworldTeleportIndex.CastleOrdeals1, 130, 45, EntranceTeleports.CastleOrdeals);
		public static OWTeleportLocation TempleOfFiends = new OWTeleportLocation(OverworldTeleportIndex.TempleOfFiends1, 130, 123, EntranceTeleports.TempleOfFiends);
		public static OWTeleportLocation EarthCave = new OWTeleportLocation(OverworldTeleportIndex.EarthCave1, 65, 187, EntranceTeleports.EarthCave);
		public static OWTeleportLocation GurguVolcano = new OWTeleportLocation(OverworldTeleportIndex.GurguVolcano1, 188, 205, EntranceTeleports.GurguVolcano);
		public static OWTeleportLocation IceCave = new OWTeleportLocation(OverworldTeleportIndex.IceCave1, 197, 183, EntranceTeleports.IceCave);
		public static OWTeleportLocation Cardia2 = new OWTeleportLocation(OverworldTeleportIndex.Cardia2, 79, 49, EntranceTeleports.Cardia2);//(chests 9, 10, and 11)
		public static OWTeleportLocation Cardia3 = new OWTeleportLocation(OverworldTeleportIndex.BahamutCave1, 96, 51, EntranceTeleports.Cardia3);
		public static OWTeleportLocation Waterfall = new OWTeleportLocation(OverworldTeleportIndex.Waterfall, 54, 29, EntranceTeleports.Waterfall);
		public static OWTeleportLocation DwarfCave = new OWTeleportLocation(OverworldTeleportIndex.DwarfCave, 100, 155, EntranceTeleports.DwarfCave);
		public static OWTeleportLocation MatoyasCave = new OWTeleportLocation(OverworldTeleportIndex.MatoyasCave, 168, 117, EntranceTeleports.MatoyasCave);
		public static OWTeleportLocation SardasCave = new OWTeleportLocation(OverworldTeleportIndex.SardasCave, 30, 190, EntranceTeleports.SardasCave);
		public static OWTeleportLocation MarshCave = new OWTeleportLocation(OverworldTeleportIndex.MarshCave1, 102, 236, EntranceTeleports.MarshCave);
		public static OWTeleportLocation MirageTower = new OWTeleportLocation(OverworldTeleportIndex.MirageTower1, 194, 59, EntranceTeleports.MirageTower);
		public static OWTeleportLocation TitansTunnelEast = new OWTeleportLocation(OverworldTeleportIndex.TitansTunnelEast, 42, 174, EntranceTeleports.TitansTunnelA);
		public static OWTeleportLocation TitansTunnelWest = new OWTeleportLocation(OverworldTeleportIndex.TitansTunnelWest, 30, 175, EntranceTeleports.TitansTunnelB);
		public static OWTeleportLocation Cardia4 = new OWTeleportLocation(OverworldTeleportIndex.Cardia4, 93, 58, EntranceTeleports.Cardia4); // (chests 6, 7, and 8)
		public static OWTeleportLocation Cardia5 = new OWTeleportLocation(OverworldTeleportIndex.Cardia5, 105, 59, EntranceTeleports.Cardia5);
		public static OWTeleportLocation Cardia6 = new OWTeleportLocation(OverworldTeleportIndex.Cardia6, 116, 66, EntranceTeleports.Cardia6); // (chests 1, 2, 3, 4, 5, 12, and 13)
		public static OWTeleportLocation Unused1 = new OWTeleportLocation(OverworldTeleportIndex.Unused1, 0, 0, EntranceTeleports.Empty);
		public static OWTeleportLocation Unused2 = new OWTeleportLocation(OverworldTeleportIndex.Unused2, 0, 0, EntranceTeleports.Empty);
		public static IReadOnlyCollection<OWTeleportLocation> AllTownLocations =
			new List<OWTeleportLocation>
			{
			ConeriaTown,Pravoka,ElflandTown,Melmond,CresentLake,Gaia,Onrac,Lefein
		};
		public static IReadOnlyCollection<OWTeleportLocation> AllNonTownLocations =
			new List<OWTeleportLocation>
			{
			Cardia1,ConeriaCastle,ElflandCastle,NorthwestCastle,CastleOrdeals,
			TempleOfFiends,EarthCave,GurguVolcano,IceCave,Cardia2,Cardia3,
			Waterfall,DwarfCave,MatoyasCave,SardasCave,MarshCave,MirageTower,
			TitansTunnelEast,TitansTunnelWest,Cardia4,Cardia5,Cardia6,Unused1,Unused2
		};
		public static IReadOnlyCollection<OWTeleportLocation> AllLocations =
			new List<OWTeleportLocation>
			{
			Cardia1,ConeriaTown,Pravoka,ElflandTown,Melmond,CresentLake,Gaia,
			Onrac,Lefein,ConeriaCastle,ElflandCastle,NorthwestCastle,CastleOrdeals,
			TempleOfFiends,EarthCave,GurguVolcano,IceCave,Cardia2,Cardia3,
			Waterfall,DwarfCave,MatoyasCave,SardasCave,MarshCave,MirageTower,
			TitansTunnelEast,TitansTunnelWest,Cardia4,Cardia5,Cardia6,Unused1,Unused2
		};
		public static IReadOnlyCollection<OWTeleportLocation> UnusedLocations =
			 new List<OWTeleportLocation>
			 {
			Unused1,Unused2
		};
	}
	public enum OverworldTeleportIndex : byte
	{
		Cardia1 = 0,
		Coneria = 1,
		Pravoka = 2,
		Elfland = 3,
		Melmond = 4,
		CresentLake = 5,
		Gaia = 6,
		Onrac = 7,
		Lefein = 8,
		ConeriaCastle1 = 9,
		ElflandCastle = 10,
		NorthwestCastle = 11,
		CastleOrdeals1 = 12,
		TempleOfFiends1 = 13,
		EarthCave1 = 14,
		GurguVolcano1 = 15,
		IceCave1 = 16,
		Cardia2 = 17,
		BahamutCave1 = 18,
		Waterfall = 19,
		DwarfCave = 20,
		MatoyasCave = 21,
		SardasCave = 22,
		MarshCave1 = 23,
		MirageTower1 = 24,
		TitansTunnelEast = 25,
		TitansTunnelWest = 26,
		Cardia4 = 27,
		Cardia5 = 28,
		Cardia6 = 29,
		Unused1 = 30,
		Unused2 = 31
	}
}
