using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_PA9_Nick
{
    public partial class Form1 : Form
    {
        public double UserInput;
        public double ConvertedAmt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if(UserInput < 0)
                {
                    txt_Amount.Text = "please enter a valid amount!";
                }
                else
                {
                    UserInput = double.Parse(txt_Amount.Text);
                    if (rb_US.Checked)
                    {
                        ConvertedAmt = (UserInput * 0.74);
                        txt_Converted.Text = ConvertedAmt.ToString();                        
                    }
                    else if (rb_Yen.Checked)
                    {
                        ConvertedAmt = (UserInput * 81.97);
                        txt_Converted.Text = ConvertedAmt.ToString();
                    }
                    else
                    {
                        txt_Converted.Text = "Please Select Currency!";
                    }
                    
                }
            }
            catch(FormatException)
            {
                txt_Amount.Text = "Please enter a valid amount!";
            }
        }
    }
}
