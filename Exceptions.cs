using System;

namespace TreehouseDefense
{
    class TreehouseDefenseException : Exception
    {
        public TreehouseDefenseException() : base()
        {
        }

        public TreehouseDefenseException(String message) : base(message)
        {
        }
    }

    class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException() : base()
        {
        }

        public OutOfBoundsException(String message) : base(message)
        {
        }
    }
}