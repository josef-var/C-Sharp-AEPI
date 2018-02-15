using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioBar
{
    public class NegocioBar : INegocioBar
    {
        private List<Product> List = new List<Product>();

        public void Create(Product p)
        {
            List.Add(p);
        }
        public Product Read(int Id)
        {
            Product product = Find(Id);
            return product;
        }

        public void Update(Product p)
        {
            Product product = Find(p.Id);
            product.Name = p.Name;
            product.Family = p.Family;
            product.Calories = p.Calories;
            product.HasGluten = p.HasGluten;
        }
        public void Delete(int Id)
        {
            Product product = Find(Id);
            List.Remove(product);
        }

        List<Product> Import(string Filename)
        {
            System.IO.StreamReader miStream = new System.IO.StreamReader(Filename);
            string line;
            while ((line = miStream.ReadLine()) != null)
            {
                string[] items = line.Split("\r\n".ToCharArray());
                foreach (string item in items)
                {
                    Product p = JoinProduct(item);
                    this.Create(p);
                }
            }
            return true;
        }

        public void Export(string Filename)
        {
            string serializeProduct = Serialize();
            SaveToFile(Filename, serializeProduct);
        }

//Read one:        
        private Product Find(int Id)
        {
            Product product = null;
            foreach (Product p in List)
            {
                if (p.Id == Id)
                {
                    product = p;
                    break;
                }
            }
            return product;
        }

//Read all:
        public List<Product> GetAll()
        {
            return List;
        }

//JoinProduct function
        private Product JoinProduct(string item)
        {
            string[] propiedades = item.Split(',');
            int id = int.Parse(propiedades[0]);
            string name = propiedades[1];
            string family = propiedades[2]; ;
            int calories = int.Parse(propiedades[3]);
            bool hasGluten = bool.Parse(propiedades[4]);

            Product p = new Product(id, name, family, calories, hasGluten);
            return p;
        }

//Serialize Product
        private String SerializeProduct(Product p)
        {
            return p.Id + ", " + p.Name + ", " + p.Family + ", " + p.Calories + ", " + p.HasGluten + "\r\n";
        }

//Serialize
        private String Serialize()
        {
            string serializeProduct= "";
            foreach (Product p in List)
            {
                serializeProduct += SerializeProduct(p);
            }
            return serializeProduct;
        }
        private void SaveToFile(string fichero, string serializaCoche)
        {
            //using (System.IO.StreamWriter miStream = new System.IO.StreamWriter) ;
            System.IO.StreamWriter miStream = new System.IO.StreamWriter(fichero);
            miStream.Write(serializaCoche);
            miStream.Close();
            miStream.Dispose();
        }
    }
}
