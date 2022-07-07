using Shop.Models;
using System.Collections.Generic;

namespace Shop.Data.ViewModels
{
    public class NewGameDropdowns
    {
        public NewGameDropdowns()
        {
            Producers = new List<Producer>();
            Authors = new List<Author>();
            GameShops = new List<GameShop>();
        }

        public List <Producer> Producers { get; set; }
        public List <Author> Authors { get; set; }
        public List <GameShop> GameShops { get; set; }
    }
}
