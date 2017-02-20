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

    class OutOfBoundException : TreehouseDefenseException
    {
        public OutOfBoundException() : base()
        {

        }

        public OutOfBoundException(String message) : base(message)
        {

        }
    }
}