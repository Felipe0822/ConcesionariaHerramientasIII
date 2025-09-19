using ConcesionarioHerramientas.Models;
using ConcesionarioHerramientas.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioHerramientas.Controllers
{
    public class ClientesController
    {


        public void SeleccionarAutomovil(Form frm, string marca, string modelo, double precio, int idAutomovil)
        {
            // Abre el formulario de cliente
            frm.Hide();
            frmCliente frmCliente = new frmCliente(this, marca, modelo, precio, idAutomovil);
            frmCliente.ShowDialog();
            frm.Show();
        }

        public void RegistrarCliente(frmCliente frmCliente,string nombre, string cedula, string direccion,
                                     string marca, string modelo, double precio, int idAutomovil,string apellido,string email,string telefono)
        {
            // Abre el formulario de confirmación de venta
            frmCliente.Hide();
            frmVenta frm = new frmVenta(idAutomovil);
            frm.ShowDialog();
            frmCliente.Show();
            using (var db = new ConexionDB())
            {
                // 1. Registrar cliente
                var cliente = new Clientes
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Cedula = cedula,
                    Direccion = direccion,
                    Email = email,
                    Telefono = telefono
                };  
                db.Cliente.Add(cliente);
                db.SaveChanges();
            }

        }

        
    }
}
