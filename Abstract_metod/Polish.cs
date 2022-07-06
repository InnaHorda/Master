using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_metod
{
    class Polish:Human
    {
        
        public Polish(string Name) :base(Name)
        {
            this.Name = Name;
          
        }
        public override void Say_Hello()
        {
            Console.WriteLine("Polish" + Name + " powie Czesz ");

        }
    }
}
