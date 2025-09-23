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
    public partial class frmRenault : Form
    {
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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var controller = new MarcasController();
            controller.CerrarFormulario(this);
        }
    }
}
