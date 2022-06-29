using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class GameShop
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Localization { get; set; }

        public List<Game> Games {get; set;} 
    }
}
