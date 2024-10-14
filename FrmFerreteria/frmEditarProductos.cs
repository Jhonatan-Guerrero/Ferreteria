using System;
using System.Collections;
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
    public partial class frmEditarProductos : Form
    {
        ManejadorProductos mp;
        int fila = 0, columna = 0;
        public static string Nombre = "", Descripcion = "", Marca="";
        public static int Codigo = 0;

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {
            dtgvProductos.Visible = true;
            mp.MostrarEditar(dtgvProductos, txtProductos.Text);
        }

        public frmEditarProductos()
        {
            InitializeComponent();
            mp= new ManejadorProductos();
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
              
                case 4:
                    {
                        Codigo = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dtgvProductos.Rows[fila].Cells[1].Value.ToString();
                        Descripcion = dtgvProductos.Rows[fila].Cells[2].Value.ToString();
                        Marca = dtgvProductos.Rows[fila].Cells[3].Value.ToString();
                        frmEditarProductos2 ag = new frmEditarProductos2();
                        ag.ShowDialog();
                        dtgvProductos.Visible = true;
                    }
                    break;
            }
        }
    }
}
