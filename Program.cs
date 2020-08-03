using System;
using System.Collections.Generic;

namespace revision
{
    class Program
    {
        public static void Main(string[] args)
        {
            //instantiating beehives and bees
            
            Beehive beehive1 = new Beehive(4);
            Beehive beehive2 = new Beehive(3);

            Bees John = new Bees("John", 3.2F);
            Bees Paul = new Bees("Paul", 2.7F); 
            Bees George = new Bees("George", 1.1F);
            Bees Ringo = new Bees("Ringo", 2.0F);

            Bees Kurt = new Bees("Kurt", 2.3F);
            Bees Dave = new Bees("Dave", 7.4F);
            Bees Krist = new Bees("Krist", 1.5F);

            //adding bees to beehives
            beehive1.AddBee(John);
            beehive1.AddBee(Paul);
            beehive1.AddBee(George);
            beehive1.AddBee(Ringo);

            beehive2.AddBee(Kurt);
            beehive2.AddBee(Dave);
            beehive2.AddBee(Krist);

            Console.WriteLine(beehive1.Beelist);
            Console.WriteLine(beehive2.Beelist);
            beehive1.collectHoney(4);
            beehive2.collectHoney(4);

            
        }
    }
}
