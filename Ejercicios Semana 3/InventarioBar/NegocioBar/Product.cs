using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioBar
{
    public class Product
    {
        public int Id { get;}
        public string Name { get; set; }
        public string Family { get; set; }
        public int Calories { get; set; }
        public bool HasGluten { get; set; }

        private static int CuentaIds = 1;
        public Product()
        {
            Id = CuentaIds;
            CuentaIds++;
        }
        public Product(int id, string name, string family, int calories, bool hasGluten)
        {
            Id = id;
            Name = name;
            Family = family;
            Calories = calories;
            HasGluten = hasGluten;
        }
    }
}
