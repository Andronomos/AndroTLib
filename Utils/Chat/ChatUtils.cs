using Microsoft.Xna.Framework;
using Terraria.Chat;
using Terraria.Localization;

namespace AndroTLib.Utils.Chat;

public static class ChatUtils
{
    public static void DisplayInfo(string message, bool broadcast)
    {
        if (broadcast)
        {
            ChatHelper.BroadcastChatMessage(AsLiteral(message), Color.Cyan);
            return;
        }

        ChatHelper.DisplayMessage(AsLiteral(message), Color.Cyan, byte.MaxValue);
    }

    public static void DisplayWarning(string message, bool broadcast)
    {
        if (broadcast)
        {
            ChatHelper.BroadcastChatMessage(AsLiteral(message), Color.Yellow);
            return;
        }

        ChatHelper.DisplayMessage(AsLiteral(message), Color.Yellow, byte.MaxValue);
    }

    public static void DisplayError(string message, bool broadcast)
    {
        if (broadcast)
        {
            ChatHelper.BroadcastChatMessage(AsLiteral(message), Color.Red);
            return;
        }

        ChatHelper.DisplayMessage(AsLiteral(message), Color.Red, byte.MaxValue);
    }

    private static NetworkText AsLiteral(string message)
    {
        return NetworkText.FromLiteral(message);
    }
}
