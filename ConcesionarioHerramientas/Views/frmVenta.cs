using ConcesionarioHerramientas.Controllers;
using ConcesionarioHerramientas.Models;
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
    public partial class frmVenta : Form
    {

        private int _idAutomovil;
        public frmVenta(int idAutomovil)
        {
            InitializeComponent();
            _idAutomovil = idAutomovil;

        }


        private void frmVenta_Load(object sender, EventArgs e)
        {
            using (var context = new ConexionDB())
            {
                var auto = context.Automovil.FirstOrDefault(a => a.IdAutomovil == _idAutomovil);

                if (auto != null)
                {
                    label4.Text = auto.Modelo;
                }
            }
        }

        
    }
}
