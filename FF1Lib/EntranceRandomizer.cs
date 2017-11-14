using System;
using System.Collections.Generic;
using System.Linq;
using RomUtilities;

namespace FF1Lib
{
    public partial class FF1Rom
    {
        const int teleportEntranceXOffset = 0x2C00;
        const int teleportEntranceYOffset = 0x2C20;
        const int teleportMapIndexOffset = 0x2C40;
        const int teleportExitXOffset = 0x2C60;
        const int teleportExitYOffset = 0x2C70;
        const int teleportTilesetOffset = 0x2CC0;

        public void PutOverworldTeleport(OWTeleportLocation teleport) 
        {
            Put(teleportEntranceXOffset + teleport.TeleportIndex, new byte[] { teleport.PlacedTeleport.EnterCoordinateX });
            Put(teleportEntranceYOffset + teleport.TeleportIndex, new byte[] { teleport.PlacedTeleport.EnterCoordinateY });
            Put(teleportMapIndexOffset + teleport.TeleportIndex, new byte[] { teleport.PlacedTeleport.MapIndex });
            if (teleport.PlacedTeleport.ExitIndex > 0x0F) return;

            Put(teleportExitXOffset + teleport.PlacedTeleport.ExitIndex, 
                new byte[] { teleport.CoordinateX });
            Put(teleportExitYOffset + teleport.PlacedTeleport.ExitIndex, 
                new byte[] { teleport.CoordinateY });
        }

        public IReadOnlyDictionary<MapLocations, Func<IReadOnlyCollection<MapChanges>, bool>> 
            RandomizeEntrances(MT19337 rng) 
        {
            var maps = TeleportLocations.AllLocations.Except(TeleportLocations.UnusedLocations).ToList();
            var defaultRequirements = MapDetails.DefaultMapRequirements;
            Console.WriteLine($"\nStarting Maps");
            foreach (var map in maps)
            {
                Console.WriteLine($"{map.SpoilerText}");
            }

            var mapCount = maps.Count;
            var destinations = maps.Select(x => x.PlacedTeleport).ToList();
            var shuffled = new List<OWTeleportLocation>();
            for (byte i = 0; i < mapCount; i++)
                shuffled.Add(new OWTeleportLocation(maps.SpliceRandom(rng), destinations[i]));

            Console.WriteLine($"\nShuffled Maps");
            foreach (var map in shuffled)
            {
                PutOverworldTeleport(map);
                Console.WriteLine($"{map.SpoilerText}");
            }
            var allTeleportLocations = shuffled.Select(x => x.PlacedTeleport.TeleportDestination).Distinct().ToList();
            var newRequirements = defaultRequirements
                .ToDictionary(x => !allTeleportLocations.Contains(x.Key) ? x.Key :
                              shuffled.Single(y => x.Key == ((MapLocations)Enum.Parse(typeof(MapLocations), y.LocationName))).PlacedTeleport.TeleportDestination, 
            x => x.Value);

            return newRequirements;
        }
    }
}
