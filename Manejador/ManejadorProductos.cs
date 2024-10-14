using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorProductos
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox Nombre, TextBox Descripcion, TextBox Marca)
        {
            MessageBox.Show(f.Guardar($"CALL p_InsertarProductos('{Nombre.Text}', '{Descripcion.Text}', '{Marca.Text}')"), "!ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int CodigoBarras, string dato)
        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar el registro {dato}?", "!ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"DELETE FROM Productos WHERE CodigoBarras = '{CodigoBarras}'");
                MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void Modificar(TextBox Titulo, TextBox Descripcion, TextBox Marca, int IdProductos)
        {
            MessageBox.Show(f.Modificar($"CALL p_ModificarProductos({IdProductos},'{Titulo.Text}','{Descripcion.Text}','{Marca.Text}')"), "!ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        DataGridViewButtonColumn Boton(string t, Color co)
        {
            DataGridViewButtonColumn bo = new DataGridViewButtonColumn();
            bo.Text = t;
            bo.UseColumnTextForButtonValue = true;
            bo.FlatStyle = FlatStyle.Popup;
            bo.DefaultCellStyle.BackColor = co;
            bo.DefaultCellStyle.ForeColor = Color.White;
            return bo;
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"SELECT * FROM Productos WHERE Nombre LIKE '%{filtro}%'", "Productos").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
        public void MostrarEliminar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"SELECT * FROM Productos WHERE Nombre LIKE '%{filtro}%'", "Productos").Tables[0];
            tabla.Columns.Insert(4, Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
        public void MostrarEditar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"SELECT * FROM Productos WHERE Nombre LIKE '%{filtro}%'", "Productos").Tables[0];
            tabla.Columns.Insert(4, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
