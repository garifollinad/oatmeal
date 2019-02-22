using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Oatmeal.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category mh
                {
                    CategoryID = 1,
                    CategoryName = "Oatmeal"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Salad"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Drinks"
                },
            };

            return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Brown Sugar Cinnamon Raisin",
                    Description = "Though oatmeal remains a common breakfast dish today, it has been served up for thousands of years. Oats were cultivated in ancient China as far back as 7000 B.C., but the ancient Greeks were the first to eat oatmeal as the porridge-type cereal we know today.!",
                    ImagePath="brown.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Tropical Sunrise",
                    Description = "Though oatmeal remains a common breakfast dish today, it has been served up for thousands of years. Oats were cultivated in ancient China as far back as 7000 B.C., but the ancient Greeks were the first to eat oatmeal as the porridge-type cereal we know today.",
                    ImagePath="tropical.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Quatre Fruits Rouges",
                    Description = "Though oatmeal remains a common breakfast dish today, it has been served up for thousands of years. Oats were cultivated in ancient China as far back as 7000 B.C., but the ancient Greeks were the first to eat oatmeal as the porridge-type cereal we know today.",
                    ImagePath="quatre.jpeg",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Pumpkin Pie",
                    Description = "Though oatmeal remains a common breakfast dish today, it has been served up for thousands of years. Oats were cultivated in ancient China as far back as 7000 B.C., but the ancient Greeks were the first to eat oatmeal as the porridge-type cereal we know today.",
                    ImagePath="pumpkin.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Pomegranate Pistachio",
                    Description = "Though oatmeal remains a common breakfast dish today, it has been served up for thousands of years. Oats were cultivated in ancient China as far back as 7000 B.C., but the ancient Greeks were the first to eat oatmeal as the porridge-type cereal we know today.",
                    ImagePath="pomegranate.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Chipotle Cobb",
                    Description = "Kale, romaine, all-natural grilled chicken, hard-boiled egg, cherry tomatoes, double-smoked bacon, blue cheese crumbles & chipotle-agave dressing",
                    ImagePath="chipotle-cobb.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "35th and Tex",
                    Description = "Romaine, grilled chicken, black beans, grilled corn, cherry tomatoes, avocado, jalapeno crisps, cotija cheese, fresh cilantro & spicy crema dressing",
                    ImagePath="35th-and-tex-salad.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Avocado Caesar",
                    Description = "Romaine, avocado, shaved parmesan, cherry tomatoes, parmesan croutons & classic Caesar dressing with a fresh lemon squeeze",
                    ImagePath="avocado-caesar.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Chimichurri Steak",
                    Description = "Romaine, mesclun, grilled strip steak, roasted crimini mushrooms, grilled onion, double-smoked bacon, parmesan croutons & chimichurri, chimichurri dressing",
                    ImagePath="chimichurri.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Almond Rabdi Frappek",
                    Description = "Classic Rabdi flavored smooth frappe, with a shot of whipped cream and crunchy almond flakes. Get the beach party started.",
                    ImagePath="almond-rabdi.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Cold Cocoa Latte",
                    Description = "Smooth, creamy ice cold chocolate milkshake. Who can say no to this classic beverage?",
                    ImagePath="cold-cocoa.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3
                }
            };

            return products;
        }
    }
    }