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
    public partial class Form1 : Form
    {
        ManejadorUsuarios manejador = new ManejadorUsuarios();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ManejadorUsuarios manejador = new ManejadorUsuarios();
            var (usuario, permisos) = manejador.Login(txtUsuario.Text, txtContraseña.Text);
            if (usuario != null)
            {
                this.Hide(); 
                frmMenu menu = new frmMenu(permisos); 
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
