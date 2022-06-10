using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week14_2
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
        private string pay;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string str = "";
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                str += checkedListBox1.CheckedItems[i].ToString()+"，";
            }
            lblSHOW.Text += $"\n{textBox1.Text}你好，你買了"+str+$"付款為{pay}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdbARIVED_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbARIVED.Checked)
                pay = "貨到付款";
        }

        private void rdbATM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbATM.Checked)
                pay = "ATM";
        }
        
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSHOW_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
