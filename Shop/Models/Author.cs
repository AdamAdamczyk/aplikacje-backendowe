using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }

    }
}
