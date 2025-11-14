using DAO;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        private Access acceso = new Access();

        private DataSet ds;

        public UsuarioBLL()
        {
            this.ds = acceso.GetDataSet();
        }

        public void Agregar( UsuarioBE newUsuario )
        {
            DataTable dtUsuario = ds.Tables["Usuario"];

            object[] valores = new object[]
            {
                DBNull.Value, //ID
                newUsuario.Nombre,
                newUsuario.Email,
                newUsuario.Tipo,
            };

            dtUsuario.Rows.Add( valores );

            acceso.GuardarDatos();
        }

        public void Eliminar( UsuarioBE newUsuario )
        {
            DataTable dtUsuario = ds.Tables["Usuario"];

            DataRow[] filasEncontradas = dtUsuario.Select($"ID = {newUsuario.Id}");

            if (filasEncontradas.Length > 0)
            {
                DataRow filaAEliminar = filasEncontradas[0];

                filaAEliminar.Delete();

                acceso.GuardarDatos();
            }
            else
            {
                throw new ArgumentException($"Error: Usuario con ID {newUsuario.Id} no encontrado.");
            }
        }
        
        public void Modificar( UsuarioBE newUsuario )
        {
            DataTable dtUsuario = ds.Tables["Usuario"];

            DataRow[] filasEncontradas = dtUsuario.Select($"ID = {newUsuario.Id}");
        
            if ( filasEncontradas.Length > 0)
            {
                DataRow filaModificar = filasEncontradas[0];

                filaModificar["Nombre"] = newUsuario.Nombre;
                filaModificar["Email"] = newUsuario.Email;
                filaModificar["Tipo"] = newUsuario.Tipo;

                acceso.GuardarDatos();
            }
            else
            {
                throw new ArgumentException($"Error: Usuario con ID {newUsuario.Id} no encontrado para modificar.");
            }
        }

        public DataTable ObtenerUsuarios()
        {
            return acceso.GetDataSet().Tables["Usuario"];
        }
    }
}
