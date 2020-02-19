using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_Classes
{
    class Weapon
    {
        public string Name { get; set; }
        public static int OneHandedSkillLevel { get; set; }
        public double Damage { get; set; } = 10;

        public virtual void StabOrSwing(Weapon type)
        {
            Console.WriteLine("Enemy was hit by {0}", type);
        }

    }
}
