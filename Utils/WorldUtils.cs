using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;

namespace AndroTLib.Utils;

public static class WorldUtils
{
    public static Vector2 GetTempleLocation()
    {
        Vector2 templePosition = new(0f, 0f);

        for (int x = 0; x < Main.maxTilesX; x++)
        {
            for (int y = 0; y < Main.maxTilesY; y++)
            {
                if (Main.tile[x, y] == null)
                {
                    continue;
                }

                Tile tile = Main.tile[x, y];

                if (tile.TileType == WallID.SolarBrick)
                {
                    templePosition = new(x, y);
                    break;
                }
            }
        }

        return templePosition;
    }
}