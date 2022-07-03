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

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Descritpion { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Image")]
        public string ImageURL { get; set; }

        [Display(Name = "Date")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Category")]
        public GameCategory GameCategory { get; set; }


        public List<GameShop> GameShops { get; set; }

        public List<Author> Authors { get; set; }

        public List<Producer> Producers { get; set; }

    }
}
