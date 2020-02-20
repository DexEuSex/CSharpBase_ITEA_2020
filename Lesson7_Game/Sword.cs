using System;
using System.Threading.Tasks;

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
                Anim();
                person.Damage += Damage;
                Console.WriteLine("You picked up sword! Your damage now is {0}", person.Damage);
                Used = true;
            }
        }
        public static async void Anim()
        {
            await Task.Delay(100);
        }

    }
}
