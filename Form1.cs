using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RimskiCalcStefanAndrejevic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCalc.Text= string.Empty;
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            TxtCalc.Text = TxtCalc.Text.Substring(0,Math.Max(0,TxtCalc.TextLength-1));
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {

        }
    }
}
