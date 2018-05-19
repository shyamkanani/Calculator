using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        double memory = 0;
        //Label lbl = new Label();
        bool check = false;

        public void disable()
        {
            memory = 0;
            tresult.Clear();
            lbloperation.Text = "";
            tresult.Enabled = false;
            lbloperation.Enabled = false;
            bon.Show();
            boff.Hide();
            n1.Enabled = false;
            n2.Enabled = false;
            n3.Enabled = false;
            n4.Enabled = false;
            n5.Enabled = false;
            n6.Enabled = false;
            n7.Enabled = false;
            n8.Enabled = false;
            n9.Enabled = false;
            n0.Enabled = false;
            bdot.Enabled = false;
            bequ.Enabled = false;
            bper.Enabled = false;
            bplus.Enabled = false;
            bmin.Enabled = false;
            bmul.Enabled = false;
            bdiv.Enabled = false;
            bc.Enabled = false;
            bce.Enabled = false;
            bcan.Enabled = false;
        }
        public void enable()
        {
            memory = 0;
            tresult.Clear();
            lbloperation.Text = "";
            tresult.Enabled = true;
            lbloperation.Enabled = true;
            boff.Show();
            bon.Hide();
            n1.Enabled = true;
            n2.Enabled = true;
            n3.Enabled = true;
            n4.Enabled = true;
            n5.Enabled = true;
            n6.Enabled = true;
            n7.Enabled = true;
            n8.Enabled = true;
            n9.Enabled = true;
            n0.Enabled = true;
            bdot.Enabled = true;
            bequ.Enabled = true;
            bper.Enabled = true;
            bplus.Enabled = true;
            bmin.Enabled = true;
            bmul.Enabled = true;
            bdiv.Enabled = true;
            bc.Enabled = true;
            bce.Enabled = true;
            bcan.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                tresult.Text = "0";
                check = false;
            }
            Button button = (Button)sender;
            if (button.Text == ".") 
            {
                if (!tresult.Text.Contains(".")) 
                {
                    tresult.Text = tresult.Text + button.Text;
                }
            }
            else if (tresult.Text == "0")
            {
                tresult.Text = button.Text;
            }
            else
            {
                tresult.Text = tresult.Text + button.Text;
            }  
        }
        private void bc_Click(object sender, EventArgs e)
        {
            tresult.Text = "0";
            lbloperation.Text = "";
            result = 0;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                if (check == true) 
                {
                    tresult.Text = "0";
                }
                bequ.PerformClick();
                operation = button.Text;
                tresult.Text = "0";
                lbloperation.Text = result + " " + operation;
                check = false;
            }
            else
            {
                operation = button.Text;
                result = Convert.ToDouble(tresult.Text);
                tresult.Text = "0";
                lbloperation.Text = result + " " + operation;
                check = false;
            }
        }
        private void bequ_Click(object sender, EventArgs e)
        {
            switch (operation) 
            {
                case "+": 
                    tresult.Text = (result + (Convert.ToDouble(tresult.Text))).ToString();
                    break;
                case "-":
                    tresult.Text = (result - (Convert.ToDouble(tresult.Text))).ToString();
                    break;
                case "ˣ":
                    tresult.Text = (result * (Convert.ToDouble(tresult.Text))).ToString();
                    break;
                case "%":
                    tresult.Text = (result % (Convert.ToDouble(tresult.Text))).ToString();
                    break;
                case "÷":
                    if (Convert.ToDouble(tresult.Text) == 0)
                    {
                        tresult.Text = "Infinity";
                        break;
                    }
                    else
                    {
                        tresult.Text = (result / (Convert.ToDouble(tresult.Text))).ToString();
                        break;
                    }
            }
            result = Convert.ToDouble(tresult.Text);
            lbloperation.Text = "";
            check = true;
        }

        private void bcan_Click(object sender, EventArgs e)
        {
            int l = tresult.TextLength-1;
            String text = tresult.Text;
            tresult.Clear();
            for(int i=0;i<l;i++)
            {
                tresult.Text = tresult.Text + text[i];
            }
        }

        private void boff_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void bon_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void bce_Click(object sender, EventArgs e)
        {
            tresult.Text = "0";
        }

        private void btnmp_Click(object sender, EventArgs e)
        {
            memory = memory + (Convert.ToDouble(tresult.Text));
        }

        private void btnsq_Click(object sender, EventArgs e)
        {
            double ans = System.Math.Sqrt(Convert.ToDouble(tresult.Text));
            tresult.Text = ans.ToString();
        }

        private void btnmm_Click(object sender, EventArgs e)
        {
            memory = memory - (Convert.ToDouble(tresult.Text));
        }

        private void btnmc_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void btnmr_Click(object sender, EventArgs e)
        {
            tresult.Text = memory.ToString();
        }
    }
}
