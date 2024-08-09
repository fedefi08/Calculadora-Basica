using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double n1, n2, rta;
            n1 = double.Parse(txtNumero1.Text);
            n2 = double.Parse(txtNumero2.Text);
            rta = n1 + n2;

            txtRespuesta.Text = rta.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double n1, n2, rta;
                n1 = double.Parse(txtNumero1.Text);
                n2 = double.Parse(txtNumero2.Text);
                rta = n1 - n2;

                txtRespuesta.Text = rta.ToString();
  
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double n1, n2, rta;
            n1 = double.Parse(txtNumero1.Text);
            n2 = double.Parse(txtNumero2.Text);
            rta = n1 * n2;

            txtRespuesta.Text = rta.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double n1, n2, rta;
            n1 = double.Parse(txtNumero1.Text);
            n2 = double.Parse(txtNumero2.Text);
            rta = n1 / n2;

            txtRespuesta.Text = rta.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
