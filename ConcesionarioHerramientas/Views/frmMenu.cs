using ConcesionarioHerramientas.Controllers;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace ConcesionarioHerramientas
{
    public partial class frmMenu : Form
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


        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;
            
            btnVerMarcas.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnVerMarcas.Size = new Size(160, 45);
            btnVerMarcas.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVerMarcas.Width, btnVerMarcas.Height, 20, 20));
            btnVerMarcas.BackColor = Color.SteelBlue;
            btnVerMarcas.ForeColor = Color.White;
            btnVerMarcas.FlatStyle = FlatStyle.Flat;
            btnVerMarcas.FlatAppearance.BorderSize = 0;
            btnVerMarcas.MouseEnter += (s, ev) => btnVerMarcas.BackColor = Color.DodgerBlue;
            btnVerMarcas.MouseLeave += (s, ev) => btnVerMarcas.BackColor = Color.SteelBlue;

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

            // Evitar error si el formulario está minimizado o el rectángulo es inválido
            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                           Color.FromArgb(20, 30, 60),   // Azul oscuro
                                                                           Color.FromArgb(120, 170, 255), // Azul claro
                                                                           90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
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
