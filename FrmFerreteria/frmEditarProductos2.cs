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
    public partial class frmEditarProductos2 : Form
    {
        ManejadorProductos mp;
        public frmEditarProductos2()
        {
            InitializeComponent();
            mp =  new ManejadorProductos();
            if (frmEditarProductos.Codigo > 0)
            {
                txtNombre.Text = frmEditarProductos.Nombre;
                txtDescripcion.Text = frmEditarProductos.Descripcion;
                txtMarca.Text = frmEditarProductos.Marca;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmEditarProductos.Codigo > 0)
            {
                mp.Modificar(txtNombre, txtDescripcion, txtMarca, frmEditarProductos.Codigo);

                Close();
            }
            else
                mp.Guardar(txtNombre, txtDescripcion, txtMarca);
            Close();
        }
    }
}
