using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_Classes
{
    class Sword : Weapon
    {
        public int OneHandedSkillLevelNeeded { get; set; } = 5;

        public override void StabOrSwing(Weapon type)
        {
            base.StabOrSwing(type);
            if (Weapon.OneHandedSkillLevel < OneHandedSkillLevelNeeded)
            {
                Console.WriteLine("Skill level is not to deal full damage. Your damage was reduced to {0}", Damage - 2); ;
            }
        }
    }
}
