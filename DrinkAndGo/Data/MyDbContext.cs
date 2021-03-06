using DrinkAndGo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Drink> Drinks { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Alcoholic",
                Description = "All alcoholic drinks"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 2,
                CategoryName = "Non-alcoholic",
                Description = "All non-alcoholic drinks"
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                CategoryId = 1,
                DrinkId = 1,
                Name = "Beer",
                Price = 7.95,
                ShortDescription = "The most widely consumed alcohol",
                LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                ImageUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/89/869143/1.jpg?9406",
                InStock = true,
                IsPreferredDrink = true,
                ImageThumbnailUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/89/869143/1.jpg?9406"
            }); ;

            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                CategoryId = 1,
                DrinkId = 2,
                Name = "Rum & Coke",
                Price = 12.95,
                ShortDescription = "Cocktail made of cola, lime and rum.",
                LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                ImageUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/69/945524/1.jpg?5196",
                InStock = true,
                IsPreferredDrink = false,
                ImageThumbnailUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/69/945524/1.jpg?5196"
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 3,
                CategoryId = 1,
                Name = "Tequila ",
                Price = 12.95,
                ShortDescription = "Beverage made from the blue agave plant.",
                LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                ImageUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/28/869143/1.jpg?6622",
                InStock = true,
                IsPreferredDrink = false,
                ImageThumbnailUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/28/869143/1.jpg?6622"
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {

                DrinkId = 4,
                CategoryId = 2,
                Name = "Juice ",
                Price = 12.95,
                ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                ImageUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/48/869143/1.jpg?6624",
                InStock = true,
                IsPreferredDrink = false,
                ImageThumbnailUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/48/869143/1.jpg?6624"
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {

                DrinkId = 5,
                CategoryId = 2,
                Name = "Energy ",
                Price = 12.95,
                ShortDescription = "Energy in fruit or vegetable tissue.",
                LongDescription = "Energy, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                ImageUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/53/343734/1.jpg?8957",
                InStock = true,
                IsPreferredDrink = false,
                ImageThumbnailUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/53/343734/1.jpg?8957"
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {

                DrinkId = 6,
                CategoryId = 2,
                Name = "Sidi ALI ",
                Price = 12.95,
                ShortDescription = "Sidi ALI in fruit or vegetable tissue.",
                LongDescription = "Sidi ALI in fruiis not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                ImageUrl = "https://ma.jumia.is/cms/1_2020/00_L1Cat_Nav/Groceries/mobile/Plan-de-travail-1-Eau_.png",
                InStock = true,
                IsPreferredDrink = false,
                ImageThumbnailUrl = "https://ma.jumia.is/cms/1_2020/00_L1Cat_Nav/Groceries/mobile/Plan-de-travail-1-Eau_.png"
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {

                DrinkId = 7,
                CategoryId = 2,
                Name = "Ain ifran ",
                Price = 12.95,
                ShortDescription = "Ain ifran fruit or vegetable tissue.",
                LongDescription = "Ain ifran fruiis not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                ImageUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/97/598014/1.jpg?1906",
                InStock = true,
                IsPreferredDrink = false,
                ImageThumbnailUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/97/598014/1.jpg?1906"
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {

                DrinkId = 8,
                CategoryId = 2,
                Name = "Pepsi",
                Price = 12.95,
                ShortDescription = "Ain ifran fruit or vegetable tissue.",
                LongDescription = "Ain ifran fruiis not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                ImageUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/45/073124/1.jpg?3011",
                InStock = true,
                IsPreferredDrink = false,
                ImageThumbnailUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/45/073124/1.jpg?3011"
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {

                DrinkId = 9,
                CategoryId = 2,
                Name = "Pulpy Jaouda  ",
                Price = 12.95,
                ShortDescription = "Pulpy Jaouda fruit or vegetable tissue.",
                LongDescription = "Ain ifran fruiis not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                ImageUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/14/753443/1.jpg?6216",
                InStock = true,
                IsPreferredDrink = false,
                ImageThumbnailUrl = "https://ma.jumia.is/unsafe/fit-in/300x300/filters:fill(white)/product/14/753443/1.jpg?6216"
            });



        }
    }
}
