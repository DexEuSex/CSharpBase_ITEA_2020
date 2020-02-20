using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_Game
{
    public class Sword : GameObjects, IWeapon
    {
        public int Damage { get; set; } = 5; 
        public bool Used { get; set; } = false;

        public void SpecialAttack(Person enemy)
        {
            Console.WriteLine("Разоружить противника!");
        }

        public override void Interaction(GameObjects obj)
        {
            base.Interaction(obj);
            if (obj is Person person)
            {
                person.Weapon = "Sword";
                Used = true;
            }
        }
    }
}
