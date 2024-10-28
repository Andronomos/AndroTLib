using Microsoft.Xna.Framework;
using Terraria.Chat;
using Terraria.Localization;

namespace AndroTLib.Utils;

public static class BroadcastUtils
{
    public static void BroadcastError(string message)
    {
        BroadcastChatMessage(message, Color.Red);
    }

    public static void BroadcastInfo(string message)
    {
        BroadcastChatMessage(message, Color.Yellow);
    }

    public static void BroadcastWarning(string message)
    {
        BroadcastChatMessage(message, Color.Yellow);
    }

    private static void BroadcastChatMessage(string message, Color color)
    {
        ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(message), color);
    }
}
