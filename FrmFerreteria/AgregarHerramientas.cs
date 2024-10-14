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
    public partial class AgregarHerramientas : Form
    {
        ManejadorHerramientas mh;
        public AgregarHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mh.Guardar(txtNombre, txtMedida, txtMarca, txtDescripcion);
        }
    }
}
