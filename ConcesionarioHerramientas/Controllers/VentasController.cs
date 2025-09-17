using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioHerramientas.Views;

namespace ConcesionarioHerramientas.Controllers
{
    public class VentasController
    {


        public void SeleccionarAutomovil(frmMazda frm, string marca, string modelo, double precio, int idAutomovil)
        {
            // Abre el formulario de cliente
            frm.Hide();
            frmCliente frmCliente = new frmCliente(this, marca, modelo, precio, idAutomovil);
            frmCliente.ShowDialog();
            frm.Show();
        }

        public void RegistrarCliente(string nombre, string cedula, string direccion,
                                     string marca, string modelo, double precio, int idAutomovil)
        {
            // Abre el formulario de confirmación de venta
            frmVenta frm = new frmVenta(this, nombre, cedula, direccion, marca, modelo, precio, idAutomovil);
            frm.ShowDialog();
        }
    }
}
