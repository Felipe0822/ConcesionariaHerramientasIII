using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioHerramientas.Models
{
    internal class Marcas
    {
        [Key]
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public List<Automoviles> Automovil { get; set; } = new List<Automoviles>();
    }
}
