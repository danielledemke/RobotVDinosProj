using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Herd
    {
        //member variables
       public int startingDinos = 0;
       public int totalDinos = 3;
       public int totalHerdHealth;
        public List<Dinosaur> dinos;

        //constructor
        public Herd()
        {
            CreateHerd();
            
    }

            
        public void CreateHerd()
        {
            dinos = new List<Dinosaur>();
            for (int i = 0; i < totalDinos; i++)
            {
               Dinosaur dino = new Dinosaur();
                dinos.Add(dino);
            }
        }

    }
}
       

        //member methods


    

