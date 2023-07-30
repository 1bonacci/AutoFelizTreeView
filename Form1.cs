using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTOFELIZ
{
    public partial class Form1 : Form
    {
        Repuestos objREP;
        DataTable tr;
        Ventas objVEN;
        DataTable tv;
        Marcas objMAR;
        DataTable tm;
        Datos objDAT;
        DataTable td;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objREP = new Repuestos();
            tr = objREP.getRepuestos();
            objVEN = new Ventas();
            tv = objVEN.getVentas();
            objMAR = new Marcas();
            tm = objMAR.getMarcas();

            TreeNode nodo0 = arbol.Nodes.Add("REPUESTOS");
            TreeNode nodo1;
            nodo1 = nodo0.Nodes.Add("NACIONAL");

            TreeNode nodo2;
            
            foreach(DataRow filar in tr.Rows)
            {
                if(filar["origen"].ToString()=="N")
                {
                    nodo2 = nodo1.Nodes.Add(filar["nombre"].ToString());
                    nodo2.Tag = filar["codigo"].ToString();
                }
            }
            
            nodo1 = nodo0.Nodes.Add("IMPORTADO");

            foreach (DataRow filar in tr.Rows)
            {
                if (filar["origen"].ToString() == "I")
                {
                    nodo2 = nodo1.Nodes.Add(filar["nombre"].ToString());
                    nodo2.Tag = filar["codigo"].ToString();

                }
            }
        }

        private void arbol_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lblPrecio.Text = "";
            //grilla.Rows.Clear();
            barra.Items.Clear();

            if(e.Node.Level==2)
            {
                DataRow filar = tr.Rows.Find(e.Node.Tag);
                Decimal precio = (Decimal) filar["precio"];


                lblPrecio.Text = precio.ToString("###,###,##0.00");

                int ct = 0;
                /*
                foreach(DataRow filav in tv.Rows)
                {
                    if(filav["codigo"].ToString()==e.Node.Tag.ToString())
                    {
                        grilla.Rows.Add(filav["factura"].ToString(), filav["fecha"].ToString(), filav["cantidad"].ToString());
                        ct = ct + (int) filav["cantidad"];
                    }
                }
                */

                // CODIGO SQL PEDIDO POR EL ALUMNO
                objDAT = new Datos();
                int codigo = Convert.ToInt32(e.Node.Tag.ToString());
                td = objDAT.probar3(codigo);
                dataGridView1.DataSource = td;
                // FIN CODIGO SQL

                barra.Items.Add("Cantidad Total");
                barra.Items.Add(ct.ToString());

                int marca = (int) filar["marca"];
                DataRow filam = tm.Rows.Find(marca);

                barra.Items.Add("Marca Repuesto");
                barra.Items.Add(filam["nombre"].ToString());


            }
        }
    }
}
