using System;
using System.Threading.Tasks;

namespace Lesson7_Game
{
    public class Knife : GameObjects, IWeapon
    {
        public int Damage { get; set; } = 5;
        public bool Used { get; set; } = false;
        public string Type { get; set; } = "Knife";

        public void SpecialAttack(Person enemy)
        {
            Console.WriteLine("Отравление!");
        }

        public override void Interaction(GameObjects obj)
        {
            base.Interaction(obj);
            if (obj is Person person)
            {
                Anim();
                person.Damage += Damage;
                Console.WriteLine("You picked up knife! Your damage now is {0}", person.Damage);
                Used = true;
            }
        }
        public static async void Anim()
        {
            await Task.Delay(100);
        }
    }
}