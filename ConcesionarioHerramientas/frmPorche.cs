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

namespace ConcesionarioHerramientas
{
    public partial class frmPorche : Form
    {
        public frmPorche()
        {
            InitializeComponent();
        }

        private void frmPorche_Load(object sender, EventArgs e)
        {
            var controller = new MarcasController();
            controller.CargarAutosPorMarca(this,2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string marca = dataGridView1.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                string modelo = dataGridView1.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
                double precio = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value);
                int idAutomovil = 2; // ← aquí deberías tomar el ID real de la fila

                var controller = new ClientesController();
                controller.SeleccionarAutomovil(this, marca, modelo, precio, idAutomovil);
            }
        }
    }
}
