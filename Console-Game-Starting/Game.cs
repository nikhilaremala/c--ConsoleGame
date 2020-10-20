using System;

namespace ConsoleGame
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(string key, out int xChange, out int yChange)
        {
            if (key == "DownArrow")
            {
                xChange = 0;
                yChange = 1;
            }
            if (key == "upArrow")
            {
                xChange = 0;
                yChange = -1;
            }
            if (key == "RightArrow")
            {
                xChange = 1;
                yChange = 0;
            }
            if (key == "leftArrow")
            {
                xChange = -1;
                yChange = 0;
            }

            else
            {
                xChange = 0;
                yChange = 0;
            }
        }
        public new static char UpdateCursor(string key)
        {

            if (key == "RightArrow")
            {
                return '<';
            }
            if (key == "LeftArrow")
            {
                return '<';
            }
            if (key == "UpArrow")
            {
                return '^';
            }
            if (key == "DownArrow")
            {
                return 'v';
            }
            else
            {
                return '<';
            }
        }
        public new static int KeepInBounds(int dimension, int max)
        {
            if (dimension < 0)
            {
                return 0;
            }
            else if (dimension >= max)
            {
                return max - 1;
            }
            else
            {
                return dimension;
            }
        }
        public new static bool DidScore(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}