using Microsoft.Xna.Framework;
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
                Teleport(player, new(Main.dungeonX, Main.dungeonY), true);
                break;
            default:
            case PointOfInterest.Home:
                player.Spawn(PlayerSpawnContext.RecallFromItem);
                break;
            case PointOfInterest.Ocean:
                player.MagicConch();
                break;
            case PointOfInterest.Spawn:
                Teleport(player, new(Main.spawnTileX, Main.spawnTileY), true);
                break;
            case PointOfInterest.Temple:
                HandleTempleTeleport(player);
                break;
            case PointOfInterest.Underworld:
                player.DemonConch();
                break;
        }
    }

    internal static void HandleTempleTeleport(Player player)
    {
        Vector2 templePosition = WorldUtils.GetTempleLocation();

        if (templePosition.X > 0 && templePosition.Y > 0)
        {
            Teleport(player, templePosition, true);
        }
    }

    internal static void Teleport(Player player, Vector2 destination, bool convertFromTileCoords = false)
    {
        if (convertFromTileCoords)
        {
            destination = new(destination.X * 16f + 8f - player.width / 2, destination.Y * 16f - player.height);
        }

        player.Teleport(destination, 2, 0);

        for (int index = 0; index < 70; index++)
        {
            Dust obj = Main.dust[Dust.NewDust(player.position, player.width, player.height, DustID.MagicMirror, player.velocity.X * 0.2f, player.velocity.Y * 0.2f, 150, Color.DarkRed, 1.2f)];
            obj.velocity *= 0.5f;
        }

        Main.TeleportEffect(player.getRect(), 3, 0, 1f, 0, default);
    }
}