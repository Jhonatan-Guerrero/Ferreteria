using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace FrmFerreteria
{
    public partial class frmEditUsuarios : Form
    {
        ManejadorUsuarios mu;
        int fila = 0, columna = 0;
        public static string Nombre = "", ApellidoP = "", ApellidoM = "", FechaN = "", Rfc = "", Usuario = "", Contraseña = "";
        public static int CodigoUsuario = 0;
        public frmEditUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            

        }

        private void dtgvEliminarU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 8:
                    {
                        CodigoUsuario = int.Parse(dtgvModificarU.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dtgvModificarU.Rows[fila].Cells[1].Value.ToString();
                        ApellidoP = dtgvModificarU.Rows[fila].Cells[2].Value.ToString();
                        ApellidoM = dtgvModificarU.Rows[fila].Cells[3].Value.ToString();
                        FechaN = dtgvModificarU.Rows[fila].Cells[4].Value.ToString();
                        Rfc = dtgvModificarU.Rows[fila].Cells[5].Value.ToString();
                        Usuario = dtgvModificarU.Rows[fila].Cells[6].Value.ToString();
                        Contraseña = dtgvModificarU.Rows[fila].Cells[7].Value.ToString();



                        frmEditarUsuarios ag = new frmEditarUsuarios();
                        ag.ShowDialog();
                        dtgvModificarU.Visible = true;
                    }
                    break;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtgvModificarU.Visible = true;
            mu.Mostrar(dtgvModificarU,textBox1.Text);
            
        }

        private void dtgvEliminarU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
