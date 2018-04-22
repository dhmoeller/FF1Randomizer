﻿
using System.Collections.Generic;

namespace FF1Lib
{
	public static partial class ItemLocations
	{
		public static TreasureChest Coneria1 = new TreasureChest(0x3101, nameof(Coneria1), MapLocation.ConeriaCastle1, Item.IronArmor, AccessRequirement.Key);
		public static TreasureChest Coneria2 = new TreasureChest(0x3102, nameof(Coneria2), MapLocation.ConeriaCastle1, Item.IronShield, AccessRequirement.Key);
		public static TreasureChest ConeriaMajor = new TreasureChest(0x3103, nameof(ConeriaMajor), MapLocation.ConeriaCastle1, Item.Tnt, AccessRequirement.Key);
		public static TreasureChest Coneria4 = new TreasureChest(0x3104, nameof(Coneria4), MapLocation.ConeriaCastle1, Item.IronSword, AccessRequirement.Key);
		public static TreasureChest Coneria5 = new TreasureChest(0x3105, nameof(Coneria5), MapLocation.ConeriaCastle1, Item.Sabre, AccessRequirement.Key);
		public static TreasureChest Coneria6 = new TreasureChest(0x3106, nameof(Coneria6), MapLocation.ConeriaCastle1, Item.SilverKnife, AccessRequirement.Key);
		public static TreasureChest ToFTopLeft1 = new TreasureChest(0x3107, nameof(ToFTopLeft1), MapLocation.TempleOfFiends1, Item.Cabin);
		public static TreasureChest ToFTopLeft2 = new TreasureChest(0x3108, nameof(ToFTopLeft2), MapLocation.TempleOfFiends1, Item.Heal);
		public static TreasureChest ToFBottomLeft = new TreasureChest(0x3109, nameof(ToFBottomLeft), MapLocation.TempleOfFiends1, Item.Cap);
		public static TreasureChest ToFBottomRight = new TreasureChest(0x310A, nameof(ToFBottomRight), MapLocation.TempleOfFiends1, Item.RuneSword, AccessRequirement.Key);
		public static TreasureChest ToFTopRight1 = new TreasureChest(0x310B, nameof(ToFTopRight1), MapLocation.TempleOfFiends1, Item.WereSword, AccessRequirement.Key);
		public static TreasureChest ToFTopRight2 = new TreasureChest(0x310C, nameof(ToFTopRight2), MapLocation.TempleOfFiends1, Item.Soft, AccessRequirement.Key);
		public static TreasureChest Elfland1 = new TreasureChest(0x310D, nameof(Elfland1), MapLocation.ElflandCastle, Item.SilverHammer, AccessRequirement.Key);
		public static TreasureChest Elfland2 = new TreasureChest(0x310E, nameof(Elfland2), MapLocation.ElflandCastle, Item.Gold400, AccessRequirement.Key);
		public static TreasureChest Elfland3 = new TreasureChest(0x310F, nameof(Elfland3), MapLocation.ElflandCastle, Item.Gold330, AccessRequirement.Key);
		public static TreasureChest Elfland4 = new TreasureChest(0x3110, nameof(Elfland4), MapLocation.ElflandCastle, Item.CopperGauntlets, AccessRequirement.Key);
		public static TreasureChest NorthwestCastle1 = new TreasureChest(0x3111, nameof(NorthwestCastle1), MapLocation.NorthwestCastle, Item.PowerRod, AccessRequirement.Key);
		public static TreasureChest NorthwestCastle2 = new TreasureChest(0x3112, nameof(NorthwestCastle2), MapLocation.NorthwestCastle, Item.IronGauntlets, AccessRequirement.Key);
		public static TreasureChest NorthwestCastle3 = new TreasureChest(0x3113, nameof(NorthwestCastle3), MapLocation.NorthwestCastle, Item.Falchon, AccessRequirement.Key);
		// Marsh Cave has 5 extra empty treasure chests
		public static TreasureChest MarshCave1 = new TreasureChest(0x3114, nameof(MarshCave1), MapLocation.MarshCaveBottom, Item.Gold295);
		public static TreasureChest MarshCave2 = new TreasureChest(0x3115, nameof(MarshCave2), MapLocation.MarshCaveBottom, Item.Copper);
		public static TreasureChest MarshCave3 = new TreasureChest(0x3116, nameof(MarshCave3), MapLocation.MarshCaveBottom, Item.House);
		public static TreasureChest MarshCave4 = new TreasureChest(0x3117, nameof(MarshCave4), MapLocation.MarshCaveBottom, Item.Gold385);
		public static TreasureChest MarshCave5 = new TreasureChest(0x3118, nameof(MarshCave5), MapLocation.MarshCave2, Item.Gold620);
		public static TreasureChest MarshCave6 = new TreasureChest(0x3119, nameof(MarshCave6), MapLocation.MarshCave2, Item.ShortSword);
		public static TreasureChest MarshCave7 = new TreasureChest(0x311A, nameof(MarshCave7), MapLocation.MarshCave2, Item.Gold680);
		public static TreasureChest MarshCave8 = new TreasureChest(0x311B, nameof(MarshCave8), MapLocation.MarshCave2, Item.LargeKnife);
		public static TreasureChest MarshCaveMajor = new TreasureChest(0x311C, nameof(MarshCaveMajor), MapLocation.MarshCaveBottom, Item.Crown);
		public static TreasureChest MarshCave10 = new TreasureChest(0x311D, nameof(MarshCave10), MapLocation.MarshCaveBottom, Item.IronArmor);
		public static TreasureChest MarshCave11 = new TreasureChest(0x311E, nameof(MarshCave11), MapLocation.MarshCaveBottom, Item.Silver, AccessRequirement.Key);
		public static TreasureChest MarshCave12 = new TreasureChest(0x311F, nameof(MarshCave12), MapLocation.MarshCaveBottom, Item.SilverKnife, AccessRequirement.Key);
		public static TreasureChest MarshCave13 = new TreasureChest(0x3120, nameof(MarshCave13), MapLocation.MarshCaveBottom, Item.Gold1020, AccessRequirement.Key);
		public static TreasureChest DwarfCave1 = new TreasureChest(0x3121, nameof(DwarfCave1), MapLocation.DwarfCave, Item.Gold450);
		public static TreasureChest DwarfCave2 = new TreasureChest(0x3122, nameof(DwarfCave2), MapLocation.DwarfCave, Item.Gold575);
		public static TreasureChest DwarfCave3 = new TreasureChest(0x3123, nameof(DwarfCave3), MapLocation.DwarfCave, Item.Cabin, AccessRequirement.Key);
		public static TreasureChest DwarfCave4 = new TreasureChest(0x3124, nameof(DwarfCave4), MapLocation.DwarfCave, Item.IronHelm, AccessRequirement.Key);
		public static TreasureChest DwarfCave5 = new TreasureChest(0x3125, nameof(DwarfCave5), MapLocation.DwarfCave, Item.WoodenHelm, AccessRequirement.Key);
		public static TreasureChest DwarfCave6 = new TreasureChest(0x3126, nameof(DwarfCave6), MapLocation.DwarfCave, Item.DragonSword, AccessRequirement.Key);
		public static TreasureChest DwarfCave7 = new TreasureChest(0x3127, nameof(DwarfCave7), MapLocation.DwarfCave, Item.SilverKnife, AccessRequirement.Key);
		public static TreasureChest DwarfCave8 = new TreasureChest(0x3128, nameof(DwarfCave8), MapLocation.DwarfCave, Item.SilverArmor, AccessRequirement.Key);
		public static TreasureChest DwarfCave9 = new TreasureChest(0x3129, nameof(DwarfCave9), MapLocation.DwarfCave, Item.Gold575, AccessRequirement.Key);
		public static TreasureChest DwarfCave10 = new TreasureChest(0x312A, nameof(DwarfCave10), MapLocation.DwarfCave, Item.House, AccessRequirement.Key);
		public static TreasureChest MatoyasCave1 = new TreasureChest(0x312B, nameof(MatoyasCave1), MapLocation.MatoyasCave, Item.Heal);
		public static TreasureChest MatoyasCave2 = new TreasureChest(0x312C, nameof(MatoyasCave2), MapLocation.MatoyasCave, Item.Pure);
		public static TreasureChest MatoyasCave3 = new TreasureChest(0x312D, nameof(MatoyasCave3), MapLocation.MatoyasCave, Item.Heal);
		public static TreasureChest EarthCave1 = new TreasureChest(0x312E, nameof(EarthCave1), MapLocation.EarthCave1, Item.Gold880);
		public static TreasureChest EarthCave2 = new TreasureChest(0x312F, nameof(EarthCave2), MapLocation.EarthCave1, Item.Heal);
		public static TreasureChest EarthCave3 = new TreasureChest(0x3130, nameof(EarthCave3), MapLocation.EarthCave1, Item.Pure);
		public static TreasureChest EarthCave4 = new TreasureChest(0x3131, nameof(EarthCave4), MapLocation.EarthCave1, Item.Gold795);
		public static TreasureChest EarthCave5 = new TreasureChest(0x3132, nameof(EarthCave5), MapLocation.EarthCave1, Item.Gold1975);
		public static TreasureChest EarthCave6 = new TreasureChest(0x3133, nameof(EarthCave6), MapLocation.EarthCave2, Item.CoralSword);
		public static TreasureChest EarthCave7 = new TreasureChest(0x3134, nameof(EarthCave7), MapLocation.EarthCave2, Item.Cabin);
		public static TreasureChest EarthCave8 = new TreasureChest(0x3135, nameof(EarthCave8), MapLocation.EarthCave2, Item.Gold330);
		public static TreasureChest EarthCave9 = new TreasureChest(0x3136, nameof(EarthCave9), MapLocation.EarthCave2, Item.Gold5000);
		public static TreasureChest EarthCave10 = new TreasureChest(0x3137, nameof(EarthCave10), MapLocation.EarthCave2, Item.WoodenShield);
		public static TreasureChest EarthCave11 = new TreasureChest(0x3138, nameof(EarthCave11), MapLocation.EarthCave2, Item.Gold575);
		public static TreasureChest EarthCave12 = new TreasureChest(0x3139, nameof(EarthCave12), MapLocation.EarthCaveVampire, Item.Gold1020);
		public static TreasureChest EarthCave13 = new TreasureChest(0x313A, nameof(EarthCave13), MapLocation.EarthCaveVampire, Item.Gold3400);
		public static TreasureChest EarthCave14 = new TreasureChest(0x313B, nameof(EarthCave14), MapLocation.EarthCaveVampire, Item.Tent);
		public static TreasureChest EarthCave15 = new TreasureChest(0x313C, nameof(EarthCave15), MapLocation.EarthCaveVampire, Item.Heal);
		public static TreasureChest EarthCaveMajor = new TreasureChest(0x313D, nameof(EarthCaveMajor), MapLocation.EarthCaveVampire, Item.Ruby);
		public static TreasureChest EarthCave17 = new TreasureChest(0x313E, nameof(EarthCave17), MapLocation.EarthCave4, Item.Gold1250, AccessRequirement.Rod);
		public static TreasureChest EarthCave18 = new TreasureChest(0x313F, nameof(EarthCave18), MapLocation.EarthCave4, Item.SilverShield, AccessRequirement.Rod);
		public static TreasureChest EarthCave19 = new TreasureChest(0x3140, nameof(EarthCave19), MapLocation.EarthCave4, Item.Cabin, AccessRequirement.Rod);
		public static TreasureChest EarthCave20 = new TreasureChest(0x3141, nameof(EarthCave20), MapLocation.EarthCave4, Item.Gold5450, AccessRequirement.Rod);
		public static TreasureChest EarthCave21 = new TreasureChest(0x3142, nameof(EarthCave21), MapLocation.EarthCave4, Item.Gold1520, AccessRequirement.Rod);
		public static TreasureChest EarthCave22 = new TreasureChest(0x3143, nameof(EarthCave22), MapLocation.EarthCave4, Item.WoodenRod, AccessRequirement.Rod);
		public static TreasureChest EarthCave23 = new TreasureChest(0x3144, nameof(EarthCave23), MapLocation.EarthCave4, Item.Gold3400, AccessRequirement.Rod);
		public static TreasureChest EarthCave24 = new TreasureChest(0x3145, nameof(EarthCave24), MapLocation.EarthCave4, Item.Gold1455, AccessRequirement.Rod);
		public static TreasureChest TitansTunnel1 = new TreasureChest(0x3146, nameof(TitansTunnel1), MapLocation.TitansTunnelWest, Item.SilverHelm);
		public static TreasureChest TitansTunnel2 = new TreasureChest(0x3147, nameof(TitansTunnel2), MapLocation.TitansTunnelWest, Item.Gold450);
		public static TreasureChest TitansTunnel3 = new TreasureChest(0x3148, nameof(TitansTunnel3), MapLocation.TitansTunnelWest, Item.Gold620);
		public static TreasureChest TitansTunnel4 = new TreasureChest(0x3149, nameof(TitansTunnel4), MapLocation.TitansTunnelWest, Item.GreatAxe);
		// Volcano has 3 extra empty treasure chests
		public static TreasureChest Volcano1 = new TreasureChest(0x314A, nameof(Volcano1), MapLocation.GurguVolcano2, Item.Heal);
		public static TreasureChest Volcano2 = new TreasureChest(0x314B, nameof(Volcano2), MapLocation.GurguVolcano2, Item.Cabin);
		public static TreasureChest Volcano3 = new TreasureChest(0x314C, nameof(Volcano3), MapLocation.GurguVolcano2, Item.Gold1975);
		public static TreasureChest Volcano4 = new TreasureChest(0x314D, nameof(Volcano4), MapLocation.GurguVolcano2, Item.Pure);
		public static TreasureChest Volcano5 = new TreasureChest(0x314E, nameof(Volcano5), MapLocation.GurguVolcano2, Item.Heal);
		public static TreasureChest Volcano6 = new TreasureChest(0x314F, nameof(Volcano6), MapLocation.GurguVolcano2, Item.Gold1455);
		public static TreasureChest Volcano7 = new TreasureChest(0x3150, nameof(Volcano7), MapLocation.GurguVolcano2, Item.SilverShield);
		public static TreasureChest Volcano8 = new TreasureChest(0x3151, nameof(Volcano8), MapLocation.GurguVolcano2, Item.Gold1520);
		public static TreasureChest Volcano9 = new TreasureChest(0x3152, nameof(Volcano9), MapLocation.GurguVolcano2, Item.SilverHelm);
		public static TreasureChest Volcano10 = new TreasureChest(0x3153, nameof(Volcano10), MapLocation.GurguVolcano2, Item.SilverGauntlets);
		public static TreasureChest Volcano11 = new TreasureChest(0x3154, nameof(Volcano11), MapLocation.GurguVolcano2, Item.Gold1760);
		public static TreasureChest Volcano12 = new TreasureChest(0x3155, nameof(Volcano12), MapLocation.GurguVolcano2, Item.SilverAxe);
		public static TreasureChest Volcano13 = new TreasureChest(0x3156, nameof(Volcano13), MapLocation.GurguVolcano2, Item.Gold795);
		public static TreasureChest Volcano14 = new TreasureChest(0x3157, nameof(Volcano14), MapLocation.GurguVolcano2, Item.Gold750);
		public static TreasureChest Volcano15 = new TreasureChest(0x3158, nameof(Volcano15), MapLocation.GurguVolcano2, Item.GiantSword);
		public static TreasureChest Volcano16 = new TreasureChest(0x3159, nameof(Volcano16), MapLocation.GurguVolcano2, Item.Gold4150);
		public static TreasureChest Volcano17 = new TreasureChest(0x315A, nameof(Volcano17), MapLocation.GurguVolcano2, Item.Gold1520);
		public static TreasureChest Volcano18 = new TreasureChest(0x315B, nameof(Volcano18), MapLocation.GurguVolcano2, Item.SilverHelm);
		public static TreasureChest Volcano19 = new TreasureChest(0x315C, nameof(Volcano19), MapLocation.GurguVolcano6, Item.Soft);
		public static TreasureChest Volcano20 = new TreasureChest(0x315D, nameof(Volcano20), MapLocation.GurguVolcano6, Item.Gold2750);
		public static TreasureChest Volcano21 = new TreasureChest(0x315E, nameof(Volcano21), MapLocation.GurguVolcano6, Item.Gold1760);
		public static TreasureChest Volcano22 = new TreasureChest(0x315F, nameof(Volcano22), MapLocation.GurguVolcano6, Item.WoodenRod);
		public static TreasureChest Volcano23 = new TreasureChest(0x3160, nameof(Volcano23), MapLocation.GurguVolcano6, Item.Gold1250);
		public static TreasureChest Volcano24 = new TreasureChest(0x3161, nameof(Volcano24), MapLocation.GurguVolcano6, Item.Gold10);
		public static TreasureChest Volcano25 = new TreasureChest(0x3162, nameof(Volcano25), MapLocation.GurguVolcano6, Item.Gold155);
		public static TreasureChest Volcano26 = new TreasureChest(0x3163, nameof(Volcano26), MapLocation.GurguVolcano6, Item.House);
		public static TreasureChest Volcano27 = new TreasureChest(0x3164, nameof(Volcano27), MapLocation.GurguVolcano6, Item.Gold2000);
		public static TreasureChest Volcano28 = new TreasureChest(0x3165, nameof(Volcano28), MapLocation.GurguVolcano6, Item.IceSword);
		public static TreasureChest Volcano29 = new TreasureChest(0x3166, nameof(Volcano29), MapLocation.GurguVolcano6, Item.Gold880);
		public static TreasureChest Volcano30 = new TreasureChest(0x3167, nameof(Volcano30), MapLocation.GurguVolcano6, Item.Pure);
		public static TreasureChest Volcano31 = new TreasureChest(0x3168, nameof(Volcano31), MapLocation.GurguVolcano6, Item.FlameShield);
		public static TreasureChest Volcano32 = new TreasureChest(0x3169, nameof(Volcano32), MapLocation.GurguVolcano6, Item.Gold7340);
		public static TreasureChest VolcanoMajor = new TreasureChest(0x316A, nameof(VolcanoMajor), MapLocation.GurguVolcanoKary, Item.FlameArmor);
		public static TreasureChest IceCave1 = new TreasureChest(0x316B, nameof(IceCave1), MapLocation.IceCaveBackExit, Item.Heal);
		public static TreasureChest IceCave2 = new TreasureChest(0x316C, nameof(IceCave2), MapLocation.IceCaveBackExit, Item.Gold10000);
		public static TreasureChest IceCave3 = new TreasureChest(0x316D, nameof(IceCave3), MapLocation.IceCaveBackExit, Item.Gold9500);
		public static TreasureChest IceCave4 = new TreasureChest(0x316E, nameof(IceCave4), MapLocation.IceCaveBackExit, Item.Tent);
		public static TreasureChest IceCave5 = new TreasureChest(0x316F, nameof(IceCave5), MapLocation.IceCaveBackExit, Item.IceShield);
		public static TreasureChest IceCave6 = new TreasureChest(0x3170, nameof(IceCave6), MapLocation.IceCavePitRoom, Item.Cloth);
		public static TreasureChest IceCave7 = new TreasureChest(0x3171, nameof(IceCave7), MapLocation.IceCavePitRoom, Item.FlameSword);
		public static TreasureChest IceCaveMajor = new TreasureChest(0x3172, nameof(IceCaveMajor), MapLocation.IceCaveFloater, Item.Floater);
		public static TreasureChest IceCave9 = new TreasureChest(0x3173, nameof(IceCave9), MapLocation.IceCave5, Item.Gold7900);
		public static TreasureChest IceCave10 = new TreasureChest(0x3174, nameof(IceCave10), MapLocation.IceCave5, Item.Gold5450);
		public static TreasureChest IceCave11 = new TreasureChest(0x3175, nameof(IceCave11), MapLocation.IceCave5, Item.Gold9900);
		public static TreasureChest IceCave12 = new TreasureChest(0x3176, nameof(IceCave12), MapLocation.IceCave5, Item.Gold5000);
		public static TreasureChest IceCave13 = new TreasureChest(0x3177, nameof(IceCave13), MapLocation.IceCave5, Item.Gold180);
		public static TreasureChest IceCave14 = new TreasureChest(0x3178, nameof(IceCave14), MapLocation.IceCave5, Item.Gold12350);
		public static TreasureChest IceCave15 = new TreasureChest(0x3179, nameof(IceCave15), MapLocation.IceCave5, Item.SilverGauntlets);
		public static TreasureChest IceCave16 = new TreasureChest(0x317A, nameof(IceCave16), MapLocation.IceCave5, Item.IceArmor);
		// Ordeals has 1 extra empty treasure chest
		public static TreasureChest Ordeals1 = new TreasureChest(0x317B, nameof(Ordeals1), MapLocation.CastleOrdealsTop, Item.ZeusGauntlets, AccessRequirement.Crown);
		public static TreasureChest Ordeals2 = new TreasureChest(0x317C, nameof(Ordeals2), MapLocation.CastleOrdealsTop, Item.House, AccessRequirement.Crown);
		public static TreasureChest Ordeals3 = new TreasureChest(0x317D, nameof(Ordeals3), MapLocation.CastleOrdealsTop, Item.Gold1455, AccessRequirement.Crown);
		public static TreasureChest Ordeals4 = new TreasureChest(0x317E, nameof(Ordeals4), MapLocation.CastleOrdealsTop, Item.Gold7340, AccessRequirement.Crown);
		public static TreasureChest Ordeals5 = new TreasureChest(0x317F, nameof(Ordeals5), MapLocation.CastleOrdealsTop, Item.Gold, AccessRequirement.Crown);
		public static TreasureChest Ordeals6 = new TreasureChest(0x3180, nameof(Ordeals6), MapLocation.CastleOrdealsTop, Item.IceSword, AccessRequirement.Crown);
		public static TreasureChest Ordeals7 = new TreasureChest(0x3181, nameof(Ordeals7), MapLocation.CastleOrdealsTop, Item.IronGauntlets, AccessRequirement.Crown);
		public static TreasureChest Ordeals8 = new TreasureChest(0x3182, nameof(Ordeals8), MapLocation.CastleOrdealsTop, Item.HealRod, AccessRequirement.Crown);
		public static TreasureChest OrdealsMajor = new TreasureChest(0x3183, nameof(OrdealsMajor), MapLocation.CastleOrdealsTop, Item.Tail, AccessRequirement.Crown);
		public static TreasureChest Cardia1 = new TreasureChest(0x3184, nameof(Cardia1), MapLocation.Cardia6, Item.Gold1455);
		public static TreasureChest Cardia2 = new TreasureChest(0x3185, nameof(Cardia2), MapLocation.Cardia6, Item.Gold2000);
		public static TreasureChest Cardia3 = new TreasureChest(0x3186, nameof(Cardia3), MapLocation.Cardia6, Item.Gold2750);
		public static TreasureChest Cardia4 = new TreasureChest(0x3187, nameof(Cardia4), MapLocation.Cardia6, Item.Gold2750);
		public static TreasureChest Cardia5 = new TreasureChest(0x3188, nameof(Cardia5), MapLocation.Cardia6, Item.Gold1520);
		public static TreasureChest Cardia6 = new TreasureChest(0x3189, nameof(Cardia6), MapLocation.Cardia4, Item.Gold10);
		public static TreasureChest Cardia7 = new TreasureChest(0x318A, nameof(Cardia7), MapLocation.Cardia4, Item.Gold500);
		public static TreasureChest Cardia8 = new TreasureChest(0x318B, nameof(Cardia8), MapLocation.Cardia4, Item.House);
		public static TreasureChest Cardia9 = new TreasureChest(0x318C, nameof(Cardia9), MapLocation.Cardia2, Item.Gold575);
		public static TreasureChest Cardia10 = new TreasureChest(0x318D, nameof(Cardia10), MapLocation.Cardia2, Item.Soft);
		public static TreasureChest Cardia11 = new TreasureChest(0x318E, nameof(Cardia11), MapLocation.Cardia2, Item.Cabin);
		public static TreasureChest Cardia12 = new TreasureChest(0x318F, nameof(Cardia12), MapLocation.Cardia6, Item.Gold9500);
		public static TreasureChest Cardia13 = new TreasureChest(0x3190, nameof(Cardia13), MapLocation.Cardia6, Item.Gold160);
		public static TreasureChest Unused2 = new TreasureChest(0x3191, nameof(Unused2), 0, Item.Gold530, isUnused: true);
		public static TreasureChest Unused3 = new TreasureChest(0x3192, nameof(Unused3), 0, Item.SmallKnife, isUnused: true);
		public static TreasureChest Unused4 = new TreasureChest(0x3193, nameof(Unused4), 0, Item.Cap, isUnused: true);
		public static TreasureChest Unused5 = new TreasureChest(0x3194, nameof(Unused5), 0, Item.ZeusGauntlets, isUnused: true);
		public static TreasureChest SeaShrine1 = new TreasureChest(0x3195, nameof(SeaShrine1), MapLocation.SeaShrine7, Item.Ribbon, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine2 = new TreasureChest(0x3196, nameof(SeaShrine2), MapLocation.SeaShrine7, Item.Gold9900, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine3 = new TreasureChest(0x3197, nameof(SeaShrine3), MapLocation.SeaShrine7, Item.Gold7340, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine4 = new TreasureChest(0x3198, nameof(SeaShrine4), MapLocation.SeaShrine7, Item.Gold2750, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine5 = new TreasureChest(0x3199, nameof(SeaShrine5), MapLocation.SeaShrine7, Item.Gold7690, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine6 = new TreasureChest(0x319A, nameof(SeaShrine6), MapLocation.SeaShrine7, Item.Gold8135, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine7 = new TreasureChest(0x319B, nameof(SeaShrine7), MapLocation.SeaShrine7, Item.Gold5450, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine8 = new TreasureChest(0x319C, nameof(SeaShrine8), MapLocation.SeaShrine7, Item.Gold385, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine9 = new TreasureChest(0x319D, nameof(SeaShrine9), MapLocation.SeaShrine7, Item.PowerGauntlets, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine10 = new TreasureChest(0x319E, nameof(SeaShrine10), MapLocation.SeaShrine7, Item.LightAxe, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine11 = new TreasureChest(0x319F, nameof(SeaShrine11), MapLocation.SeaShrine1, Item.Gold9900, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine12 = new TreasureChest(0x31A0, nameof(SeaShrine12), MapLocation.SeaShrine1, Item.Gold2000, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine13 = new TreasureChest(0x31A1, nameof(SeaShrine13), MapLocation.SeaShrine6, Item.Gold450, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine14 = new TreasureChest(0x31A2, nameof(SeaShrine14), MapLocation.SeaShrine6, Item.Gold110, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine15 = new TreasureChest(0x31A3, nameof(SeaShrine15), MapLocation.SeaShrine2, Item.LightAxe, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine16 = new TreasureChest(0x31A4, nameof(SeaShrine16), MapLocation.SeaShrine2, Item.OpalArmor, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrineLocked = new TreasureChest(0x31A5, nameof(SeaShrineLocked), MapLocation.SeaShrine2, Item.Gold20, AccessRequirement.Key | AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine18 = new TreasureChest(0x31A6, nameof(SeaShrine18), MapLocation.SeaShrine2, Item.MageRod, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine19 = new TreasureChest(0x31A7, nameof(SeaShrine19), MapLocation.SeaShrine2, Item.Gold12350, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine20 = new TreasureChest(0x31A8, nameof(SeaShrine20), MapLocation.SeaShrineMermaids, Item.Gold9000, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine21 = new TreasureChest(0x31A9, nameof(SeaShrine21), MapLocation.SeaShrineMermaids, Item.Gold1760, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine22 = new TreasureChest(0x31AA, nameof(SeaShrine22), MapLocation.SeaShrineMermaids, Item.Opal, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine23 = new TreasureChest(0x31AB, nameof(SeaShrine23), MapLocation.SeaShrineMermaids, Item.Gold2750, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine24 = new TreasureChest(0x31AC, nameof(SeaShrine24), MapLocation.SeaShrineMermaids, Item.Gold10000, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine25 = new TreasureChest(0x31AD, nameof(SeaShrine25), MapLocation.SeaShrineMermaids, Item.Gold10, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine26 = new TreasureChest(0x31AE, nameof(SeaShrine26), MapLocation.SeaShrineMermaids, Item.Gold4150, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine27 = new TreasureChest(0x31AF, nameof(SeaShrine27), MapLocation.SeaShrineMermaids, Item.Gold5000, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine28 = new TreasureChest(0x31B0, nameof(SeaShrine28), MapLocation.SeaShrineMermaids, Item.Pure, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine29 = new TreasureChest(0x31B1, nameof(SeaShrine29), MapLocation.SeaShrineMermaids, Item.OpalShield, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine30 = new TreasureChest(0x31B2, nameof(SeaShrine30), MapLocation.SeaShrineMermaids, Item.OpalHelm, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrine31 = new TreasureChest(0x31B3, nameof(SeaShrine31), MapLocation.SeaShrineMermaids, Item.OpalGauntlets, AccessRequirement.Oxyale);
		public static TreasureChest SeaShrineMajor = new TreasureChest(0x31B4, nameof(SeaShrineMajor), MapLocation.SeaShrineMermaids, Item.Slab, AccessRequirement.Oxyale);
		public static TreasureChest Waterfall1 = new TreasureChest(0x31B5, nameof(Waterfall1), MapLocation.Waterfall, Item.WizardRod);
		public static TreasureChest Waterfall2 = new TreasureChest(0x31B6, nameof(Waterfall2), MapLocation.Waterfall, Item.Ribbon);
		public static TreasureChest Waterfall3 = new TreasureChest(0x31B7, nameof(Waterfall3), MapLocation.Waterfall, Item.Gold13450);
		public static TreasureChest Waterfall4 = new TreasureChest(0x31B8, nameof(Waterfall4), MapLocation.Waterfall, Item.Gold6400);
		public static TreasureChest Waterfall5 = new TreasureChest(0x31B9, nameof(Waterfall5), MapLocation.Waterfall, Item.Gold5000);
		public static TreasureChest Waterfall6 = new TreasureChest(0x31BA, nameof(Waterfall6), MapLocation.Waterfall, Item.Defense);
		public static TreasureChest Unused6 = new TreasureChest(0x31BB, nameof(Unused6), 0, Item.Heal, isUnused: true);
		public static TreasureChest Unused7 = new TreasureChest(0x31BC, nameof(Unused7), 0, Item.Heal, isUnused: true);
		public static TreasureChest Unused8 = new TreasureChest(0x31BD, nameof(Unused8), 0, Item.Heal, isUnused: true);
		public static TreasureChest Unused9 = new TreasureChest(0x31BE, nameof(Unused9), 0, Item.Heal, isUnused: true);
		public static TreasureChest Unused10 = new TreasureChest(0x31BF, nameof(Unused10), 0, Item.Heal, isUnused: true);
		public static TreasureChest Unused11 = new TreasureChest(0x31C0, nameof(Unused11), 0, Item.Heal, isUnused: true);
		public static TreasureChest Unused12 = new TreasureChest(0x31C1, nameof(Unused12), 0, Item.Heal, isUnused: true);
		public static TreasureChest Unused13 = new TreasureChest(0x31C2, nameof(Unused13), 0, Item.Heal, isUnused: true);
		public static TreasureChest Unused14 = new TreasureChest(0x31C3, nameof(Unused14), 0, Item.Heal, isUnused: true);
		public static TreasureChest MirageTower1 = new TreasureChest(0x31C4, nameof(MirageTower1), MapLocation.MirageTower1, Item.AegisShield);
		public static TreasureChest MirageTower2 = new TreasureChest(0x31C5, nameof(MirageTower2), MapLocation.MirageTower1, Item.Gold2750);
		public static TreasureChest MirageTower3 = new TreasureChest(0x31C6, nameof(MirageTower3), MapLocation.MirageTower1, Item.Gold3400);
		public static TreasureChest MirageTower4 = new TreasureChest(0x31C7, nameof(MirageTower4), MapLocation.MirageTower1, Item.Gold18010);
		public static TreasureChest MirageTower5 = new TreasureChest(0x31C8, nameof(MirageTower5), MapLocation.MirageTower1, Item.Cabin);
		public static TreasureChest MirageTower6 = new TreasureChest(0x31C9, nameof(MirageTower6), MapLocation.MirageTower1, Item.HealHelm);
		public static TreasureChest MirageTower7 = new TreasureChest(0x31CA, nameof(MirageTower7), MapLocation.MirageTower1, Item.Gold880);
		public static TreasureChest MirageTower8 = new TreasureChest(0x31CB, nameof(MirageTower8), MapLocation.MirageTower1, Item.Vorpal);
		public static TreasureChest MirageTower9 = new TreasureChest(0x31CC, nameof(MirageTower9), MapLocation.MirageTower2, Item.House);
		public static TreasureChest MirageTower10 = new TreasureChest(0x31CD, nameof(MirageTower10), MapLocation.MirageTower2, Item.Gold7690);
		public static TreasureChest MirageTower11 = new TreasureChest(0x31CE, nameof(MirageTower11), MapLocation.MirageTower2, Item.SunSword);
		public static TreasureChest MirageTower12 = new TreasureChest(0x31CF, nameof(MirageTower12), MapLocation.MirageTower2, Item.Gold10000);
		public static TreasureChest MirageTower13 = new TreasureChest(0x31D0, nameof(MirageTower13), MapLocation.MirageTower2, Item.DragonArmor);
		public static TreasureChest MirageTower14 = new TreasureChest(0x31D1, nameof(MirageTower14), MapLocation.MirageTower2, Item.Gold8135);
		public static TreasureChest MirageTower15 = new TreasureChest(0x31D2, nameof(MirageTower15), MapLocation.MirageTower2, Item.Gold7900);
		public static TreasureChest MirageTower16 = new TreasureChest(0x31D3, nameof(MirageTower16), MapLocation.MirageTower2, Item.ThorHammer);
		public static TreasureChest MirageTower17 = new TreasureChest(0x31D4, nameof(MirageTower17), MapLocation.MirageTower2, Item.Gold12350);
		public static TreasureChest MirageTower18 = new TreasureChest(0x31D5, nameof(MirageTower18), MapLocation.MirageTower2, Item.Gold13000);
		public static TreasureChest SkyPalace1 = new TreasureChest(0x31D6, nameof(SkyPalace1), MapLocation.SkyPalace1, Item.Gold9900, AccessRequirement.Cube);
		public static TreasureChest SkyPalace2 = new TreasureChest(0x31D7, nameof(SkyPalace2), MapLocation.SkyPalace1, Item.Heal, AccessRequirement.Cube);
		public static TreasureChest SkyPalace3 = new TreasureChest(0x31D8, nameof(SkyPalace3), MapLocation.SkyPalace1, Item.Gold4150, AccessRequirement.Cube);
		public static TreasureChest SkyPalace4 = new TreasureChest(0x31D9, nameof(SkyPalace4), MapLocation.SkyPalace1, Item.Gold7900, AccessRequirement.Cube);
		public static TreasureChest SkyPalace5 = new TreasureChest(0x31DA, nameof(SkyPalace5), MapLocation.SkyPalace1, Item.Gold5000, AccessRequirement.Cube);
		public static TreasureChest SkyPalace6 = new TreasureChest(0x31DB, nameof(SkyPalace6), MapLocation.SkyPalace1, Item.ProRing, AccessRequirement.Cube);
		public static TreasureChest SkyPalace7 = new TreasureChest(0x31DC, nameof(SkyPalace7), MapLocation.SkyPalace1, Item.Gold6720, AccessRequirement.Cube);
		public static TreasureChest SkyPalace8 = new TreasureChest(0x31DD, nameof(SkyPalace8), MapLocation.SkyPalace1, Item.HealHelm, AccessRequirement.Cube);
		public static TreasureChest SkyPalace9 = new TreasureChest(0x31DE, nameof(SkyPalace9), MapLocation.SkyPalace1, Item.Gold180, AccessRequirement.Cube);
		public static TreasureChest SkyPalace10 = new TreasureChest(0x31DF, nameof(SkyPalace10), MapLocation.SkyPalace1, Item.BaneSword, AccessRequirement.Cube);
		public static TreasureChest SkyPalace11 = new TreasureChest(0x31E0, nameof(SkyPalace11), MapLocation.SkyPalace2, Item.WhiteShirt, AccessRequirement.Cube);
		public static TreasureChest SkyPalace12 = new TreasureChest(0x31E1, nameof(SkyPalace12), MapLocation.SkyPalace2, Item.BlackShirt, AccessRequirement.Cube);
		public static TreasureChest SkyPalace13 = new TreasureChest(0x31E2, nameof(SkyPalace13), MapLocation.SkyPalace2, Item.Ribbon, AccessRequirement.Cube);
		public static TreasureChest SkyPalace14 = new TreasureChest(0x31E3, nameof(SkyPalace14), MapLocation.SkyPalace2, Item.OpalGauntlets, AccessRequirement.Cube);
		public static TreasureChest SkyPalace15 = new TreasureChest(0x31E4, nameof(SkyPalace15), MapLocation.SkyPalace2, Item.OpalShield, AccessRequirement.Cube);
		public static TreasureChest SkyPalace16 = new TreasureChest(0x31E5, nameof(SkyPalace16), MapLocation.SkyPalace2, Item.SilverHelm, AccessRequirement.Cube);
		public static TreasureChest SkyPalace17 = new TreasureChest(0x31E6, nameof(SkyPalace17), MapLocation.SkyPalace2, Item.House, AccessRequirement.Cube);
		public static TreasureChest SkyPalace18 = new TreasureChest(0x31E7, nameof(SkyPalace18), MapLocation.SkyPalace2, Item.Gold880, AccessRequirement.Cube);
		public static TreasureChest SkyPalace19 = new TreasureChest(0x31E8, nameof(SkyPalace19), MapLocation.SkyPalace2, Item.Gold13000, AccessRequirement.Cube);
		public static TreasureChest SkyPalaceMajor = new TreasureChest(0x31E9, nameof(SkyPalaceMajor), MapLocation.SkyPalace2, Item.Adamant, AccessRequirement.Cube);
		public static TreasureChest SkyPalace21 = new TreasureChest(0x31EA, nameof(SkyPalace21), MapLocation.SkyPalace3, Item.Gold4150, AccessRequirement.Cube);
		public static TreasureChest SkyPalace22 = new TreasureChest(0x31EB, nameof(SkyPalace22), MapLocation.SkyPalace3, Item.Soft, AccessRequirement.Cube);
		public static TreasureChest SkyPalace23 = new TreasureChest(0x31EC, nameof(SkyPalace23), MapLocation.SkyPalace3, Item.Gold3400, AccessRequirement.Cube);
		public static TreasureChest SkyPalace24 = new TreasureChest(0x31ED, nameof(SkyPalace24), MapLocation.SkyPalace3, Item.Katana, AccessRequirement.Cube);
		public static TreasureChest SkyPalace25 = new TreasureChest(0x31EE, nameof(SkyPalace25), MapLocation.SkyPalace3, Item.ProCape, AccessRequirement.Cube);
		public static TreasureChest SkyPalace26 = new TreasureChest(0x31EF, nameof(SkyPalace26), MapLocation.SkyPalace3, Item.Cloth, AccessRequirement.Cube);
		public static TreasureChest SkyPalace27 = new TreasureChest(0x31F0, nameof(SkyPalace27), MapLocation.SkyPalace3, Item.Gold9500, AccessRequirement.Cube);
		public static TreasureChest SkyPalace28 = new TreasureChest(0x31F1, nameof(SkyPalace28), MapLocation.SkyPalace3, Item.Soft, AccessRequirement.Cube);
		public static TreasureChest SkyPalace29 = new TreasureChest(0x31F2, nameof(SkyPalace29), MapLocation.SkyPalace3, Item.Gold6400, AccessRequirement.Cube);
		public static TreasureChest SkyPalace30 = new TreasureChest(0x31F3, nameof(SkyPalace30), MapLocation.SkyPalace3, Item.Gold8135, AccessRequirement.Cube);
		public static TreasureChest SkyPalace31 = new TreasureChest(0x31F4, nameof(SkyPalace31), MapLocation.SkyPalace3, Item.Gold9000, AccessRequirement.Cube);
		public static TreasureChest SkyPalace32 = new TreasureChest(0x31F5, nameof(SkyPalace32), MapLocation.SkyPalace3, Item.Heal, AccessRequirement.Cube);
		public static TreasureChest SkyPalace33 = new TreasureChest(0x31F6, nameof(SkyPalace33), MapLocation.SkyPalace3, Item.ProRing, AccessRequirement.Cube);
		public static TreasureChest SkyPalace34 = new TreasureChest(0x31F7, nameof(SkyPalace34), MapLocation.SkyPalace3, Item.Gold5450, AccessRequirement.Cube);
		public static TreasureChest ToFRMasmune = new TreasureChest(0x31F8, nameof(ToFRMasmune), MapLocation.TempleOfFiendsAir, Item.Masamune, AccessRequirement.Key | AccessRequirement.BlackOrb | AccessRequirement.Lute);
		public static TreasureChest ToFRevisited2 = new TreasureChest(0x31F9, nameof(ToFRevisited2), MapLocation.TempleOfFiendsFire, Item.Gold26000, AccessRequirement.Key | AccessRequirement.BlackOrb | AccessRequirement.Lute);
		public static TreasureChest ToFRevisited3 = new TreasureChest(0x31FA, nameof(ToFRevisited3), MapLocation.TempleOfFiendsFire, Item.Katana, AccessRequirement.Key | AccessRequirement.BlackOrb | AccessRequirement.Lute);
		public static TreasureChest ToFRevisited4 = new TreasureChest(0x31FB, nameof(ToFRevisited4), MapLocation.TempleOfFiendsFire, Item.ProRing, AccessRequirement.Key | AccessRequirement.BlackOrb | AccessRequirement.Lute);
		public static TreasureChest ToFRevisited5 = new TreasureChest(0x31FC, nameof(ToFRevisited5), MapLocation.TempleOfFiendsFire, Item.ProCape, AccessRequirement.Key | AccessRequirement.BlackOrb | AccessRequirement.Lute);
		public static TreasureChest ToFRevisited6 = new TreasureChest(0x31FD, nameof(ToFRevisited6), MapLocation.TempleOfFiendsPhantom, Item.Gold45000, AccessRequirement.BlackOrb);
		public static TreasureChest ToFRevisited7 = new TreasureChest(0x31FE, nameof(ToFRevisited7), MapLocation.TempleOfFiendsPhantom, Item.Gold65000, AccessRequirement.BlackOrb);
		public static TreasureChest Unused15 = new TreasureChest(0x31FF, nameof(Unused15), 0, 0, isUnused: true);

		public static MapObject KingConeria = new MapObject(ObjectId.King, MapLocation.ConeriaCastle2, Item.Bridge);
		public static MapObject Princess = new MapObject(ObjectId.Princess2, MapLocation.ConeriaCastle2, Item.Lute, requiredSecondLocation: MapLocation.TempleOfFiends1);
		public static MapObject Matoya = new MapObject(ObjectId.Matoya, MapLocation.MatoyasCave, Item.Herb, AccessRequirement.Crystal, requiredItemTrade: Item.Crystal);
		public static MapObject Bikke = new MapObject(ObjectId.Bikke, MapLocation.Pravoka, Item.Ship, useVanillaRoutineAddress: true);
		// Assumption is made that if you have access to the Elf Prince you also have access to the Elf Doc
		public static MapObject ElfPrince = new MapObject(ObjectId.ElfPrince, MapLocation.ElflandCastle, Item.Key, AccessRequirement.Herb, ObjectId.ElfDoc);
		public static MapObject Astos = new MapObject(ObjectId.Astos, MapLocation.NorthwestCastle, Item.Crystal, AccessRequirement.Crown, useVanillaRoutineAddress: true);
		public static MapObject Sarda = new MapObject(ObjectId.Sarda, MapLocation.SardasCave, Item.Rod, requiredGameEventFlag: ObjectId.Vampire, requiredSecondLocation: MapLocation.EarthCaveVampire);
		public static MapObject CanoeSage = new MapObject(ObjectId.CanoeSage, MapLocation.CresentLake, Item.Canoe, AccessRequirement.EarthOrb, requiredItemTrade: Item.EarthOrb);
		public static MapObject CubeBot = new MapObject(ObjectId.CubeBot, MapLocation.Waterfall, Item.Cube);
		public static MapObject Fairy = new MapObject(ObjectId.Fairy, MapLocation.Gaia, Item.Oxyale, AccessRequirement.Bottle);
		// Assumption is made that if you have the slab and access to Lefein then you also have access to Unne
		public static MapObject Lefein = new MapObject(ObjectId.Lefein, MapLocation.Lefein, Item.Chime, AccessRequirement.Slab, ObjectId.Unne, requiredSecondLocation: MapLocation.Melmond);
		public static MapObject Nerrick = new MapObject(ObjectId.Nerrick, MapLocation.DwarfCave, Item.Canal, AccessRequirement.Tnt, requiredItemTrade: Item.Tnt);
		public static MapObject Smith = new MapObject(ObjectId.Smith, MapLocation.DwarfCave, Item.Xcalber, AccessRequirement.Adamant, requiredItemTrade: Item.Adamant);

		public static ItemShopSlot CaravanItemShop1 =
			new ItemShopSlot(0x38461, nameof(CaravanItemShop1), MapLocation.Caravan, Item.Bottle);

		public static StaticItemLocation LichReward =
			new StaticItemLocation(nameof(LichReward), MapLocation.EarthCaveLich, Item.EarthOrb, AccessRequirement.Rod);
		public static StaticItemLocation KaryReward =
			new StaticItemLocation(nameof(KaryReward), MapLocation.GurguVolcanoKary, Item.FireOrb);
		public static StaticItemLocation KrakenReward =
			new StaticItemLocation(nameof(KrakenReward), MapLocation.SeaShrineKraken, Item.WaterOrb, AccessRequirement.Oxyale);
		public static StaticItemLocation TiamatReward =
			new StaticItemLocation(nameof(TiamatReward), MapLocation.SkyPalaceTiamat, Item.AirOrb, AccessRequirement.Cube);
		public static StaticItemLocation ChaosReward =
			new StaticItemLocation(nameof(ChaosReward), MapLocation.TempleOfFiendsChaos, Item.None, AccessRequirement.Key | AccessRequirement.BlackOrb | AccessRequirement.Lute);

		private const MapChange AirshipAndCanoe = MapChange.Airship | MapChange.Canoe;
		private const MapChange CanalAndShip = MapChange.Canal | MapChange.Ship;
		private const MapChange ShipAndCanoe = MapChange.Canoe | MapChange.Ship;
		public static Dictionary<MapLocation, IEnumerable<MapChange>> MapLocationRequirements =
			new Dictionary<MapLocation, IEnumerable<MapChange>>
		{
			{MapLocation.StartingLocation, new List<MapChange>{ MapChange.None }},
			{MapLocation.Coneria, new List<MapChange>{ MapChange.None }},
			{MapLocation.ConeriaCastle1, new List<MapChange>{ MapChange.None }},
			{MapLocation.TempleOfFiends1, new List<MapChange>{ MapChange.None }},
			{MapLocation.MatoyasCave, new List<MapChange>{ MapChange.Bridge, MapChange.Ship, MapChange.Airship }},
			{MapLocation.Pravoka, new List<MapChange>{ MapChange.Bridge, MapChange.Ship, MapChange.Airship }},
			{MapLocation.DwarfCave, new List<MapChange>{ MapChange.Ship, MapChange.Airship }},
			{MapLocation.Elfland, new List<MapChange>{ MapChange.Ship, MapChange.Airship }},
			{MapLocation.ElflandCastle, new List<MapChange>{ MapChange.Ship, MapChange.Airship }},
			{MapLocation.NorthwestCastle, new List<MapChange>{ MapChange.Ship, MapChange.Airship }},
			{MapLocation.MarshCave1, new List<MapChange>{ MapChange.Ship, MapChange.Airship }},
			{MapLocation.Melmond, new List<MapChange>{ CanalAndShip, MapChange.Airship }},
			{MapLocation.EarthCave1, new List<MapChange>{ CanalAndShip, MapChange.Airship }},
			{MapLocation.TitansTunnelEast, new List<MapChange>{ CanalAndShip, MapChange.Airship }},
			{MapLocation.TitansTunnelWest, new List<MapChange>{ CanalAndShip | MapChange.TitanFed, MapChange.Airship }},
			{MapLocation.SardasCave, new List<MapChange>{ CanalAndShip | MapChange.TitanFed, MapChange.Airship }},
			{MapLocation.CresentLake, new List<MapChange>{ CanalAndShip, ShipAndCanoe, MapChange.Airship }},
			{MapLocation.GurguVolcano1, new List<MapChange>{ ShipAndCanoe, MapChange.Airship }},
			{MapLocation.IceCave1, new List<MapChange>{ MapChange.Bridge | MapChange.Canoe, MapChange.Ship | MapChange.Canoe, MapChange.Airship }},
			{MapLocation.CastleOrdeals1, new List<MapChange>{ CanalAndShip | MapChange.Canoe, AirshipAndCanoe }},
			{MapLocation.Cardia2, new List<MapChange>{ MapChange.Airship }},
			{MapLocation.Cardia4, new List<MapChange>{ MapChange.Airship }},
			{MapLocation.Cardia6, new List<MapChange>{ MapChange.Airship }},
			{MapLocation.Caravan, new List<MapChange>{ MapChange.Airship }},
			{MapLocation.Gaia, new List<MapChange>{ MapChange.Airship }},
			{MapLocation.Onrac, new List<MapChange>{ AirshipAndCanoe }},
			{MapLocation.Waterfall, new List<MapChange>{ AirshipAndCanoe }},
			{MapLocation.Lefein, new List<MapChange>{ MapChange.Airship }},
			{MapLocation.MirageTower1, new List<MapChange>{ MapChange.Chime | MapChange.Airship }},
			{MapLocation.AirshipLocation, new List<MapChange>{ ShipAndCanoe }}
		};

		public static Dictionary<MapLocation, RomUtilities.Blob> ShipLocations = new Dictionary<MapLocation, RomUtilities.Blob>
		{
			{MapLocation.ConeriaCastle1, Dock.Coneria},
			{MapLocation.Coneria, Dock.Coneria},
			{MapLocation.TempleOfFiends1, Dock.Coneria},
			{MapLocation.DwarfCave, Dock.DwarfCave},
			{MapLocation.MatoyasCave, Dock.MatoyasCave},
			{MapLocation.Pravoka, Dock.Pravoka},
			{MapLocation.IceCave1, Dock.Pravoka},
			{MapLocation.ElflandCastle, Dock.Elfland},
			{MapLocation.Elfland, Dock.Elfland},
			{MapLocation.MarshCave1, Dock.Elfland},
			{MapLocation.NorthwestCastle, Dock.Elfland},
			{MapLocation.CresentLake, Dock.Elfland},
			{MapLocation.GurguVolcano1, Dock.Elfland},
		};
	}
}
