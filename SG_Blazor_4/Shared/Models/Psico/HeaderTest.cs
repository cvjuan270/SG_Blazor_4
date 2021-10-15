using System;
using System.ComponentModel.DataAnnotations;

namespace SG_Blazor_4.Shared.Models.Psico
{
    public class HeaderTest
    {
        [Required]
        [MinLength(8), MaxLength(8)]
        public string Dni { get; set; }
        [Required]
        public string NomApe { get; set; }
        [Required]
        public int? Edad { get; set; }
        [Required]
        public DateTime? Fecha { get; set; }

        public string GradoInstruccion { get; set; }
    }
}
