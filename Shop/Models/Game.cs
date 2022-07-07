using Shop.Data;
using Shop.Data.Base;
using Shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Game:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Descritpion { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreateDate { get; set; }
        public GameCategory GameCategory { get; set; }


        public int AuthorsId { get; set; }
        [ForeignKey("AuthorsId")]
        public Author Authors { get; set; }


        public int ProducersId { get; set; }
        [ForeignKey("ProducersId")]
        public Producer Producers { get; set; }

        public int GameShopsId { get; set; }
        [ForeignKey("GameShopsId")]
        public GameShop GameShops { get; set; }
    }
}
