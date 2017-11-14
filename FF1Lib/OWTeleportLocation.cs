using System;
using System.Linq;

namespace FF1Lib
{
    public struct OWTeleportLocation
    {
        public readonly byte TeleportIndex;
        public readonly byte CoordinateX;
        public readonly byte CoordinateY;
        public readonly string LocationName;
        public readonly EntranceTeleport PlacedTeleport;
        public string SpoilerText =>
        $"{LocationName}{string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - LocationName.Length)).ToList())}" +
        $"\t{PlacedTeleport.SpoilerText}";
        public OWTeleportLocation(byte teleportIndex, byte coordinateX, byte coordinateY,
                                  EntranceTeleport placedLocation)
        {
            TeleportIndex = teleportIndex;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            PlacedTeleport = placedLocation;
            LocationName = OverworldTeleportIndex.NameByIndex[TeleportIndex];
        }
        public OWTeleportLocation(OWTeleportLocation copyFromTeleportLocation,
                                  EntranceTeleport newPlacement)
        {
            TeleportIndex = copyFromTeleportLocation.TeleportIndex;
            CoordinateX = copyFromTeleportLocation.CoordinateX;
            CoordinateY = copyFromTeleportLocation.CoordinateY;
            PlacedTeleport = newPlacement;
            LocationName = OverworldTeleportIndex.NameByIndex[TeleportIndex];
        }
    }
}
