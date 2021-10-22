using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_4.Shared.Models
{
    public class OrdenAtencion
    {
        [Key]
        public int IdOrdenAtencion { get; set; }
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
        public int Perfil { get; set; }
    }
}
