using ConcesionarioHerramientas.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcesionarioHerramientas.Views
{
    public partial class frmVenta : Form
    {
        private VentasController ventasController;
        private string nombre;
        private string cedula;
        private string direccion;
        private string marca;
        private string modelo;
        private double precio;
        private int idAutomovil;

        public frmVenta(int idAutomovil)
        {
            InitializeComponent();
        }

        public frmVenta(VentasController ventasController, string nombre, string cedula, string direccion, string marca, string modelo, double precio, int idAutomovil)
        {
            this.ventasController = ventasController;
            this.nombre = nombre;
            this.cedula = cedula;
            this.direccion = direccion;
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.idAutomovil = idAutomovil;
        }
    }
}
