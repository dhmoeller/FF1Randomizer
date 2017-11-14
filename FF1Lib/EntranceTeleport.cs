using System;
using System.Linq;

namespace FF1Lib
{
    public struct EntranceTeleport
    {
        public readonly MapLocations TeleportDestination;
        public readonly byte MapIndex;
        public readonly byte EnterCoordinateX;
        public readonly byte EnterCoordinateY;
        public readonly byte Tileset;
        public readonly byte ExitIndex;
        public string SpoilerText =>
        $"{Enum.GetName(typeof(MapLocations), TeleportDestination)}" +
        $"{string.Join("", Enumerable.Repeat(" ", Math.Max(1, 30 - Enum.GetName(typeof(MapLocations), TeleportDestination).Length)).ToList())}" +
        $"\t({EnterCoordinateX}, {EnterCoordinateY}) on Map {MapIndex}";
        public EntranceTeleport(MapLocations mapLocation, byte mapIndex, byte coordinateX, byte coordinateY,
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
}
