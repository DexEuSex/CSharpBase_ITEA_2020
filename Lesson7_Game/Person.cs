using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_Game
{
    class Person
    {
        int hp;
        public int HealthPoints
        {
            get
            {
                return HealthPoints;
            }
            set
            {
                if (value < 0)
                {
                    hp = 0;
                    Alive = false;
                }
                else
                    hp = value;
            }
        }
        public bool Alive { get; set; } = true;
        public int Level { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
            HealthPoints = 100;
            Level = 1;
            Damage = 50;
        }

        public void levelUp()
        {
            Level++;
        }

        public void Hit(Person target)
        {
            if (Alive)
            {
                Random rnd = new Random();
                target.HealthPoints -= Damage;

                if (target.HealthPoints == 0)
                    levelUp();
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine($"My name is {Name}, i have {HealthPoints} hp, my damage is {Damage}, and my level is {Level}");
        }

    }
}
