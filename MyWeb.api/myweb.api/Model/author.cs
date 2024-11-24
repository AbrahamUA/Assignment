using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyWebAPI.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Bio { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
