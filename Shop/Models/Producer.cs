using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }

        public List<Game> Games { get; set; }
    }
}
