using System;
using System.Collections.Generic;
using System.Text;

namespace LastLesson
{
    public abstract class ObjectOnScene 
    {
        public bool Alive { get; set; }
        public int ID { get; set;  }
        public bool AllowedToSpawn { get; set; }
        public int SpawnLocationID { get; set; }

        public virtual void Move()
        {
            // some code that move objects on scene
        }
        public virtual void Spawn()
        {
            // some code that spawn objects on scene
        }
        
    }
}
