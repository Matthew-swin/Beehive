using System.Collections.Generic;
using System;

namespace revision
{
    public class Beehive
    {
        public List<Bees> Beelist =  new List<Bees>();
        public int MaxOfBees;

        public Beehive(int maxOfBees)
        {
            MaxOfBees = maxOfBees;
        }






        //add bee method
        public void AddBee(Bees bees)
        {
            if (Beelist.Count > MaxOfBees) {
            return;    
            }
            else
            Beelist.Add(bees);  
        }
        //collect honey method
        public void collectHoney(int days)
        {
           //Amount: float = days * bee Size * 0.2   
           float honey = 0;
           
            foreach (var Bees in Beelist)
           {
            float honey1 = 0;
            honey1 += days * Bees.Size * 0.2F;  
            honey += honey1;
           }
          Console.WriteLine($"the amount of honey collected is {honey}.");

        }
    }

}