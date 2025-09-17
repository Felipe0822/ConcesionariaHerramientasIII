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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private VentasController _controller;
        private string Marca;
        private string Modelo;
        private double Precio;
        private int IdAutomovil;

        // 🔹 Constructor personalizado
        public frmCliente(VentasController controller, string marca, string modelo, double precio, int idAutomovil)
        {
            InitializeComponent();

            _controller = controller;
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            IdAutomovil = idAutomovil;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string cedula = txtCedula.Text;
            string direccion = txtCedula.Text;

            _controller.RegistrarCliente(nombre, cedula, direccion, Marca, Modelo, Precio, IdAutomovil);
            this.Close();
        }
    }
}

