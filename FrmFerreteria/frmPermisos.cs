using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace FrmFerreteria
{
    public partial class frmPermisos : Form
    {
        ManejadorUsuarios mu;
        public frmPermisos()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            CargarUsuarios();
            CargarFormularios();
        }

        private void dtgvPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dtgvPermisos.Rows[e.RowIndex];
                
            }
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dtgvUsuarios.Rows[e.RowIndex];
            }

        }

        private void btnGuardarPermisos_Click(object sender, EventArgs e)
        {
            
            if (dtgvUsuarios.SelectedRows.Count > 0 && dtgvPermisos.SelectedRows.Count > 0)
            {
                
                try
                {
                    int idUsuario = Convert.ToInt32(dtgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);
                    int idFormulario = Convert.ToInt32(dtgvPermisos.SelectedRows[0].Cells["IdFormulario"].Value);

                 
                    bool permisoLectura = cmbLectura.SelectedItem.ToString() == "Si";
                    bool permisoEscritura = cmbEscritura.SelectedItem.ToString() == "Si";
                    bool permisoEliminacion = cmbEliminacion.SelectedItem.ToString() == "Si";
                    bool permisoActualizacion = cmbActualizacion.SelectedItem.ToString() == "Si";

                  
                    mu.GuardarPermisosUsuario(idUsuario, idFormulario, permisoLectura, permisoEscritura, permisoEliminacion, permisoActualizacion);

                    MessageBox.Show("Permisos guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos seleccionados: " + ex.Message);
                }
            }
            else
            {
             
                MessageBox.Show("Debe seleccionar un usuario y un formulario.");
            }
        }
        private void CargarUsuarios()
        {
            DataTable dtUsuarios = mu.ObtenerUsuarios2();
            dtgvUsuarios.DataSource = dtUsuarios;
            dtgvUsuarios.Columns["IdUsuario"].Visible = false; 
        }

        private void CargarFormularios()
        {
            DataTable dtFormularios = mu.ObtenerFormularios2();
            dtgvPermisos.DataSource = dtFormularios;
            dtgvPermisos.Columns["IdFormulario"].Visible = false;
        }

    }
}
    