using System.ComponentModel.DataAnnotations;

namespace IMDB.Models
{
    public class TripleSearch
    {
        [Required]
        public string SearchTerm1 { get; set; }

        [Required]
        public string SearchTerm2 { get; set; }

        [Required]
        public string SearchTerm3 { get; set; }
    }
}
