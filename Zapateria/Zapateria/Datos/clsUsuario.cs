using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Zapateria.Datos
{
    internal class clsUsuario
    {
        private clsConexion Conn = new clsConexion();
        SqlDataReader reed;
        DataTable Tabla = new DataTable();
        SqlCommand Cmd = new SqlCommand();  

        public DataTable MostrarUsuario ()
        {
            Cmd.Connection = Conn.AbrirConexion();
            Cmd.CommandText = "SELECT * FROM Table_1";
            Cmd.CommandType = CommandType.Text;
            reed = Cmd.ExecuteReader();
            Tabla.Load(reed);
            Conn.CerrarConexion();
            return Tabla;
            
        }

        //Funcion para calcular un nuevo id de usuario
        public int idUser()
        {
            Cmd.Connection = Conn.AbrirConexion();
            Cmd.CommandText = "SELECT MAX(idUsuario) FROM Table_1";
            Cmd.CommandType = CommandType.Text;
            int maxID = Convert.ToInt32(Cmd.ExecuteScalar());
            Conn.CerrarConexion();
            return maxID+1;
        }
        //Metodo para insertar datos

        public void RegistrarUasuario(int idUsuario, string Nombre, string Apellido, string Telefono, string NomUsuario, string Role, string Email, string Password, string Estado)
        {
            try
            {
                Cmd.Connection = Conn.AbrirConexion();
                Cmd.CommandText = "INSERT INTO Table_1(idUsuario, Nombre, Apellido, Telefono, NomUsuario, Roles, Email, Password, Estado) VALUES ('" + idUsuario+"','" + Nombre+"','"+Apellido+"','"+Telefono+"','"+NomUsuario+ "','" + Role + "' ,'" + Email + "' ,'" + Password + "','" + Estado+ "')";
                Cmd.ExecuteNonQuery();
                Conn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario", ex.Message);
                
            }
        }
    }
}
