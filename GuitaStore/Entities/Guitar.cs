using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarStore.Entities;

namespace GuitarStore.Entities
{
    public class Guitar : GuitarSpec
    {
        private string serialNumber;
        private double price;
        private GuitarSpec spec;
 
        public Guitar()
        {

        }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;

        }
     

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }

        public GuitarSpec getSpec()
        {
            return spec;
        }

    }
}
