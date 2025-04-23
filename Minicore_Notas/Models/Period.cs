using System.ComponentModel.DataAnnotations;

namespace Minicore_Notas.Models
{
    public class Period
    {
        public int Id { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        [Range(1, 99)]
        public int Weigh { get; set; }
    }

}
