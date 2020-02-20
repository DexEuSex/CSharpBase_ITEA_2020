using System;

namespace Lesson7_Game
{
    public class Sword : GameObjects, IWeapon
    {
        public int Damage { get; set; } = 15; 
        public bool Used { get; set; } = false;
        public string Type { get; set; } = "Sword";

        public void SpecialAttack(Person enemy)
        {
            Console.WriteLine("Разоружить противника!");
        }

        public override void Interaction(GameObjects obj)
        {
            base.Interaction(obj);
            if (obj is Person person)
            {
                person.Damage += Damage;
                Used = true;
            }
        }
    }
}
