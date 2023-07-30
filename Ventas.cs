using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace AUTOFELIZ
{
    class Ventas
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        public Ventas()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Ventas";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[2];
            dc[0] = tabla.Columns["factura"];
            dc[1] = tabla.Columns["codigo"];
            tabla.PrimaryKey = dc;
        }

        public DataTable getVentas()
        {
            return tabla;
        }
    }
}
