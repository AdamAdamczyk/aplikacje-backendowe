using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                //Sklepy
                //if (!context.GameShops.Any())
                //{
                //    context.GameShops.AddRange(new List<GameShop>()
                //    {
                //        new GameShop()
                //        {
                //            Name = "Game Shop 1",
                //            Logo = "https://static.pepper.pl/merchants/raw/avatar/1616_1/re/94x94/qt/70/1616_1.jpg",
                //            Localization = "Kraków"
                //        },
                //        new GameShop()
                //        {
                //            Name = "Game Shop 2",
                //            Logo = "https://i.pinimg.com/280x280_RS/89/ae/f3/89aef38ee327f7a9513a931e27eb4af7.jpg",
                //            Localization = "Warszawa"
                //        }
                //    });
                //    context.SaveChanges();

                //}
                ////Producenci
                //if (!context.Producers.Any())
                //{
                //    context.Producers.AddRange(new List<Producer>()
                //    {
                //        new Producer()
                //        {
                //            FullName = "Producer 1",
                //            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/0/0e/Stickman.png",
                //            Description = "Test"
                //        },
                //        new Producer()
                //        {
                //            FullName = "Producer 2",
                //            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/0/0e/Stickman.png",
                //            Description = "Test"
                //        }
                //    });
                //    context.SaveChanges();
                //}
                ////Gry
                //if (!context.Games.Any())
                //{
                //    context.Games.AddRange(new List<Game>()
                //    {
                //        new Game()
                //        {
                //            Name = "Game 1",                            
                //            Descritpion = "Test",
                //            Price = 12,
                //            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Monopoly_game_logo.svg/720px-Monopoly_game_logo.svg.png",
                //            CreateDate = System.DateTime.Now.AddDays(-10),
                //            GameCategory = Enums.GameCategory.Cards

                //        },
                //        new Game()
                //        {
                //            Name = "Game 2",
                //            Descritpion = "Test 2",
                //            Price = 12,
                //            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Monopoly_game_logo.svg/720px-Monopoly_game_logo.svg.png",
                //            CreateDate = System.DateTime.Now.AddDays(-10),
                //            GameCategory = Enums.GameCategory.Cards
                //        }
                //    });
                //    context.SaveChanges();
                //}
                ////Autorzy
                //if (!context.Authors.Any())
                //{
                //    context.Authors.AddRange(new List<Author>()
                //    {
                //        new Author()
                //        {
                //            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/0/0e/Stickman.png",
                //            FullName ="Author 1",
                //            Biography = "Test 1"

                //        },
                //        new Author()
                //        {
                //            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/0/0e/Stickman.png",
                //            FullName ="Author 1",
                //            Biography = "Test 1"
                //        }
                //    });
                //    context.SaveChanges();
                //}
            }
        }
    }
}
