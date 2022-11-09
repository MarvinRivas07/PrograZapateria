using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria.Datos;
using System.Data;

namespace Zapateria.Negocio
{
    internal class clsGestionUsuario
    {

        clsUsuario user = new clsUsuario();

        //METODO PARA CARGAR LOS DATOS DE LA TABLA DE USUARIO EN UN DATAGRIDVIEW
        public DataTable ViewUsers()
        {
            DataTable Table = new DataTable();
            Table = user.MostrarUsuario();
            return Table;
        }
        //RegistrarUsuario
        public void RegistrarUasuario(string Nombre, string Apellido, string Telefono, string NomUsuario, string Role, string Email, string Password, string Estado)
        {
            int idUsuario = user.idUser();
            user.RegistrarUasuario(idUsuario,Nombre,Apellido,Telefono,NomUsuario,Role,Email,Password,Estado);
        }

    }
}
