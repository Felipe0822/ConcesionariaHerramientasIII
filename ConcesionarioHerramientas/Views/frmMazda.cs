using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConcesionarioHerramientas.Controllers;
using ConcesionarioHerramientas.Models;

namespace ConcesionarioHerramientas.Views
{
    public partial class frmMazda : Form
    {
        public frmMazda()
        {
            InitializeComponent();
        }

        private void frmMazda_Load(object sender, EventArgs e)
        {
            var controller = new MarcasController();
            controller.CargarAutosPorMarca(this, 1);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Fondo
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;

            // Cabecera
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternadas
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Ajuste columnas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string marca = dataGridView1.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                string modelo = dataGridView1.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
                double precio = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value);
                int idAutomovil = 1; // ← aquí deberías tomar el ID real de la fila

                var controller = new VentasController();
                controller.SeleccionarAutomovil(this, marca, modelo, precio, idAutomovil);
            }
        }
    }
}
