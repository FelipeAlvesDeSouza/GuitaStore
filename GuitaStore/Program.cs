using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarStore.Entities;
using GuitarStore.Enums;

namespace GuitarStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inicitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec ( 

                Builder.FENDER.ToString().ToLower(), //Type of builder Guitar
                "Stratocastor", // Model
                TypeGuitar.ELECTRIC.ToString().ToLower(), // Type of Guitar
                12,
                Wood.ALDER.ToString(), // Wood Bad
                Wood.ALDER.ToString() // Wood top
                 // Number of Strings
                );
                


            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

            
            if (matchingGuitars.Count != 0)
            {
                Console.WriteLine("Erin, you might like these guitars");
                
                foreach (Guitar guitar1 in matchingGuitars)
                {
                    GuitarSpec spec = guitar1.getSpec();

                    Console.WriteLine(" We have a " +
                    spec.getBuilder() + " " + spec.getModel() + " " +
                    spec.getNumStrings() + " Strings\n" +
                    spec.getType() + " guitar:\n " +
                    
                    spec.getBackWood() + " na traseira e laterais, \n " +
                    spec.getTopWood() + " no tampo. \nEla pode ser sua por apenas US$ " +
                    guitar1.getPrice() + "!\n ---"

                  );
                }

                
            }
            else
                Console.WriteLine("Desculpe, Erin, não temos nada pra você");


        }

        private static void inicitializeInventory(Inventory inventory)
        {
            inventory.addGuitar("V95693", 1499.95, "Fender", "Stratocastor", "electric", 12, "Alder", "Alder");
            inventory.addGuitar("V95693", 1200.93, "Fender", "Stratocastor", "electric", 12,"Almeiro", "Almeiro");
        }
    }

}