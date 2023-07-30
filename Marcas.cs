using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace AUTOFELIZ
{
    class Marcas
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        public Marcas()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Marcas";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["marca"];
            tabla.PrimaryKey = dc;
        }

        public DataTable getMarcas()
        {
            return tabla;
        }
    }
}
