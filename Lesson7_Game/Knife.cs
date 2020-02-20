using System;

namespace Lesson7_Game
{
    public class Knife : IWeapon
    {
        public int Damage { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }

        public void SpecialAttack(Person enemy)
        {
            Console.WriteLine("Отравленное оружие!");
            enemy.HealthPoints -= 15;
        }
    }
}