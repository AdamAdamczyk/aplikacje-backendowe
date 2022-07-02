using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public List<Game> Games { get; set; }
    }
}
