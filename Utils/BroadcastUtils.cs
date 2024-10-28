using Microsoft.Xna.Framework;
using Terraria.Chat;
using Terraria.Localization;

namespace AndroTLib.Utils;

public static class BroadcastUtils
{
    /// <summary>
    /// Sends a red message in chat
    /// </summary>
    /// <param name="message"></param>
    public static void BroadcastError(string message)
    {
        BroadcastChatMessage(message, Color.Red);
    }

    /// <summary>
    /// Sends a cyan message in chat
    /// </summary>
    /// <param name="message"></param>
    public static void BroadcastInfo(string message)
    {
        BroadcastChatMessage(message, Color.Cyan);
    }

    /// <summary>
    /// Sends a yellow message in chat
    /// </summary>
    /// <param name="message"></param>
    public static void BroadcastWarning(string message)
    {
        BroadcastChatMessage(message, Color.Yellow);
    }

    private static void BroadcastChatMessage(string message, Color color)
    {
        ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(message), color);
    }
}
