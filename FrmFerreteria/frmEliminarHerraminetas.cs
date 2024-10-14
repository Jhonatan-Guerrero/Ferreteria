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
    public partial class frmEliminarHerraminetas : Form
    {
        ManejadorHerramientas mh;
        int fila = 0, columna = 0;
        public static string Nombre = "", Descripcion = "";
        public static int CodigoHerramienta = 0;
        public frmEliminarHerraminetas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgvHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 5:
                    {
                        CodigoHerramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString()); 
                        mh.Borrar(CodigoHerramienta, dtgvHerramientas.Rows[fila].Cells[1].Value.ToString()); 
                        dtgvHerramientas.Visible = true; 
                    }
                    break;
            }
        }

        private void txtHerramientas_TextChanged(object sender, EventArgs e)
        {
            mh.MostrarEliminar(dtgvHerramientas, txtHerramientas.Text); 

        }
    }
}
