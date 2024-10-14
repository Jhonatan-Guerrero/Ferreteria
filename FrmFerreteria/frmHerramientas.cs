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
    public partial class frmHerramientas : Form
    {
        private DataTable permisos;
        ManejadorHerramientas mh;
        public frmHerramientas(DataTable permisosUsuario)
        {
            
            InitializeComponent();
            permisos = permisosUsuario;
            ConfigurarPermisos();
            mh = new ManejadorHerramientas();
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

                    if (nombreFormulario == "Herramientas")
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

           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarHerramientas ah = new AgregarHerramientas();
            ah.Show();
        }

        private void txtHerramientas_TextChanged(object sender, EventArgs e)
        {
            dtgvHerramientas.Visible = true;
            mh.Mostrar(dtgvHerramientas, txtHerramientas.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarHerraminetas eh = new frmEliminarHerraminetas();
            eh.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarHerramientas eh = new frmEditarHerramientas();
            eh.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
