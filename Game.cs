namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            int mapHeight = 5;

            int mapWidth = 8;
            
            Map map = new Map(mapHeight, mapWidth);

            Point point = new Point(4, 6);

            int distance = point.calculateDistance(3, 4);
        }
    }
}