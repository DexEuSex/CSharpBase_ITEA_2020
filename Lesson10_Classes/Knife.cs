using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_Classes
{
    class Knife : Weapon
    {
        public int OneHandedSkillLevelNeeded { get; set; } = 2;
        public override void StabOrSwing(Weapon type)
        {
            base.StabOrSwing(type);
            if (type is Weapon sword)
            {

            }
        }
    }
}
