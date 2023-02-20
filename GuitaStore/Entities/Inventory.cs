using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuitarStore.Entities
{
    public class Inventory : Guitar
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(string serialNumber, double price, string builder, string model, string type, int numStrings , string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, new GuitarSpec(builder, model ,type, numStrings, backWood, topWood));
            guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {   
                if (guitar.getSerialNumber().Equals(serialNumber))
                {

                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            
            foreach (Guitar guitar in guitars)
            {
             
                GuitarSpec guitarSpec = guitar.getSpec();

                if(guitar.getSpec().Matches(searchSpec))

                guitars.Add(guitar);
            }
            return guitars;
        }

    }
}
