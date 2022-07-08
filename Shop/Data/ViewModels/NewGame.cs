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
    public class NewGame
    {
        public int Id { get; set; }

        [Display(Name = "Game name")]
        [Required(ErrorMessage ="Name is required")]        
        public String FullName { get; set; }

        [Display(Name = "Descritpion name")]
        [Required(ErrorMessage = "Descritpion is required")]
        public String Descritpion { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public Double Price { get; set; }

        [Display(Name = "Game poster URL")]
        [Required(ErrorMessage = "Image is required")]
        public String ImageURL { get; set; }

        [Display(Name = "Create Date")]
        [Required(ErrorMessage = "Create Date is required")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Game category is required")]
        public GameCategory GameCategory { get; set; }

        [Display(Name = "Select a Author")]
        [Required(ErrorMessage = "Author is required")]
        public int AuthorsId { get; set; }

        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Producer is required")]
        public int ProducersId { get; set; }

        [Display(Name = "Select a Game Shop")]
        [Required(ErrorMessage = "Game Shop is required")]
        public int GameShopsId { get; set; }
    }
}
