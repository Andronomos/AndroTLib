using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;

namespace AndroTLib.Utils;

public static class PlayerUtils
{
    public static void TeleportToPoi(this Player player, PointOfInterest poi)
    {
        switch (poi)
        {
            case PointOfInterest.Dungeon:
                HandleDungeonTeleport(player);
                break;
            default:
            case PointOfInterest.Home:
                player.Spawn(PlayerSpawnContext.RecallFromItem);
                break;
            case PointOfInterest.LivingTree:
                HandleLivingTreeTeleport(player);
                break;
            case PointOfInterest.Meteorite:
                HandleMeteoriteTeleport(player);
                break;
            case PointOfInterest.Ocean:
                player.MagicConch();
                break;
            case PointOfInterest.Spawn:
                Teleport(player, new(Main.spawnTileX, Main.spawnTileY));
                break;
            case PointOfInterest.Temple:
                HandleTempleTeleport(player);
                break;
            case PointOfInterest.Underworld:
                player.DemonConch();
                break;
        }
    }

    internal static void HandleDungeonTeleport(Player player)
    {

    }

    internal static void HandleLivingTreeTeleport(Player player)
    {

    }

    internal static void HandleMeteoriteTeleport(Player player)
    {

    }

    internal static void HandleTempleTeleport(Player player)
    {
        Vector2 templePosition = WorldUtils.GetTempleLocation();

        if (templePosition.X > 0 && templePosition.Y > 0)
        {
            Teleport(player, templePosition, true);
        }
    }

    internal static void Teleport(Player player, Vector2 destination, bool convertFromTiles = false)
    {
        if (convertFromTiles)
        {
            destination = new(destination.X * 16f + 8f - player.width / 2, destination.Y * 16f - player.height);
        }

        player.Teleport(destination, 2, 0);
    }
}