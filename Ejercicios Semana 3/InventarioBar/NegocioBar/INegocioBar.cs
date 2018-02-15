using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioBar
{
    interface INegocioBar
    {
        void Create(Product p);     //C
        Product Read(int Id);       //R
        void Update(Product p);     //U
        void Delete(int Id);        //D

        List<Product> Import(string Filename);
        void Export(string Filename);
    }
}
