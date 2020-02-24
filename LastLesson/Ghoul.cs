using System;
using System.Collections.Generic;
using System.Text;

namespace LastLesson
{
    public class Ghoul : ObjectOnScene, IMonstrum
    {
        public Ghoul()
        {
            

        }

        public override void Spawn()
        {
            base.Move();
            Console.WriteLine("A ghoul spawned");
            // other code;
        }
        public override void Move()
        {
            base.Move();
            // other code
        }

    }
}
