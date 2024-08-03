using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI45VSGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(txValor1.Text);
            var2 = int.Parse(txValor2.Text);

            total = var1 + var2;

            lbResultado.Text = total.ToString();


        }
    }
}
