using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TareaAPI.Models
{
    public class Vehiculo
    {
        [Key]
        public String PlacaVehiculo { get; set; }
        public int IdModelo { get; set; }
        public int AnnoFafricacion { get; set; }
        public Boolean Disponible { get; set; }
    }
}
