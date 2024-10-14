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
    public partial class frmMenu : Form
    {
        private DataTable permisos;

        public frmMenu(DataTable permisos)
        {
            InitializeComponent();
            this.permisos = permisos;
            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            foreach (DataRow row in permisos.Rows)
            {
                string nombreFormulario = row["NombreFormulario"].ToString();
                bool lectura = Convert.ToBoolean(row["Lectura"]);

               
                switch (nombreFormulario)
                {
                    case "Usuarios":
                        btnUsuarios.Enabled = lectura; 
                        break;
                    case "Herramientas":
                        btnHerramientas.Enabled = lectura; 
                        break;
                    case "Producto":
                        btnProductos.Enabled = lectura; 
                        break;
                }
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (btnUsuarios.Enabled)
            {
                frmUsuarios usuariosForm = new frmUsuarios(permisos); 
                usuariosForm.Show();
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a Usuarios.");
            }

        }

        
    }
}
