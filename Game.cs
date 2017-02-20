namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            int mapHeight = 5;

            int mapWidth = 8;
            
            Map map = new Map(mapHeight, mapWidth);

            MapLocation point = new MapLocation(4, 6);

            int distance = point.distanceTo(point);
        }
    }
}