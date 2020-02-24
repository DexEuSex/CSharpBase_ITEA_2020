using System;
using System.Collections.Generic;
using System.Text;

namespace LastLesson
{
    public class Ghoul : ObjectOnScene, IMonstrum
    {
        
        public string Type { get; set; }
        public int Level { get; set; }
        public string[] LootName { get; set; }
        public int Damage { get; set; }
        public int HealthPoints { get; set; }


        public Ghoul()
        {
            AllowedToSpawn = true;
            LootName[0] = "Кровь гуля";
            LootName[1] = "Лимфа чудовища";
            LootName[2] = "Белый уксус";
            Type = "Трупоед";
            Level = 1;
            HealthPoints = 1100;
        }

        public override void Spawn()
        {
            base.Move();
            Console.WriteLine($"Гуль заспавнился в локации {SpawnLocationID}");
            // other code;
        }
        public override void Move()
        {
            base.Move();
            // other code
        }
        public void Interaction(ObjectOnScene inanimateTarget)
        {
            if (inanimateTarget is ObjectOnScene stone)
            {
                // код позволяющий объекту не застрять в текстуре
            }
        }
        public void Interaction(GameObjectHuman aliveTarget)
        {
            if (aliveTarget is GameObjectHuman)
            {
                FindTarget(aliveTarget);
                Hit(aliveTarget);
            }
        }
        public void Hit(GameObjectHuman target)
        {

        }

        public void FindTarget(ObjectOnScene target)
        {

        }

    }
}
