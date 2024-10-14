using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorUsuarios
    {
        Funciones funciones = new Funciones();
        public DataTable ObtenerUsuarios()
        {
            string query = "SELECT IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno FROM Usuarios";
            DataSet dsUsuarios = funciones.Mostrar(query, "Usuarios");
            return dsUsuarios.Tables.Count > 0 ? dsUsuarios.Tables[0] : null;
        }
        public (DataTable usuario, DataTable permisos) Login(string usuario, string contraseña)
        {
            string contraseñaCifrada = CifrarContraseña(contraseña);
            string queryLogin = $"CALL LoginUsuario('{usuario}', '{contraseñaCifrada}');";
            DataSet dsLogin = funciones.Mostrar(queryLogin, "Usuarios");

            DataTable dtPermisos = null;

            if (dsLogin.Tables.Count > 0 && dsLogin.Tables[0].Rows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dsLogin.Tables[0].Rows[0]["IdUsuario"]);

                string queryPermisos = $"CALL ObtenerPermisosUsuario({idUsuario});";
                DataSet dsPermisos = funciones.Mostrar(queryPermisos, "PermisosUsuario");
                dtPermisos = dsPermisos.Tables.Count > 0 ? dsPermisos.Tables[0] : null;
            }

            return (dsLogin.Tables.Count > 0 ? dsLogin.Tables[0] : null, dtPermisos);
        }

        private string CifrarContraseña(string contraseña)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(contraseña);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public void GuardarUsuario(string nombre, string apellidoP, string apellidoM, DateTime fechaNacimiento, string rfc, string usuario, string contraseña)
        {
            string query = $"CALL p_InsertarUsuario('{nombre}', '{apellidoP}', '{apellidoM}', '{fechaNacimiento:yyyy-MM-dd}', '{rfc}', '{usuario}', SHA1('{contraseña}'));";
            funciones.Guardar(query);
        }
        public DataTable ObtenerFormularios()
        {
            string query = "SELECT IdFormulario, NombreFormulario FROM Formularios";
            return funciones.Mostrar(query, "Formularios").Tables[0];
        }

        public void GuardarPermisos(int idUsuario, int idFormulario, bool lectura, bool escritura, bool eliminacion, bool actualizacion)
        {
            string query = $"CALL p_GuardarPermisos({idUsuario}, {idFormulario}, {lectura}, {escritura}, {eliminacion}, {actualizacion});";
            funciones.Guardar(query);
        }
        public DataTable ObtenerUsuarios2()
        {
            string query = "SELECT IdUsuario, Nombre, ApellidoP, ApellidoM, Usuario FROM Usuarios;";
            DataSet dsUsuarios = funciones.Mostrar(query, "Usuarios");
            return dsUsuarios.Tables[0];
        }
        public DataTable ObtenerFormularios2()
        {
            string query = "SELECT IdFormulario, Nombre FROM Formularios;";
            DataSet dsFormularios = funciones.Mostrar(query, "Formularios");
            return dsFormularios.Tables[0];
        }
        public void GuardarPermisosUsuario(int IdUsuario, int IdFormulario, bool lectura, bool escritura, bool eliminacion, bool actualizacion)
        {
            string query = $"CALL GuardarPermisosUsuario({IdUsuario}, {IdFormulario}, {lectura}, {escritura}, {eliminacion}, {actualizacion});";
            funciones.Guardar(query);
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
            tabla.DataSource = funciones.Mostrar($"SELECT u.IdUsuario, u.Nombre AS NombreUsuario, u.ApellidoP AS ApellidoPaterno, u.ApellidoM AS ApellidoMaterno, f.Nombre AS Formulario, CASE WHEN pu.Lectura = 1 THEN 'Sí' ELSE 'No' END AS Lectura, CASE WHEN pu.Escritura = 1 THEN 'Si' ELSE 'No' END AS Escritura, CASE WHEN pu.Eliminacion = 1 THEN 'Si' ELSE 'No' END AS Eliminacion, CASE WHEN pu.Actualizacion = 1 THEN 'Si' ELSE 'No' END AS Actualizacion FROM Usuarios u JOIN PermisosUsuario pu ON u.IdUsuario = pu.IdUsuario JOIN Formularios f ON pu.IdFormulario = f.IdFormulario WHERE u.Nombre LIKE '%{filtro}%';", "PermisosUsuario").Tables[0];
            tabla.Columns.Insert(8, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }


        public void Modificar(TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, DateTimePicker FechaN, TextBox Rfc, TextBox Usuario, TextBox Contraseña, int IdUsuario)
        {
            MessageBox.Show(funciones.Modificar($"CALL p_ActualizarUsuario({IdUsuario},'{Nombre.Text}','{ApellidoP.Text}','{ApellidoM.Text}', '{FechaN.Text}', '{Rfc.Text}', '{Usuario.Text}', '{Contraseña.Text}')"), "!ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void Eliminar(int Idusuario, string dato)
        {
            
                DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar el registro {dato}?", "!ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    funciones.Borrar($"DELETE FROM PermisosUsuario WHERE IdUsuario = '{Idusuario}'");
                    MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }



    }
}
