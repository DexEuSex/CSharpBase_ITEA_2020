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
            if (type is Weapon sword)
            {

            }
        }
    }
}
