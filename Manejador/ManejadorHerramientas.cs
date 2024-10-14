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
    public class ManejadorHerramientas
    {
        Funciones f = new Funciones();

        public void Guardar(TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion)
        {
            MessageBox.Show(f.Guardar($"CALL p_InsertarHerramientas('{Nombre.Text}', '{Medida.Text}', '{Marca.Text}', '{Descripcion.Text}')"), "!ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int CodigoHerramienta, string dato)
        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar el registro {dato}?", "!ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"DELETE FROM Herramientas WHERE CodigoHerramienta = '{CodigoHerramienta}'");
                MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion, int CodigoHerramienta)
        {
            MessageBox.Show(f.Modificar($"CALL p_ModificarHerramientas({CodigoHerramienta},'{Nombre.Text}','{Medida.Text}','{Marca.Text}','{Descripcion.Text}')"), "!ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tabla.DataSource = f.Mostrar($"SELECT * FROM Herramientas WHERE Nombre LIKE '%{filtro}%'", "Herramientas").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarEliminar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"SELECT * FROM Herramientas WHERE Nombre LIKE '%{filtro}%'", "Herramientas").Tables[0];
            tabla.Columns.Insert(5, Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarEditar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"SELECT * FROM Herramientas WHERE Nombre LIKE '%{filtro}%'", "Herramientas").Tables[0];
            tabla.Columns.Insert(5, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
