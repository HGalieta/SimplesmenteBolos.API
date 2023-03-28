using System.ComponentModel.DataAnnotations;

namespace SimplesmenteBolos.API.Models
{
    public class Bolo
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
