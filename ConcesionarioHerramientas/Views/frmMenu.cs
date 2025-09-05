using ConcesionarioHerramientas.Controllers;

namespace ConcesionarioHerramientas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            label1.ForeColor = Color.Black;

            btnSalir.BackColor = Color.Firebrick;
            btnSalir.ForeColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;

            btnVerMarcas.BackColor = Color.SteelBlue;
            btnVerMarcas.ForeColor = Color.White;
            btnVerMarcas.FlatStyle = FlatStyle.Flat;
            btnVerMarcas.FlatAppearance.BorderSize = 0;
        }

        private void btnVerMarcas_Click(object sender, EventArgs e)
        {
            btnVerMarcas.BackColor = Color.RoyalBlue;
            var controller = new MenuController();
            controller.AbrirFormularioMarcas(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.DarkRed;
            var controller = new MenuController();
            controller.CerrarFormularioMenu(this );
        }

      

    }
}
