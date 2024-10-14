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
    public partial class frmEliminarProducto : Form
    {
        ManejadorProductos mp;
        int fila = 0, columna = 0;
        public static string  Nombre = "", Descripcion = "";
        public static int Codigo = 0;
        public frmEliminarProducto()
        {
            InitializeComponent();
            mp= new ManejadorProductos();
        }

     

        private void dtgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 4:
                    {
                        Codigo = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        mp.Borrar(Codigo, dtgvProductos.Rows[fila].Cells[1].Value.ToString()); ;
                        dtgvProductos.Visible = true;
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {
            mp.MostrarEliminar(dtgvProductos,txtProductos.Text);
        }
    }
}
