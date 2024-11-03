using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

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
                HandleHomeTeleport(player);
                break;
            case PointOfInterest.LivingTree:
                HandleLivingTreeTeleport(player);
                break;
            case PointOfInterest.Meteorite:
                HandleMeteoriteTeleport(player);
                break;
            case PointOfInterest.Spawn:
                HandleSpawnTeleport(player);
                break;
            case PointOfInterest.Temple:
                HandleTempleTeleport(player);
                break;
            case PointOfInterest.Underworld:
                HandleUnderworldTeleport(player);
                break;
        }
    }

    internal static void HandleDungeonTeleport(Player player)
    {

    }

    internal static void HandleHomeTeleport(Player player)
    {
        Vector2 location = new(Main.spawnTileX, Main.spawnTileY);

        if (player.SpawnX <= 0 && player.SpawnY <= 0)
        {
            HandleSpawnTeleport(player);
        }

        Teleport(player, location);        
    }

    internal static void HandleLivingTreeTeleport(Player player)
    {

    }

    internal static void HandleMeteoriteTeleport(Player player)
    {

    }

    internal static void HandleSpawnTeleport(Player player)
    {
        Teleport(player, new(Main.spawnTileX, Main.spawnTileY));
    }

    internal static void HandleTempleTeleport(Player player)
    {

    }

    internal static void HandleUnderworldTeleport(Player player)
    {

    }

    internal static void Teleport(Player player, Vector2 destination)
    {
        player.position.X = destination.X * 16 + 8 - player.width / 2;
        player.position.Y = destination.Y * 16 - player.height;
    }
}