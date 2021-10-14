using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Magic.Models
{
    public class Suerte
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Este espacio es requerido")]
        [StringLength(100, MinimumLength = 50)]
        public string FuturoId { get; set; }
        [Required(ErrorMessage = "Espacio requerido")]
        [StringLength(300, ErrorMessage = "Necesitas llenar este espacio", MinimumLength = 150)]
        public string Vision { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Necesitas colocar un url de imagen en este espacio")]
        public string Imagen { get; set; }
    }
}
