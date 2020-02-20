using System;

namespace Lesson7_Game
{
    public abstract class GameObjects
    {
        public string Name { get; set; }
        public virtual void Interaction(GameObjects obj)
        {
            Console.WriteLine("Interaction: {0} => {1}", Name, obj.Name);
        }
    }
}