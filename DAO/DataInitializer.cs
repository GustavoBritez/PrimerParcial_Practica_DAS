using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataInitializer
    {
        public static void CrearTablas(DataSet Ds)
        {
            DataTable dtUsuario = new DataTable("Usuario");

            // Definimos la PK
            DataColumn colUsuario = dtUsuario.Columns.Add("ID", typeof(int));
            colUsuario.AutoIncrement = true;
            colUsuario.AutoIncrementSeed = 1;
            colUsuario.AutoIncrementStep = 1;

            dtUsuario.Columns.Add("Nombre", typeof(string));
            dtUsuario.Columns.Add("Email", typeof(string));
            dtUsuario.Columns.Add("Tipo", typeof(string));

            /// Cargamos a el data table la primary key y le indicamos la columna creada
            dtUsuario.PrimaryKey = new DataColumn[] { colUsuario };
            /// Agregamos al DataSet el DataTable creado
            Ds.Tables.Add(dtUsuario);

            //- - - - Tabla Huesped 
            DataTable dtHuesped = new DataTable("Huesped");

            DataColumn colHuesped = dtHuesped.Columns.Add("ID",typeof(int));

            dtHuesped.Columns.Add("Telefono",typeof(string));

            // Cargamos a el data tabla la primary key y le indicamos la columna creada
            dtHuesped.PrimaryKey = new DataColumn[] {colHuesped};

            Ds.Tables.Add(dtHuesped);

            // - - - - Tabla Reserva
            DataTable dtReserva = new DataTable("Reserva");

            DataColumn colReserva = dtReserva.Columns.Add("ID",typeof(int));
            colReserva.AutoIncrement = true;
            colReserva.AutoIncrementSeed= 1;
            colReserva.AutoIncrementStep = 1;

            dtReserva.Columns.Add("FechaSalida",typeof(DateTime));
            dtReserva.Columns.Add("FechaEntrada",typeof(DateTime));
            dtReserva.Columns.Add("Estado",typeof(string));

            DataColumn colHuespedFK = dtReserva.Columns.Add("idHuesped", typeof(int));

            dtReserva.PrimaryKey = new DataColumn[] { colReserva };

            Ds.Tables.Add(dtReserva);
            // La relacion se establece entre la columna "ID" padre y el "ID" huesped
            DataRelation relacionUsuarioHuesped = new DataRelation
                (
                    "FK_USUARIO_HUESPED",
                    colUsuario,
                    colHuesped,
                    false
                );

            DataRelation relacionHuespedReserva = new DataRelation
                (
                    "FK_HUESPED_RESERVA",
                    colHuesped,
                    colHuespedFK,// Esto esta en reserva 
                    false
                );
            #region Huesped Reserva
            relacionHuespedReserva.ChildKeyConstraint.DeleteRule = Rule.Cascade;
            relacionHuespedReserva.ChildKeyConstraint.UpdateRule = Rule.Cascade;
            #endregion
            #region Usuario Huesped
            /// Si se borra un usuario se borra un huesped
            relacionUsuarioHuesped.ChildKeyConstraint.DeleteRule = Rule.Cascade;
            /// Si se modifica un usuario se modificar un huesped
            relacionUsuarioHuesped.ChildKeyConstraint.UpdateRule = Rule.Cascade;
            #endregion
            Ds.Relations.Add(relacionUsuarioHuesped);
        }
    }
}
