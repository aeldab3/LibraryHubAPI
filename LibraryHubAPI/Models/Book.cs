using System.ComponentModel.DataAnnotations;

namespace LibraryHubAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required, StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required, StringLength(50, ErrorMessage = "Author cannot exceed 50 characters.")]
        public string Author { get; set; } = string.Empty;

        [Required]
        public int YearPublished { get; set; }
    }
}
