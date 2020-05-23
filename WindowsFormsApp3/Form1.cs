using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Double n1,n2,res;
        String pro;
        public Form1()
        {
            InitializeComponent();
        }

        private void Pro_Click(object sender, EventArgs e)
        {
          Button btn = (Button)sender;
            n1 = Convert.ToDouble(lb_ress.Text);
            pro = btn.Text;
            if(lb_call.Text!="")
            {
                lb_call.Text = lb_call.Text + pro;
            }
            else
            {
                lb_call.Text = lb_ress.Text + pro;
            }
           
            lb_ress.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(lb_ress.Text);
            if(pro=="+")
            {
                res = n1 + n2;
                lb_ress.Text = Convert.ToString(res);
            }
            else if (pro == "-")
            {
                res = n1 - n2;
                lb_ress.Text = Convert.ToString(res);
            }
            else if (pro == "*")
            {
                res = n1 * n2;
                lb_ress.Text = Convert.ToString(res);
            }
            else if (pro == "/")
            {
                res = n1 / n2;
                lb_ress.Text = Convert.ToString(res);
            }
            lb_call.Text = "";
        }

        private void rundbuttn10_Click(object sender, EventArgs e)
        {
            lb_ress.Text = "0";
            lb_call.Text = "0";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(lb_ress.Text=="0")
            {
                lb_ress.Text = " ";
                lb_ress.Text = lb_ress.Text + btn.Text;
            }
            else
            {
                lb_ress.Text = lb_ress.Text + btn.Text;
               
            }
            if(lb_call.Text!="")
            {
                lb_call.Text = lb_call.Text + btn.Text;
            }
            else
            {
                lb_call.Text = lb_ress.Text;
            }
            
        }
    }
}
