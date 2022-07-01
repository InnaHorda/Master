using System;

using System.Text;using System.Collections.Generic;

namespace Abstract_metod
{
   abstract class Human
    {
        public  string Name { get; set; }
        public Human(string Name)
        {
            this.Name = Name;
        }
       
        public abstract void Say_Hello();
    }
}
