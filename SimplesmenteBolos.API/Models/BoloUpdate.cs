using System.ComponentModel.DataAnnotations;

namespace SimplesmenteBolos.API.Models
{
    public class BoloUpdate
    {
        [Required]
        public string FileName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
