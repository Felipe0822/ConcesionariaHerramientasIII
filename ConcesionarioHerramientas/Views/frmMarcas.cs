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
    public partial class frmMarcas : Form
    {

        public frmMarcas()
        {
            InitializeComponent();
        }

      

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            label1.ForeColor = Color.Black;

            btnMazda.BackColor = Color.DarkMagenta;
            btnMazda.ForeColor = Color.White;
            btnMazda.FlatStyle = FlatStyle.Flat;
            btnMazda.FlatAppearance.BorderSize = 0;
        }


        private void btnMazda_Click(object sender, EventArgs e)
        {
            btnMazda.BackColor = Color.RoyalBlue;

            var controllerMarcas = new MarcasController();
            controllerMarcas.VerMazda(this);


        }
    }
}
