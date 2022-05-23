using System.ComponentModel.DataAnnotations;

namespace IMDB.Models
{
    public class TripleSearch
    {
        [Required]
        [Display(Name = "1st Movie")]
        public string SearchTerm1 { get; set; }

        [Required]
        [Display(Name = "2nd Movie")]
        public string SearchTerm2 { get; set; }

        [Required]
        [Display(Name = "3rd Movie")]
        public string SearchTerm3 { get; set; }
    }
}
