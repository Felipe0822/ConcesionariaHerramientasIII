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
    public class MarcasController
    {

     
        public void VerMazda(frmMarcas frm)
        {
            frm.Hide();
            frmMazda frmMazda = new frmMazda();
            frmMazda.ShowDialog();
            frm.Show();
        }

        public void VerPorsche(frmMarcas frm)
        {
            frm.Hide();
            frmPorsche frmPorche = new frmPorsche();
            frmPorche.ShowDialog();
            frm.Show();
        }
        public void VerRenault(frmMarcas frm)
        {
            frm.Hide();
            frmRenault frmRenault = new frmRenault();
            frmRenault.ShowDialog();
            frm.Show();
        }

        public void VerChevrolet(frmMarcas frm)
        {
            frm.Hide();
            frmChevrolet frmChevrolet = new frmChevrolet();
            frmChevrolet.ShowDialog();
            frm.Show();
        }

        public void CerrarFormulario(Form frm)
        {
            frm.Close();
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
                        IdAutomovil = a.IdAutomovil,
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
                    grid.Columns["IdAutomovil"].Visible = false;


                }


            }
        }

        
    }

}
