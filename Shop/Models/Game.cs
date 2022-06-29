using Shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreateDate { get; set; }
        public GameCategory GameCategory { get; set; }


        public List<GameShop> GameShops { get; set; }

        public List<Author> Authors { get; set; }

        public List<Producer> Producers { get; set; }

    }
}
