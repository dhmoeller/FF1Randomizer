using System;
using System.Collections.Generic;
using System.Linq;

namespace FF1Lib
{
    public struct OWTeleportLocation
    {
        public readonly OverworldTeleportIndex TeleportIndex;
        public readonly byte CoordinateX;
        public readonly byte CoordinateY;
        public readonly string LocationName;
        public readonly TeleportDestination PlacedTeleport;
        public string SpoilerText =>
        $"{LocationName}{string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - LocationName.Length)).ToList())}" +
        $"\t{PlacedTeleport.SpoilerText}";
        public OWTeleportLocation(OverworldTeleportIndex teleportIndex, byte coordinateX, byte coordinateY,
                                  TeleportDestination placedLocation)
        {
            TeleportIndex = teleportIndex;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            PlacedTeleport = placedLocation;
			LocationName = Enum.GetName(typeof(OverworldTeleportIndex), TeleportIndex);
        }
        public OWTeleportLocation(OWTeleportLocation copyFromTeleportLocation,
                                  TeleportDestination newPlacement)
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
		public static OWTeleportLocation Cardia1 = new OWTeleportLocation(OverworldTeleportIndex.Cardia1, 92, 48, TeleportShuffle.Cardia1);
		public static OWTeleportLocation ConeriaTown = new OWTeleportLocation(OverworldTeleportIndex.Coneria, 152, 162,  TeleportShuffle.Coneria);
		public static OWTeleportLocation Pravoka = new OWTeleportLocation(OverworldTeleportIndex.Pravoka, 210, 150, TeleportShuffle.Pravoka);
		public static OWTeleportLocation ElflandTown = new OWTeleportLocation(OverworldTeleportIndex.Elfland, 136, 222, TeleportShuffle.Elfland);
		public static OWTeleportLocation Melmond = new OWTeleportLocation(OverworldTeleportIndex.Melmond, 81, 160, TeleportShuffle.Melmond);
		public static OWTeleportLocation CresentLake = new OWTeleportLocation(OverworldTeleportIndex.CresentLake, 219, 218, TeleportShuffle.CrescentLake);
		public static OWTeleportLocation Gaia = new OWTeleportLocation(OverworldTeleportIndex.Gaia, 221, 28, TeleportShuffle.Gaia);
		public static OWTeleportLocation Onrac = new OWTeleportLocation(OverworldTeleportIndex.Onrac, 62, 56, TeleportShuffle.Onrac);
		public static OWTeleportLocation Lefein = new OWTeleportLocation(OverworldTeleportIndex.Lefein, 235, 99, TeleportShuffle.Lefein);
		public static OWTeleportLocation ConeriaCastle = new OWTeleportLocation(OverworldTeleportIndex.ConeriaCastle1, 153, 159, TeleportShuffle.ConeriaCastle1);
		public static OWTeleportLocation ElflandCastle = new OWTeleportLocation(OverworldTeleportIndex.ElflandCastle, 136, 221, TeleportShuffle.ElflandCastle);
		public static OWTeleportLocation NorthwestCastle = new OWTeleportLocation(OverworldTeleportIndex.NorthwestCastle, 103, 186, TeleportShuffle.NorthwestCastle);
		public static OWTeleportLocation CastleOrdeals = new OWTeleportLocation(OverworldTeleportIndex.CastleOrdeals1, 130, 45, TeleportShuffle.CastleOrdeals1);
		public static OWTeleportLocation TempleOfFiends = new OWTeleportLocation(OverworldTeleportIndex.TempleOfFiends1, 130, 123, TeleportShuffle.TempleOfFiends);
		public static OWTeleportLocation EarthCave = new OWTeleportLocation(OverworldTeleportIndex.EarthCave1, 65, 187, TeleportShuffle.EarthCave1);
		public static OWTeleportLocation GurguVolcano = new OWTeleportLocation(OverworldTeleportIndex.GurguVolcano1, 188, 205, TeleportShuffle.GurguVolcano1);
		public static OWTeleportLocation IceCave = new OWTeleportLocation(OverworldTeleportIndex.IceCave1, 197, 183, TeleportShuffle.IceCave1);
		public static OWTeleportLocation Cardia2 = new OWTeleportLocation(OverworldTeleportIndex.Cardia2, 79, 49, TeleportShuffle.Cardia2);//(chests 9, 10, and 11)
		public static OWTeleportLocation Cardia3 = new OWTeleportLocation(OverworldTeleportIndex.BahamutCave1, 96, 51, TeleportShuffle.BahamutCaveB1);
		public static OWTeleportLocation Waterfall = new OWTeleportLocation(OverworldTeleportIndex.Waterfall, 54, 29, TeleportShuffle.Waterfall);
		public static OWTeleportLocation DwarfCave = new OWTeleportLocation(OverworldTeleportIndex.DwarfCave, 100, 155, TeleportShuffle.DwarfCave);
		public static OWTeleportLocation MatoyasCave = new OWTeleportLocation(OverworldTeleportIndex.MatoyasCave, 168, 117, TeleportShuffle.MatoyasCave);
		public static OWTeleportLocation SardasCave = new OWTeleportLocation(OverworldTeleportIndex.SardasCave, 30, 190, TeleportShuffle.SardasCave);
		public static OWTeleportLocation MarshCave = new OWTeleportLocation(OverworldTeleportIndex.MarshCave1, 102, 236, TeleportShuffle.MarshCave1);
		public static OWTeleportLocation MirageTower = new OWTeleportLocation(OverworldTeleportIndex.MirageTower1, 194, 59, TeleportShuffle.MirageTower1);
		public static OWTeleportLocation TitansTunnelEast = new OWTeleportLocation(OverworldTeleportIndex.TitansTunnelEast, 42, 174, TeleportShuffle.TitansTunnelEast);
		public static OWTeleportLocation TitansTunnelWest = new OWTeleportLocation(OverworldTeleportIndex.TitansTunnelWest, 30, 175, TeleportShuffle.TitansTunnelWest);
		public static OWTeleportLocation Cardia4 = new OWTeleportLocation(OverworldTeleportIndex.Cardia4, 93, 58, TeleportShuffle.Cardia4); // (chests 6, 7, and 8)
		public static OWTeleportLocation Cardia5 = new OWTeleportLocation(OverworldTeleportIndex.Cardia5, 105, 59, TeleportShuffle.Cardia5);
		public static OWTeleportLocation Cardia6 = new OWTeleportLocation(OverworldTeleportIndex.Cardia6, 116, 66, TeleportShuffle.Cardia6); // (chests 1, 2, 3, 4, 5, 12, and 13)
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
			TitansTunnelEast,TitansTunnelWest,Cardia4,Cardia5,Cardia6
		};
		public static IReadOnlyCollection<OWTeleportLocation> AllLocations =
			new List<OWTeleportLocation>
			{
			Cardia1,ConeriaTown,Pravoka,ElflandTown,Melmond,CresentLake,Gaia,
			Onrac,Lefein,ConeriaCastle,ElflandCastle,NorthwestCastle,CastleOrdeals,
			TempleOfFiends,EarthCave,GurguVolcano,IceCave,Cardia2,Cardia3,
			Waterfall,DwarfCave,MatoyasCave,SardasCave,MarshCave,MirageTower,
			TitansTunnelEast,TitansTunnelWest,Cardia4,Cardia5,Cardia6
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
