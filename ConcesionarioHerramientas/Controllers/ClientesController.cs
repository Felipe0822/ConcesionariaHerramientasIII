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


        public void SeleccionarAutomovil(Form frm, string marca, string modelo, decimal precio, int idAutomovil)
        {
            // Abre el formulario de cliente
            frm.Hide();
            frmCliente frmCliente = new frmCliente(this, marca, modelo, precio, idAutomovil);
            frmCliente.ShowDialog();
            frm.Show();
        }

        public void RegistrarCliente(string nombre, string cedula, string direccion,
                               string marca, string modelo, decimal precio, int idAutomovil,
                               string email, string apellido, string telefono,int idCliente)
        {
            try
            {
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

                    idCliente = cliente.IdCliente; // EF devuelve el identity asignado

                    MessageBox.Show("Cliente guardado");

                    // 2. Registrar la venta asociada al cliente y automovil
                    var venta = new Ventas
                    {
                        Fecha = DateTime.Now,
                        Total = precio,
                        IdCliente = idCliente,       // FK Cliente
                        IdAutomovil = idAutomovil    // FK Automóvil
                    };

                    db.Venta.Add(venta);
                    db.SaveChanges();

                    MessageBox.Show("Venta registrada exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en RegistrarCliente: {ex.Message}");
            }
        }

        public void CerrarFormularioCliente(frmCliente frm)
        {
            frm.Close();
            
        }


    }
}
