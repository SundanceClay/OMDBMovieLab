using System.ComponentModel.DataAnnotations;

namespace IMDB.Models
{
    public class SearchMovie
    {
        [Required]
        public string SearchTerm { get; set; }
    }
}
