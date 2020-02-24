using System;
using System.Collections.Generic;
using System.Text;

namespace LastLesson
{
    public interface  ICreatures
    {
        public int Level { get; set; }

        public int Damage { get; set; }

        public int Hp { get; set; }

        public void Interaction();
    }
}
