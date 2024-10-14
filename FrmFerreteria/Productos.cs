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
    public partial class Productos : Form
    {
        private DataTable permisos;
        ManejadorProductos mp;

        public Productos(DataTable permisosUsuario)
        {
            InitializeComponent();
            permisos = permisosUsuario;
            ConfigurarPermisos();
            mp = new ManejadorProductos();
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


                    if (nombreFormulario == "Producto")
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
            frmAgregarProductos ap = new frmAgregarProductos();
            ap.Show();
        }

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {
            dtgvProductos.Visible = true;
            mp.Mostrar(dtgvProductos, txtProductos.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarProducto ep = new frmEliminarProducto();
            ep.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarProductos ep = new frmEditarProductos();
            ep.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
