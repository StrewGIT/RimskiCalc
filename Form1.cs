using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RimskiCalcStefanAndrejevic
{
    
    public partial class Form1 : Form
    {
        private RimskiBroj rez,rezx;
        private char op;
        private bool del=false;
        private bool ok=false;
        public Form1()
        {
            InitializeComponent();
            rez=new RimskiBroj(0);
            rezx = new RimskiBroj(1);
            op = ' ';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCalc.Text= string.Empty;
            rez = new RimskiBroj(0);
            rezx= new RimskiBroj(1);
            op = ' ';
            ok = false;
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            TxtCalc.Text = TxtCalc.Text.Substring(0,Math.Max(0,TxtCalc.TextLength-1));
        }

        

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+':BtnPlus_Click(sender,e);  break;
                case '-': BtnMinus_Click(sender, e); break;
                case '*': BtnTimes_Click(sender, e); break;
                case '/': BtnDivision_Click(sender, e); break;
            }
            ok = false;
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            if (del) { TxtCalc.Text = ""; del = false; }
            TxtCalc.Text += 'I';
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            if (del) { TxtCalc.Text = ""; del = false; }
            TxtCalc.Text += 'V';
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            if (del) { TxtCalc.Text = ""; del = false; }
            TxtCalc.Text += 'X';
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            if (del) { TxtCalc.Text = ""; del = false; }
            TxtCalc.Text += 'D';
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (del) { TxtCalc.Text = ""; del = false; }
            TxtCalc.Text += 'C';
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            if (del) { TxtCalc.Text = ""; del = false; }
            TxtCalc.Text += 'L';
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            if (del) { TxtCalc.Text = ""; del = false; }
            TxtCalc.Text += 'M';
        }
        private void BtnDivision_Click(object sender, EventArgs e)
        {
            if (op != '/') BtnEqual_Click(sender, e);
            if (ok) {
                try
                {
                    RimskiBroj broj = new RimskiBroj(TxtCalc.Text);
                    rez = rez / broj;
                    TxtCalc.Text = rez.Broj;
                    del = true;
                    op = '/';
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            else 
            { 
                ok = true;
                try
                {
                    del = true;
                    op = '/';
                    rez = new RimskiBroj(TxtCalc.Text);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message);}
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (op != '-') BtnEqual_Click(sender, e);
            if (ok)
            {
                try
                {
                    RimskiBroj broj = new RimskiBroj(TxtCalc.Text);
                    rez = rez - broj;
                    TxtCalc.Text = rez.Broj;
                    del = true;
                    op = '-';
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                ok = true;
                try
                {
                    del = true;
                    op = '-';
                    rez = new RimskiBroj(TxtCalc.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            if (op != '*') BtnEqual_Click(sender, e);
            if (ok)
            {
                try
                {
                    RimskiBroj broj = new RimskiBroj(TxtCalc.Text);
                    rez = rez * broj;
                    TxtCalc.Text = rez.Broj;
                    del = true;
                    op = '*';
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                ok = true;
                try
                {
                    del = true;
                    op = '*';
                    rez = new RimskiBroj(TxtCalc.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (op != '+') BtnEqual_Click(sender, e);
            if (ok)
            {
                try
                {
                    RimskiBroj broj = new RimskiBroj(TxtCalc.Text);
                    rez = rez + broj;
                    TxtCalc.Text = rez.Broj;
                    del = true;
                    op = '+';
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                ok = true;
                try
                {
                    del = true;
                    op = '+';
                    rez = new RimskiBroj(TxtCalc.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        
    }
}
