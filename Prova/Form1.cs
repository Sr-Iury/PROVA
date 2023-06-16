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
            p.codigo = A.Text;
            p.descrcao = AB.Text;
            double imp1 = double.Parse(ip1.Text);
            double imp2 = double.Parse(ip2.Text);
            double imp3 = double.Parse(ip3.Text);
            double valor = double.Parse(v.Text);
            double lucro = double.Parse(luc.Text);
            double imprimir = p.Verfica(valor, imp1, imp2, imp3, lucro);
            

            if(LI.Text == "" || LI.Text == "" || LI.Text == "")
            {
                MessageBox.Show("Por favor selecione uma unidade!!!");
                vdd.Text = "";
            }
            if(LI.Text == "UN")
            {
                vdd.Text = Convert.ToString(imprimir.ToString("C2"));
            }
            else if(LI.Text == "LT" || LI.Text == "KL")
            {
                double imposto = (((imp1 + imp2 + imp3) / 100.0) * valor);
                double dinheiro = valor + imposto;
                double lucro1 = ((lucro / 100.0) * dinheiro);
                double total = lucro1 + dinheiro;
                double unidae = (0.05 * total) + total;
                vdd.Text = Convert.ToString(unidae.ToString("C2"));
            }

        }
    }
}
