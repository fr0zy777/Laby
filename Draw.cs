using System;

namespace Jmix
{
    class Draw
        {
            public static void DrawMap(char[,] map, int height, int width)
            {
                int mapdraw = 0;
                for (int i = 0; i < height; i++)
                {
                    for (int gg = 0; gg < width; gg++)
                    {
                        Console.Write(map[i, gg]);
                    }
                    Console.Write('\n');
                }
            }
        }



    }
