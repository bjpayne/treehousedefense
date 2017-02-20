using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            int mapHeight = 5;

            int mapWidth = 8;
            
            Map map = new Map(mapHeight, mapWidth);

            try {
                MapLocation mapLocation = new MapLocation(7, 6, map);

                int distance = mapLocation.distanceTo(mapLocation);
            } catch (Exception e) {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}