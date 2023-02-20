using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarStore.Entities;

namespace GuitarStore.Entities
{
    public class GuitarSpec
    {
        private string builder, model, type, backWood, topWood;
        private int numStrings;

        public GuitarSpec()
        {

        }

        public GuitarSpec(string builder, string model, string type, int numStrings, string backWood , string topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.numStrings = numStrings;
            this.backWood = backWood;
            this.topWood = topWood;
            
        }

        public string getBuilder()
        {
            return builder;
        }

        public string getModel()
        {
            return model;
        }

        public string getType()
        {
            return type;
        }

        public string getBackWood()
        {
            return backWood;
        }

        public string getTopWood()
        {
            return topWood;
        }

        public int getNumStrings()
        {
            return numStrings;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;

            

            if ((model != null) && (!model.Equals("")) && (!model.Equals(otherSpec.model.ToLower())))
                return false;


            if (type != otherSpec.type)
                return false;



            if (backWood != otherSpec.backWood)
                return false;



            if (topWood != otherSpec.topWood)
                return false;


            return true;
        }
    }
}
