using ConcesionarioHerramientas.Controllers;
using ConcesionarioHerramientas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcesionarioHerramientas.Views
{
    public partial class frmCliente : Form
    {
        private readonly int _idCliente;
        private readonly int _idAutomovil;
        

     
        private int IdCliente;
        private ClientesController _controller;
        private string Marca;
        private string Modelo;
        private decimal Precio;
        private int IdAutomovil;

        // 🔹 Constructor personalizado
        public frmCliente(ClientesController controller, string marca, string modelo, decimal precio, int idAutomovil)
        {
            InitializeComponent();

            _controller = controller;
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            IdAutomovil = idAutomovil;

            lblAuto.Text = $"{modelo} - {precio:C}";

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(direccion) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor rellene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show("El telefono no puede contener letras", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cedula.All(char.IsDigit))
            {
                MessageBox.Show("La cedula no puede contener letras", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!nombre.All(char.IsLetter))
            {
                MessageBox.Show("El nombre no puede contener numeros", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patron))
            {
                MessageBox.Show("Email invailido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Guardar cliente y obtener id generado
            var clienteController = new ClientesController();
            int idCliente = _idCliente;
            int idAutomovil = _idAutomovil;
            try
            {
                clienteController.RegistrarCliente(nombre, cedula, direccion, Marca, Modelo, Precio, IdAutomovil, email, apellido, telefono, IdCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message);
                return;
            }

        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.ForeColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var controller = new ClientesController();
            controller.CerrarFormularioCliente(this);
        }
    }
}

