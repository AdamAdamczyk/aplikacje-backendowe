using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Author Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Biography { get; set; }

        public List<Game> Games { get; set; }

    }
}
