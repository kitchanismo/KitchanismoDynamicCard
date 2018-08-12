using DynamicCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicCardDemo
{
    
    public class Repository
    {
        static string _path = Application.StartupPath + @"\img\";

        //dummy
        public static IEnumerable<CardArgs> GetDummyCards()
        {
            var cards = new List<CardArgs>();

            var details = new Dictionary<string, object>
            {
                { "info", "dummy dummy dummy dummy dummy dummy dummy dummy dummy dummy dummy dummy" }
                //add more here
            };

            foreach (var product in new Array[100])
            {
                cards.Add(new CardArgs
                {
                    Key = Guid.NewGuid().ToString(),//unique id or key
                    Title = Guid.NewGuid().ToString(),
                    Price = 99,
                    Stock = 3,
                    Category = "Category",
                    ImagePath = null,
                    Subtitle = "Your subtitle here",
                    Currency = "Php",
                    Details = details
                });
            }
            return cards;
        }

        //actual data
        public static IEnumerable<CardArgs> GetCards()
        {
            var cards = new List<CardArgs>();

            var details = new Dictionary<string, object>
        {
            { "info", "dummy dummy dummy dummy dummy dummy dummy dummy dummy dummy dummy dummy" }
            //add more here
        };

            foreach (var product in Products)
            {
                cards.Add(new CardArgs
                {
                    Key = Guid.NewGuid().ToString(),//unique id or key
                    Title = product.Title,
                    Price = product.Price,
                    Stock = product.Stock,
                    Category = product.Category,
                    ImagePath = _path + product.ImagePath,
                    Subtitle = "Your subtitle here",
                    Currency = "Php",
                    Details = details
                });
            }
            return cards;
        }

        private static IEnumerable<Product> Products => new List<Product>
        {
            new Product
            {
                Title ="piatos",
                Price = 13,
                ImagePath = "xxx",
                Stock = 5,
                Category = "Snack"
            },
            new Product
            {
                Title ="nova",
                Price = 12 ,
                ImagePath =  "hero.jpeg",
                Stock = 3,
                Category = "Snack"

            },
            new Product
            {
                Title ="chippy",
                Price = 7.50 ,
                ImagePath =  "hero.jpeg",
                Stock = 2,
                Category = "Snack"
            },
            new Product
            {
                Title ="cracklings",
                Price = 7 ,
                ImagePath =  "hero.jpeg",
                Stock = 0,
                Category = "Snack"
            },
            new Product
            {
                Title ="martys",
                Price = 7 ,
                ImagePath =  "hero.jpeg",
                Stock = 7,
                Category = "Snack"
            },
            new Product {
                Title ="mang juan",
                Price = 7 ,
                ImagePath =  "hero.jpeg",
                Stock = 5,
                Category = "Snack"

            },
            new Product
            {
                Title ="cheese it",
                Price = 7 ,
                 ImagePath =  "hero.jpeg",
                Stock = 5,
                Category = "Snack"
            },
            new Product
            {
                Title ="pop cola",
                Price = 7 ,
                 ImagePath =  "hero.jpeg",
                Stock = 1,
                Category = "Softdrinks"
            },
             new Product {
                Title ="coke",
                Price = 7 ,
                ImagePath =  "hero.jpeg",
                Stock = 5,
                Category =  "Softdrinks"

            },
            new Product
            {
                Title ="royal",
                Price = 7 ,
                ImagePath =  "hero.jpeg",
                Stock = 5,
                Category =  "Softdrinks"
            },
            new Product
            {
                Title ="peewee",
                Price = 7 ,
                ImagePath =  "hq.jpg",
                Stock = 1,
                Category = "Snack"
            },


        };

    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
    }

}
