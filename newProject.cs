using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class newProject : Form
    {
        public newProject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void login_Click(object sender, EventArgs e)
        {
            string data1 = input1.Text;
            string data2 = input2.Text;
            if (data1 == "kistcollege")
            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
                if(data2 == "pass")
                {
                    MessageBox.Show("Login Successfull");
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("!!!Incorrect Username!!!");
                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
