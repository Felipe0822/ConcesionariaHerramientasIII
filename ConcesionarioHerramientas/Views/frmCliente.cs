using ConcesionarioHerramientas.Controllers;
using ConcesionarioHerramientas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
             );



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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Fondo con degradado más notorio
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(20, 30, 60),   // Azul oscuro
                                                                       Color.FromArgb(120, 170, 255), // Azul claro
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;

            lblAuto.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblAuto.ForeColor = Color.White;
            lblAuto.BackColor = Color.Transparent;

            btnSalir.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnSalir.Size = new Size(160, 45);
            btnSalir.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSalir.Width, btnSalir.Height, 20, 20));
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.ForeColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.MouseEnter += (s, ev) => btnSalir.BackColor = Color.IndianRed;
            btnSalir.MouseLeave += (s, ev) => btnSalir.BackColor = Color.Firebrick;

            btnContinuar.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnContinuar.Size = new Size(160, 45);
            btnContinuar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSalir.Width, btnSalir.Height, 20, 20));
            btnContinuar.BackColor = Color.Firebrick;
            btnContinuar.ForeColor = Color.White;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.MouseEnter += (s, ev) => btnSalir.BackColor = Color.IndianRed;
            btnContinuar.MouseLeave += (s, ev) => btnSalir.BackColor = Color.Blue;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var controller = new ClientesController();
            controller.CerrarFormularioCliente(this);
        }
    }
}

