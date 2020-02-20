using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_Game
{
    public interface IWeapon
    {
        public static int Damage { get; set; } = 0;
        public static string Type { get; set; } = "None";
        public static string Name { get; set; }
        public void SpecialAttack(Person enemy);
    }
}
