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
    public partial class frmAgregarProductos : Form
    {
        ManejadorProductos mp;
        public frmAgregarProductos()
        {
            InitializeComponent();
            mp= new ManejadorProductos();   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(txtNombre,txtDescripcion,txtMarca); 
            Close(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
