using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods
{
    class DietFactory
    {
        public Diets GetDiets(string TypeOfDiet,string id )
        {
            if (id == "v") return GetDiets(TypeOfDiet, 1);
            if (id == "o") return GetDiets(TypeOfDiet, 2);
            if (id == "m") return GetDiets(TypeOfDiet, 3);
        }
        public Diets GetDiets(string TypeOfDiet, in id)
        {

        }
    }
    abstract class Diets
    {
        public string TypeOfDiet { get; set; }

        public bool IsDiet { get; set; }
        public string Error { get; set; }
    }
}
