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
            btoPorche.BackColor = Color.DarkMagenta;
            btoPorche.ForeColor = Color.White;
            btoPorche.FlatStyle = FlatStyle.Flat;
            btoPorche.FlatAppearance.BorderSize = 0;
            btnChevrolet.BackColor = Color.DarkMagenta;
            btnChevrolet.ForeColor = Color.White;
            btnChevrolet.FlatStyle = FlatStyle.Flat;
            btnChevrolet.FlatAppearance.BorderSize = 0;
            btnRenault.BackColor = Color.DarkMagenta;
            btnRenault.ForeColor = Color.White;
            btnRenault.FlatStyle = FlatStyle.Flat;
            btnRenault.FlatAppearance.BorderSize = 0;
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.ForeColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;

        }


        private void btnMazda_Click(object sender, EventArgs e)
        {
            btnMazda.BackColor = Color.RoyalBlue;
            var controllerMarcas = new MarcasController();
            controllerMarcas.VerMazda(this);


        }

        private void btoPorche_Click(object sender, EventArgs e)
        {
            btnMazda.BackColor = Color.RoyalBlue;
            var controllerMarcas = new MarcasController();
            controllerMarcas.VerPorsche(this);
        }

        private void btnChevrolet_Click(object sender, EventArgs e)
        {
            btnMazda.BackColor = Color.RoyalBlue;
            var controller = new MarcasController();
            controller.VerChevrolet(this);
        }

        private void btnRenault_Click(object sender, EventArgs e)
        {
            btnMazda.BackColor = Color.RoyalBlue;
            var controller = new MarcasController();
            controller.VerRenault(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var controller = new MarcasController();
            controller.CerrarFormulario(this);
        }
    }
}
