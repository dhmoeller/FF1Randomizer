using System.Collections.Generic;

namespace FF1Lib
{
    public static class TeleportLocations
    {
        public static OWTeleportLocation Cardia1 = new OWTeleportLocation(OverworldTeleportIndex.Cardia1, 92, 48, EntranceTeleports.Cardia1);
        public static OWTeleportLocation ConeriaTown = new OWTeleportLocation(OverworldTeleportIndex.ConeriaTown, 152, 162,  EntranceTeleports.ConeriaTown);
        public static OWTeleportLocation Pravoka = new OWTeleportLocation(OverworldTeleportIndex.Pravoka, 210, 150, EntranceTeleports.Pravoka);
        public static OWTeleportLocation ElflandTown = new OWTeleportLocation(OverworldTeleportIndex.ElflandTown, 136, 222, EntranceTeleports.ElflandTown);
        public static OWTeleportLocation Melmond = new OWTeleportLocation(OverworldTeleportIndex.Melmond, 81, 160, EntranceTeleports.Melmond);
        public static OWTeleportLocation CresentLake = new OWTeleportLocation(OverworldTeleportIndex.CresentLake, 219, 218, EntranceTeleports.CresentLake);
        public static OWTeleportLocation Gaia = new OWTeleportLocation(OverworldTeleportIndex.Gaia, 221, 28, EntranceTeleports.Gaia);
        public static OWTeleportLocation Onrac = new OWTeleportLocation(OverworldTeleportIndex.Onrac, 62, 56, EntranceTeleports.Onrac);
        public static OWTeleportLocation Lefein = new OWTeleportLocation(OverworldTeleportIndex.Lefein, 235, 99, EntranceTeleports.Lefein);
        public static OWTeleportLocation ConeriaCastle = new OWTeleportLocation(OverworldTeleportIndex.ConeriaCastle, 153, 159, EntranceTeleports.ConeriaCastle);
        public static OWTeleportLocation ElflandCastle = new OWTeleportLocation(OverworldTeleportIndex.ElflandCastle, 136, 221, EntranceTeleports.ElflandCastle);
        public static OWTeleportLocation NorthwestCastle = new OWTeleportLocation(OverworldTeleportIndex.NorthwestCastle, 103, 186, EntranceTeleports.NorthwestCastle);
        public static OWTeleportLocation CastleOrdeals = new OWTeleportLocation(OverworldTeleportIndex.CastleOrdeals, 130, 45, EntranceTeleports.CastleOrdeals);
        public static OWTeleportLocation TempleOfFiends = new OWTeleportLocation(OverworldTeleportIndex.TempleOfFiends, 130, 123, EntranceTeleports.TempleOfFiends);
        public static OWTeleportLocation EarthCave = new OWTeleportLocation(OverworldTeleportIndex.EarthCave, 65, 187, EntranceTeleports.EarthCave);
        public static OWTeleportLocation GurguVolcano = new OWTeleportLocation(OverworldTeleportIndex.GurguVolcano, 188, 205, EntranceTeleports.GurguVolcano);
        public static OWTeleportLocation IceCave = new OWTeleportLocation(OverworldTeleportIndex.IceCave, 197, 183, EntranceTeleports.IceCave);
        public static OWTeleportLocation Cardia2 = new OWTeleportLocation(OverworldTeleportIndex.Cardia2, 79, 49, EntranceTeleports.Cardia2);//(chests 9, 10, and 11)
        public static OWTeleportLocation Cardia3 = new OWTeleportLocation(OverworldTeleportIndex.Cardia3, 96, 51, EntranceTeleports.Cardia3);
        public static OWTeleportLocation Waterfall = new OWTeleportLocation(OverworldTeleportIndex.Waterfall, 54, 29, EntranceTeleports.Waterfall);
        public static OWTeleportLocation DwarfCave = new OWTeleportLocation(OverworldTeleportIndex.DwarfCave, 100, 155, EntranceTeleports.DwarfCave);
        public static OWTeleportLocation MatoyasCave = new OWTeleportLocation(OverworldTeleportIndex.MatoyasCave, 168, 117, EntranceTeleports.MatoyasCave);
        public static OWTeleportLocation SardasCave = new OWTeleportLocation(OverworldTeleportIndex.SardasCave, 30, 190, EntranceTeleports.SardasCave);
        public static OWTeleportLocation MarshCave = new OWTeleportLocation(OverworldTeleportIndex.MarshCave, 102, 236, EntranceTeleports.MarshCave);
        public static OWTeleportLocation MirageTower = new OWTeleportLocation(OverworldTeleportIndex.MirageTower, 194, 59, EntranceTeleports.MirageTower);
        public static OWTeleportLocation TitansTunnelA = new OWTeleportLocation(OverworldTeleportIndex.TitansTunnelA, 42, 174, EntranceTeleports.TitansTunnelA);
        public static OWTeleportLocation TitansTunnelB = new OWTeleportLocation(OverworldTeleportIndex.TitansTunnelB, 30, 175, EntranceTeleports.TitansTunnelB);
        public static OWTeleportLocation Cardia4 = new OWTeleportLocation(OverworldTeleportIndex.Cardia4, 93, 58, EntranceTeleports.Cardia4); // (chests 6, 7, and 8)
        public static OWTeleportLocation Cardia5 = new OWTeleportLocation(OverworldTeleportIndex.Cardia5, 105, 59, EntranceTeleports.Cardia5);
        public static OWTeleportLocation Cardia6 = new OWTeleportLocation(OverworldTeleportIndex.Cardia6, 116, 66, EntranceTeleports.Cardia6); // (chests 1, 2, 3, 4, 5, 12, and 13)
        public static OWTeleportLocation Unused1 = new OWTeleportLocation(OverworldTeleportIndex.Unused1, 0, 0, EntranceTeleports.Empty);
        public static OWTeleportLocation Unused2 = new OWTeleportLocation(OverworldTeleportIndex.Unused2, 0, 0, EntranceTeleports.Empty);
        public static IReadOnlyCollection<OWTeleportLocation> AllLocations =
            new List<OWTeleportLocation>
            {
            Cardia1,ConeriaTown,Pravoka,ElflandTown,Melmond,CresentLake,Gaia,
            Onrac,Lefein,ConeriaCastle,ElflandCastle,NorthwestCastle,CastleOrdeals,
            TempleOfFiends,EarthCave,GurguVolcano,IceCave,Cardia2,Cardia3,
            Waterfall,DwarfCave,MatoyasCave,SardasCave,MarshCave,MirageTower,
            TitansTunnelA,TitansTunnelB,Cardia4,Cardia5,Cardia6,Unused1,Unused2
        };
        public static IReadOnlyCollection<OWTeleportLocation> UnusedLocations =
             new List<OWTeleportLocation>
             {
            Unused1,Unused2
        };
    }
    /* Relevant Non-Teleport locations
     * StartingLocation, // (153, 165)
     * Caravan, // (29, 49)
     * BridgeLocation, // (152, 152)
     * ShipLocation, // (210, 153)
     * CanalLocation, // (102, 164)
     * AirshipLocation // (222, 238)
     */

