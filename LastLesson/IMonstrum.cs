using System;
using System.Collections.Generic;
using System.Text;

namespace LastLesson
{
    public interface IMonstrum : ICreatures
    {
        public string[] LootName { get; set; }
        public string Type { get; set; }
        public abstract void Hit(GameObjectHuman target);

    }
}
