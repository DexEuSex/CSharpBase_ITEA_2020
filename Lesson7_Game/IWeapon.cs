using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_Game
{
    public interface IWeapon
    {
        public int Damage { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public void SpecialAttack(Person enemy);
    }
}
