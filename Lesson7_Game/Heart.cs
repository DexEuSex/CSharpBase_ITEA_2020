using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_Game
{
    public class Heart : GameObjects
    {
        public bool Used { get; set; } = false;
        public override void Interaction(GameObjects obj)
        {
            base.Interaction(obj);
            if (obj is Person person)
            {
                person.HealthPoints += 30;
                Used = true;
            }
        }
    }
}