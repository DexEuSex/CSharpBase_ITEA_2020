using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_Game
{
    class Person
    {
        int id;
        int hp;
        public int HealthPoints
        {
            get
            {
                return hp;
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

        public Person(string name, int id)
        {
            Name = name;
            HealthPoints = 100;
            Level = 1;
            Damage = 50;
            this.id = id;
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
        public void Move(int[,] map, string direction)
        {
            int currentPos1 = 0;
            int currentPos2 = 0;
            bool find = false;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    if (map[i, k] == id)
                    {
                        find = true;
                        currentPos1 = i;
                        currentPos2 = k;
                        map[i, k] = 0;
                    }
                }
            }
            if (!find)
            {
                Console.WriteLine("Can't find Person with id {0}", id);
                return;
            }
            switch (direction)
            {
                case "w":
                    if (currentPos1 >= 1)
                        currentPos1--;
                    break;
                case "s":
                    if(currentPos1 <= map.GetLength(0) - 2)
                        currentPos1++;
                    break;
                case "d":
                    if (currentPos2 <= map.GetLength(1) - 2)
                        currentPos2++;
                    break;
                case "a":
                    if (currentPos2 >= 1)
                        currentPos2--;
                    break;
                default:
                    break;
            }
            map[currentPos1, currentPos2] = id;
        }
        public void FindSmth(int id)
        {
            if (id == -1)
                HealthPoints += 30;
            else

        }

    }
}
