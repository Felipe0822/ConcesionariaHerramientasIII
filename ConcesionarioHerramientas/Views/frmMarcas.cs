using ConcesionarioHerramientas.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcesionarioHerramientas.Views
{
    public partial class frmMarcas : Form
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

        public frmMarcas()
        {
            InitializeComponent();
        }



        private void frmMarcas_Load(object sender, EventArgs e)
        {
            label2.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            label2.ForeColor = Color.White;
            label2.BackColor = Color.Transparent;

            btnMazda.BackColor = Color.BlueViolet;
            btnMazda.ForeColor = Color.White;
            btnMazda.FlatStyle = FlatStyle.Flat;
            btnMazda.FlatAppearance.BorderSize = 0;

            btoPorche.BackColor = Color.BlueViolet;
            btoPorche.ForeColor = Color.White;
            btoPorche.FlatStyle = FlatStyle.Flat;
            btoPorche.FlatAppearance.BorderSize = 0;

            btnChevrolet.BackColor = Color.BlueViolet;
            btnChevrolet.ForeColor = Color.White;
            btnChevrolet.FlatStyle = FlatStyle.Flat;
            btnChevrolet.FlatAppearance.BorderSize = 0;

            btnRenault.BackColor = Color.BlueViolet;
            btnRenault.ForeColor = Color.White;
            btnRenault.FlatStyle = FlatStyle.Flat;
            btnRenault.FlatAppearance.BorderSize = 0;

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



        private void btnMazda_Click(object sender, EventArgs e)
        {
            var controllerMarcas = new MarcasController();
            controllerMarcas.VerMazda(this);


        }

        private void btoPorche_Click(object sender, EventArgs e)
        {
            var controllerMarcas = new MarcasController();
            controllerMarcas.VerPorsche(this);
        }

        private void btnChevrolet_Click(object sender, EventArgs e)
        {
            var controller = new MarcasController();
            controller.VerChevrolet(this);
        }

        private void btnRenault_Click(object sender, EventArgs e)
        {
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
