using System;

namespace TreehouseDefense
{
class Point
    {
        public readonly int xCoordinate;
        public readonly int yCoordinate;

        public Point(int xCoordinate, int yCoordinate)
        {
            if (xCoordinate < 0 || yCoordinate < 0) {
                throw new System.ArgumentException("X and Y coordinates must be greater than or equal to 0");
            }

            this.xCoordinate = xCoordinate;

            this.yCoordinate = yCoordinate;
        }

        public int calculateDistance(int xCoordinate, int yCoordinate)
        {
            double xDiff = Math.Pow(this.xCoordinate - xCoordinate, 2);

            double yDiff = Math.Pow(this.yCoordinate - yCoordinate, 2); 

            double distance = Math.Sqrt(xDiff + yDiff);

            return (int) distance;
        }
    }
}