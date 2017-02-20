using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            const int MAP_HEIGHT = 5;

            const int MAP_WIDHT = 8;
            
            Map map = new Map(MAP_HEIGHT, MAP_WIDHT);

            try {
                MapLocation mapLocation = new MapLocation(0, 0, map);

                int distance = mapLocation.distanceTo(mapLocation);
            } catch (Exception e) {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}