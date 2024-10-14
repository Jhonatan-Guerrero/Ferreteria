using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmFerreteria
{
    public partial class frmUsuarios : Form
    {

        private DataTable permisos;
        private ManejadorUsuarios manejadorUsuarios = new ManejadorUsuarios();
        public frmUsuarios(DataTable permisosUsuario)
        {
            InitializeComponent();
            permisos = permisosUsuario;
            ConfigurarPermisos();
        }
        private void ConfigurarPermisos()
        {
           
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;

            
            if (permisos != null && permisos.Rows.Count > 0)
            {
                foreach (DataRow row in permisos.Rows)
                {
                    string nombreFormulario = row["NombreFormulario"].ToString();

                   
                    if (nombreFormulario == "Usuarios")
                    {
                    
                        bool escritura = Convert.ToBoolean(row["Escritura"]);
                        bool eliminacion = Convert.ToBoolean(row["Eliminacion"]);
                        bool actualizacion = Convert.ToBoolean(row["Actualizacion"]);
                        btnAgregar.Enabled = escritura;  
                        btnEliminar.Enabled = eliminacion;
                        btnEditar.Enabled = actualizacion; 
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han asignado permisos válidos.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarUsuarios agregarForm = new frmAgregarUsuarios();
            agregarForm.Show();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEditUsuarios editarForm = new frmEditUsuarios();
            editarForm.Show();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditUsuarios editarForm = new frmEditUsuarios();
            editarForm.Show();
        }
    }  
}

