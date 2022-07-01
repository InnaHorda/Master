using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_metod
{
    class Ukrainian:Human
    {
        public string Hello { get; set; }
        public string Nationality { get; set; }
        public Ukrainian(string Name,string Hello,string Nationality) :base( Name)
        {
            this.Name = Name;
            this.Hello = Hello;
            this.Nationality = Nationality;
        }
        public override void Say_Hello()
        {
            Console.WriteLine(Nationality + Name + " say " + Hello);
        }
    }
}
