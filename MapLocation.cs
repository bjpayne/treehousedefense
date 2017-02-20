using System;

namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int xCoordinate, int yCoordinate, Map map) : base (xCoordinate, yCoordinate)
        {
            if (! map.onMap(this))
            { 
                throw new Exception(xCoordinate + "," + yCoordinate + " is outside the boundaries of the map");
            }
        }
    }
}