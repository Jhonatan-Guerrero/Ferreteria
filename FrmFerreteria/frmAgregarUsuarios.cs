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
    public partial class frmAgregarUsuarios : Form
    {
        private int idUsuario;
        private ManejadorUsuarios manejadorUsuarios;
        private DataTable usuarios;
        private DataTable dtFormularios;


        public frmAgregarUsuarios()
        {
            InitializeComponent();
            
            manejadorUsuarios = new ManejadorUsuarios();
            
        }
   

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
            string nombre = txtNombre.Text;
            string apellidoP = txtApellidoP.Text;
            string apellidoM = txtApellidoM.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string rfc = txtRFC.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

           
            try
            {
                manejadorUsuarios.GuardarUsuario(nombre, apellidoP, apellidoM, fechaNacimiento, rfc, usuario, contraseña);
                MessageBox.Show("Usuario guardado exitosamente.");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el usuario: {ex.Message}");
            }

        }

        private void btnGuardarPermisos_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAgregarPermisos_Click(object sender, EventArgs e)
        {
            frmPermisos p = new frmPermisos();
            p.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
  
 
}
