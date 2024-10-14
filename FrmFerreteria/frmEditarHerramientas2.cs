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
    public partial class frmEditarHerramientas2 : Form
    {
        ManejadorHerramientas mh;
        public frmEditarHerramientas2()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
            if (frmEditarHerramientas.CodigoHerramienta > 0) 
            {
                txtNombre.Text = frmEditarHerramientas.Nombre; 
                txtMedida.Text = frmEditarHerramientas.Medida; 
                txtMarca.Text = frmEditarHerramientas.Marca; 
                txtDescripcion.Text = frmEditarHerramientas.Descripcion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmEditarHerramientas.CodigoHerramienta > 0) 
            {
                mh.Modificar(txtNombre,txtMedida, txtMarca, txtDescripcion, frmEditarHerramientas.CodigoHerramienta);

                Close();
            }
            else
                mh.Guardar(txtNombre, txtMedida, txtMarca, txtDescripcion); 
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