    public static class OverworldTeleportIndex
    {
        public const byte Cardia1 = 0;
        public const byte ConeriaTown = 1;
        public const byte Pravoka = 2;
        public const byte ElflandTown = 3;
        public const byte Melmond = 4;
        public const byte CresentLake = 5;
        public const byte Gaia = 6;
        public const byte Onrac = 7;
        public const byte Lefein = 8;
        public const byte ConeriaCastle = 9;
        public const byte ElflandCastle = 10;
        public const byte NorthwestCastle = 11;
        public const byte CastleOrdeals = 12;
        public const byte TempleOfFiends = 13;
        public const byte EarthCave = 14;
        public const byte GurguVolcano = 15;
        public const byte IceCave = 16;
        public const byte Cardia2 = 17; 
        public const byte Cardia3 = 18;
        public const byte Waterfall = 19;
        public const byte DwarfCave = 20;
        public const byte MatoyasCave = 21;
        public const byte SardasCave = 22;
        public const byte MarshCave = 23;
        public const byte MirageTower = 24;
        public const byte TitansTunnelA = 25;
        public const byte TitansTunnelB = 26;
        public const byte Cardia4 = 27;
        public const byte Cardia5 = 28;
        public const byte Cardia6 = 29;
        public const byte Unused1 = 30;
        public const byte Unused2 = 31;
        public static readonly IList<string> NameByIndex =
            new List<string>
        {
            nameof(Cardia1),
            nameof(ConeriaTown),
            nameof(Pravoka),
            nameof(ElflandTown),
            nameof(Melmond),
            nameof(CresentLake),
            nameof(Gaia),
            nameof(Onrac),
            nameof(Lefein),
            nameof(ConeriaCastle),
            nameof(ElflandCastle),
            nameof(NorthwestCastle),
            nameof(CastleOrdeals),
            nameof(TempleOfFiends),
            nameof(EarthCave),
            nameof(GurguVolcano),
            nameof(IceCave),
            nameof(Cardia2),
            nameof(Cardia3),
            nameof(Waterfall),
            nameof(DwarfCave),
            nameof(MatoyasCave),
            nameof(SardasCave),
            nameof(MarshCave),
            nameof(MirageTower),
            nameof(TitansTunnelA),
            nameof(TitansTunnelB),
            nameof(Cardia4),
            nameof(Cardia5),
            nameof(Cardia6),
            nameof(Unused1),
            nameof(Unused2)
        };
    }
}
