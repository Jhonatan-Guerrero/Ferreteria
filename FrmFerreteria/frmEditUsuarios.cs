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
    public partial class frmEditUsuarios : Form
    {
        ManejadorUsuarios mu;
        public frmEditUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }

        private void dtgvEliminarU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mu.Mostrar(dtgvEliminarU,textBox1.Text);
        }
    }
}
