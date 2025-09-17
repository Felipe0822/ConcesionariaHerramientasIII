using ConcesionarioHerramientas.Models;
using ConcesionarioHerramientas.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConcesionarioHerramientas.Controllers
{
    internal class MarcasController
    {

     
        public void VerMazda(frmMarcas frm)
        {
            frm.Hide();
            frmMazda frmMazda = new frmMazda();
            frmMazda.ShowDialog();
            frm.Show();
        }
        public void CargarAutosPorMarca(frmMazda frm, int idMarca)
        {
            using (var context = new ConexionDB())
            {
                var lista = context.Automovil
                    .Include(a => a.Marca)
                    .Where(a => a.IdMarca == idMarca)
                    .Select(a => new
                    {
                        Marca = a.Marca.NombreMarca,
                        Modelo = a.Modelo,
                        Precio = a.Precio
                    })
                    .ToList();

                frm.dataGridView1.AutoGenerateColumns = true;
                frm.dataGridView1.DataSource = lista;

                frm.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

    }

}
