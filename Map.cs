namespace TreehouseDefense
{
    class Map
    {
        public readonly int width;
        public readonly int height;

        public Map(int width, int height)
        {
            this.width = width;

            this.height = height;
        }

        public bool onMap(MapLocation point)
        {
            return point.xCoordinate <= this.width && point.xCoordinate >= 0 && 
                   point.yCoordinate <= this.height && point.yCoordinate >= 0;
        }
    }
}