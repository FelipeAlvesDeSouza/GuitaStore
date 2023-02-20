using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarStore.Enums;

namespace GuitarStore.Entities
{
    class ConvertString
    {
        public string ToString(Builder builder)
        {
            switch (builder)
            {
                case Builder.FENDER:
                    {
                        return "fender";
                        break;
                    }

                case Builder.MARTIN:
                    {
                        return "martin";
                        break;
                    }

                case Builder.GIBSON:
                    {
                        return "gibson";
                        break;
                    }

                case Builder.COLLINS:
                    {
                        return "collins";
                        break;
                    }

                case Builder.OLSON:
                    {
                        return "olson";
                        break;
                    }

                case Builder.RYAN:
                    {
                        return "ryan";
                        break;
                    }

                case Builder.PRS:

                    {
                        return "prs";
                        break;
                    }

                case Builder.ANY:
                    {
                        return "any";
                        break;
                    }


                default: return "t";
            }
        }
    }
}
