using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioHerramientas.Views;
using ConcesionarioHerramientas.Models;

namespace ConcesionarioHerramientas.Controllers
{
    class MenuController
    {

        public void AbrirFormularioMarcas(frmMenu menu) 
        {
            menu.Hide();
            frmMarcas frmMarcas = new frmMarcas();
            frmMarcas.ShowDialog();
            menu.Show();
        }

        public void CerrarFormularioMenu(frmMenu menu)
        {
            menu.Close();
        }
        
    }
}
