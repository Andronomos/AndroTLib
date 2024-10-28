using Microsoft.Xna.Framework;
using Terraria.Chat;
using Terraria.Localization;

namespace AndroTLib.Utils;

public static class ChatUtils
{
    public static void DisplayInfo(NetworkText message, bool broadcast = true)
    {
        if (broadcast)
        {
            ChatHelper.BroadcastChatMessage(message, Color.Cyan);
            return;
        }

        ChatHelper.DisplayMessage(message, Color.Cyan, byte.MaxValue);
    }

    public static void DisplayWarning(NetworkText message, bool broadcast = true)
    {
        if (broadcast)
        {
            ChatHelper.BroadcastChatMessage(message, Color.Yellow);
            return;
        }

        ChatHelper.DisplayMessage(message, Color.Yellow, byte.MaxValue);
    }

    public static void DisplayError(NetworkText message, bool broadcast = true)
    {
        if (broadcast)
        {
            ChatHelper.BroadcastChatMessage(message, Color.Red);
            return;
        }

        ChatHelper.DisplayMessage(message, Color.Red, byte.MaxValue);
    }

    public static NetworkText AsLiteral(string message)
    {
        return NetworkText.FromLiteral(message);
    }
}
