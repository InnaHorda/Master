using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_metod
{
    class Ukrainian:Human
    {
       
        public Ukrainian(string Name) :base( Name)
        {
            this.Name = Name;
            
        }
        public override void Say_Hello()
        {
            Console.WriteLine("Ukrainian" + Name + " вiдповiсть Доброго дня ");
        }
    }
}
