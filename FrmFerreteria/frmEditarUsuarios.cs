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
    public partial class frmEditarUsuarios : Form
    {
        ManejadorUsuarios Mu;
        public frmEditarUsuarios()
        {
            InitializeComponent();
            Mu = new ManejadorUsuarios();
            if (frmEditUsuarios.CodigoUsuario > 0)
            {
                txtNombre.Text = frmEditUsuarios.Nombre;
                txtApellidoP.Text = frmEditUsuarios.ApellidoP;
                txtApellidoM.Text = frmEditUsuarios.ApellidoM;
                txtRFC.Text = frmEditUsuarios.Rfc;
                txtUsuario.Text = frmEditUsuarios.Usuario;
                txtContraseña.Text = frmEditUsuarios.Contraseña;
               // dtpFechaNacimiento.Text = frmEditUsuarios.FechaN;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmEditarHerramientas.CodigoHerramienta > 0)
            {
                Mu.Modificar(txtNombre, txtApellidoP, txtApellidoM, dtpFechaNacimiento, txtRFC, txtUsuario, txtContraseña, frmEditUsuarios.CodigoUsuario);

                Close();
            }
            else
                Mu.GuardarUsuario(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpFechaNacimiento.MinDate, txtRFC.Text, txtUsuario.Text, txtContraseña.Text);
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
