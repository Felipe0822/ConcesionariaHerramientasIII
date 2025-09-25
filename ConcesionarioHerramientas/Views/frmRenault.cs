using ConcesionarioHerramientas.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcesionarioHerramientas.Views
{
    public partial class frmRenault : Form
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // width of ellipse
    int nHeightEllipse // height of ellipse
     );
        public frmRenault()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string marca = dataGridView1.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            string modelo = dataGridView1.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            decimal precio = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value);
            int idAutomovil = 4; // ← aquí deberías tomar el ID real de la fila

            var controller = new ClientesController();
            controller.SeleccionarAutomovil(this, marca, modelo, precio, idAutomovil);
        }

        private void frmRenault_Load(object sender, EventArgs e)
        {
            var controller = new MarcasController();
            controller.CargarAutosPorMarca(this, 4);

            dataGridView1.Width = this.ClientSize.Width - 100;
            dataGridView1.Height = this.ClientSize.Height - 200;
            dataGridView1.Location = new Point(50, 150);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;

            // Estilo filas
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            btnSalir.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnSalir.Size = new Size(160, 45);
            btnSalir.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSalir.Width, btnSalir.Height, 20, 20));
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.ForeColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.MouseEnter += (s, ev) => btnSalir.BackColor = Color.IndianRed;
            btnSalir.MouseLeave += (s, ev) => btnSalir.BackColor = Color.Firebrick;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.White,         // Arriba
                Color.SteelBlue,     // Abajo
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.DarkRed;
            var controller = new MarcasController();
            controller.CerrarFormulario(this);
        }
    }
}
