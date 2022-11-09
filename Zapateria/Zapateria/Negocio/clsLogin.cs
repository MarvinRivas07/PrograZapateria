using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria.Datos;
using Zapateria.Presentación;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zapateria.Negocio
{
    class clsLogin
    {
        clsConexion Conn = new clsConexion();
        SqlCommand Consulta = new SqlCommand();
        SqlDataReader LeerConsulta;
        public void Login(string Usuario, string Password, string Role)
        {
            try
            {
                Consulta.Connection = Conn.AbrirConexion();
                Consulta.CommandText = "Select NomUsuario, Roles, Password From Table_1  WHERE (NomUsuario= '" + Usuario + "' OR Email='" + Usuario + "') AND Password='" + Password + "'AND Roles='" + Role + "'";

                LeerConsulta = Consulta.ExecuteReader();
                if (LeerConsulta.Read())
                {                              
                   

                    MessageBox.Show("Bienvenido al sistema");
                    
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos!!");

                }
               Consulta.Connection = Conn.CerrarConexion();

            }catch(Exception ex)
            {
                MessageBox.Show("Error de acceso!!" + ex.Message); 
            }
        }
    }
}
