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

        public void VerPorche(frmMarcas frp)
        {
            frp.Hide();
            frmPorche frmPorche = new frmPorche();
            frmPorche.ShowDialog();
            frp.Show();
        }
    
        public void CargarAutosPorMarca(Form frm, int idMarca)
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

                var grid = frm.Controls.OfType<DataGridView>().FirstOrDefault();
                if (grid != null) 
                {
                    grid.AutoGenerateColumns = true;
                    grid.DataSource = lista;
                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Ocultar la columna del ID si no quieres mostrarla
                    if (grid.Columns["IdAutomovil"] != null)
                        grid.Columns["IdAutomovil"].Visible = false;
                }


            }
        }

        
    }

}
