using System.Collections.Generic;
using System.Windows.Forms;

namespace DynamicCardDemo
{
    //Dummy Data
    public class ProductRepository
    {
       static string appPath = Application.StartupPath + @"\img\";

        public static List<Product> GetAll()
        {
           return new List<Product>
           {
                new Product { Id = 1, Title="piatos", Price = 13,ImageSource = appPath + "hero.jpeg"},
                new Product { Id = 2, Title="nova", Price = 12 ,ImageSource = appPath + "hero.jpeg"},
                new Product { Id = 3, Title="chippy", Price = 7.50 ,ImageSource = appPath + "hero.jpeg"},
                new Product { Id = 4, Title="cracklings sobra sobra", Price = 7 },
                new Product { Id = 5, Title="martys", Price = 7 },
                new Product { Id = 6, Title="mang juan", Price = 7 },
                new Product { Id = 7, Title="cheese it", Price = 7 },
                new Product { Id = 8, Title="peewee", Price = 7},
                new Product { Id = 9, Title="loaded", Price =  6.50},
                new Product { Id = 10, Title="potatos", Price = 7}
           };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageSource { get; set; }
    }

}
