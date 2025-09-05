using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioHerramientas.Models
{
    public class Automoviles
    {
        [Key]
        public int IdAutomovil { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public int IdMarca { get; set; }

        [ForeignKey("IdMarca")]
        public Marcas? Marca { get; set; }
    }
}
