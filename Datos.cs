using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace AUTOFELIZ
{
    class Datos
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private string sql;

        public Datos()
        {

            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.Text;

            sql = "";
        }

        public void probar(DataGridView grilla)
        {
            sql = @"
                SELECT R.codigo, R.nombre, M.nombre AS marca
                FROM Repuestos R
                INNER JOIN Marcas M ON R.marca=M.marca
                WHERE origen='N'
            ";

            comando.CommandText = sql;
            DataTable tabla = new DataTable();
            adaptador = new OleDbDataAdapter(comando);
            adaptador.Fill(tabla);
            grilla.DataSource = tabla;
        }

        public void probar2(DataGridView grilla)
        {
            sql = @"
                SELECT * 
                FROM Ventas
                WHERE codigo=301
                ORDER BY fecha DESC
            ";

            comando.CommandText = sql;
            DataTable tabla = new DataTable();
            adaptador = new OleDbDataAdapter(comando);
            adaptador.Fill(tabla);
            grilla.DataSource = tabla;
        }

        public DataTable probar3(int codigo)
        {
            sql = @"
                SELECT factura, fecha, cantidad
                FROM Ventas
                WHERE codigo = " + codigo;

            comando.CommandText = sql;
            DataTable tabla = new DataTable();
            adaptador = new OleDbDataAdapter(comando);
            adaptador.Fill(tabla);
           

            return tabla;
        }
    }
}
