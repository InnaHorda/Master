using System;
using System.Collections.Generic;

namespace Abstract_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> Humans = new List<Human>();
            Humans.Add(new Ukrainian("Mychaulo"));
            Humans.Add(new Ameriсan("Maikl "));
            Humans.Add(new Polish("Michal"));

            foreach (Human H in Humans)
            {
                H.Say_Hello();
            }

        }
    }
}
