using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void v_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            double imp1 = double.Parse(ip1.Text);
            double imp2 = double.Parse(ip2.Text);
            double imp3 = double.Parse(ip3.Text);
            double valor = double.Parse(v.Text);
            double lucro = double.Parse(luc.Text);
            double imprimir = p.Verfica(valor, imp1, imp2, imp3, lucro);
            vdd.Text = Convert.ToString(imprimir);

        }
    }
}
