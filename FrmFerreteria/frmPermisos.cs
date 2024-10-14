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
            if (e.RowIndex >= 0) // Asegura que se hace clic en una fila válida
            {
                DataGridViewRow row = dtgvPermisos.Rows[e.RowIndex];
                // Aquí puedes hacer algo adicional si lo necesitas, como resaltar la fila seleccionada
            }
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que se hace clic en una fila válida
            {
                DataGridViewRow row = dtgvUsuarios.Rows[e.RowIndex];
                // Aquí puedes hacer algo adicional si lo necesitas, como resaltar la fila seleccionada
            }
        }

        private void btnGuardarPermisos_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en dtgvUsuarios y dtgvFormularios
            if (dtgvUsuarios.SelectedRows.Count > 0 && dtgvPermisos.SelectedRows.Count > 0)
            {
                // Intentar obtener el ID del usuario y del formulario seleccionados
                try
                {
                    int idUsuario = Convert.ToInt32(dtgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);
                    int idFormulario = Convert.ToInt32(dtgvPermisos.SelectedRows[0].Cells["IdFormulario"].Value);

                    // Obtener los valores de los ComboBox (Sí es true, No es false)
                    bool permisoLectura = cmbLectura.SelectedItem.ToString() == "Sí";
                    bool permisoEscritura = cmbEscritura.SelectedItem.ToString() == "Sí";
                    bool permisoEliminacion = cmbEliminacion.SelectedItem.ToString() == "Sí";
                    bool permisoActualizacion = cmbActualizacion.SelectedItem.ToString() == "Sí";

                    // Llamar al método para guardar los permisos
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
                // Mostrar mensaje si no hay fila seleccionada
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
    