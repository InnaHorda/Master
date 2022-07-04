using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_metod
{
    class Ameriсan:Human
    {
       
        public Ameriсan(string Name) :base(Name)
        {
            this.Name = Name;
         
        }
        public override void Say_Hello()
        {
            Console.WriteLine ( "American " +Name+ " say Hello");
        }
    }
}
