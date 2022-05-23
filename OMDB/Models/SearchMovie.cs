using System.ComponentModel.DataAnnotations;

namespace IMDB.Models
{
    public class SearchMovie
    {
        [Required]
        [Display(Name = "Movie Name")]
        public string SearchTerm { get; set; }
    }
}
