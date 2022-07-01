using System;
using System.Collections.Generic;

namespace Abstract_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> Humans = new List<Human>();
            Humans.Add(new Ukrainian("Mychaulo", "Доброго дня","Ukrainian "));
            Humans.Add(new Ameriсan("Maikl", "Hi","American "));
            Humans.Add(new Polish("Michal", "Czesz", "Polish "));

            foreach (Human H in Humans)
            {
                H.Say_Hello();
            }

        }
    }
}
