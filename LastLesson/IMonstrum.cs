using System;
using System.Collections.Generic;
using System.Text;

namespace LastLesson
{
    public interface IMonstrum : ICreatures
    {
        public int[] Loot { get; set; }
        public string Type { get; set; }
        public void Hit();

    }
}
