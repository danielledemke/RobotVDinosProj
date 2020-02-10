using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Herd : Dinosaur
    {
        //member variables
       public int startingDinos = 0;
       public int totalDinos = 3;
       public int totalHerdHealth;
       public List<Dinosaur> dinos = new List<Dinosaur>();

        //constructor
        public Herd()
        {
            CreateHerd();
            
    }

            
        public void CreateHerd()
        {
            for (int i = 0; i < totalDinos; i++)
            {
                Dinosaur dino = new Dinosaur();
                dinos.Add(dino);
                          
            }
        }

    }
}
       

        //member methods


    

