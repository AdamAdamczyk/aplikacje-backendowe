using Shop.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Author:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile picture URL")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Author Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Biography { get; set; }

        public List<Game> Games { get; set; }

    }
}
