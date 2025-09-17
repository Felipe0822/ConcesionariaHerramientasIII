using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioHerramientas.Models
{
    public class Ventas
    {
      

        [Key]
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int IdAutomovil { get; set; }
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Clientes Cliente { get; set; }
        [ForeignKey("IdAutomovil")]
        public Automoviles Automovil { get; set; }
    }

        
}
