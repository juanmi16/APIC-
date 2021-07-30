using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TareaAPI.Models
{
    public class Modelo
    {
        [Key]
        public int IdModelo { get; set; }
        public String NombreModelo { get; set; }
        public Boolean Traccion { get; set; }
        public int CantidadPuerta { get; set; }
    }
}