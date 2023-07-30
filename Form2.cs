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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos d = new Datos();
            d.probar2(dataGridView1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
