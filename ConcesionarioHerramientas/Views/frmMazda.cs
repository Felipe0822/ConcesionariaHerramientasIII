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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMazda_Load(object sender, EventArgs e)
        {
            var controller = new MarcasController();
            controller.CargarAutosPorMarca(this, 1);
        }
    }
}
