using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indicemasacorporal
{
    public partial class Form1 : Form
    {
        Imc imc = new Imc();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            imc.setPeso(double.Parse(txtpeso.Text));
            imc.setEstatura(double.Parse(txtestatura.Text));

            lbltotal.Text = imc.calcularImc().ToString();
            lbltotal.Visible = true;
        }
    }
}
