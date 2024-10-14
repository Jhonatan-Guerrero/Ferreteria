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
    public partial class frmEditarHerramientas : Form
    {
        ManejadorHerramientas mh;
        int fila = 0, columna = 0;
        public static string Nombre = "", Descripcion = "", Marca = "", Medida = "";
        public static int CodigoHerramienta = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public frmEditarHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
        }

        private void txtHerramientas_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            mh.MostrarEditar(dataGridView1, txtHerramientas.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 5: 
                    {
                        CodigoHerramienta = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                        Medida = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                        Descripcion = dataGridView1.Rows[fila].Cells[4].Value.ToString();
                        Marca = dataGridView1.Rows[fila].Cells[5].Value.ToString();

                        frmEditarHerramientas2 ag = new frmEditarHerramientas2(); 
                        ag.ShowDialog();
                        dataGridView1.Visible = true; 
                    }
                    break;
            }
        }
    }
}
