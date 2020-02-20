using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_Game
{
    public class Cell
    {
        public GameObjects GameObject { get; set; }

        public Cell()
        {
        }

        public Cell(GameObjects gameObject)
        {
            GameObject = gameObject;
        }

        public bool IsEmpty()
        {
            return GameObject == null;
        }
    }
}
