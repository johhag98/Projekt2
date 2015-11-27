using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbxAnd_Click(object sender, EventArgs e)
        {
            string andText1 = tbxAnd1.Text;
            int and1;
            bool andTest11 = int.TryParse(andText1, out and1);
            bool andTest12 = and1 == 1 || and1 == 0;

            string andText2= tbxAnd2.Text;
            int and2;
            bool andTest21 = int.TryParse(andText1, out and2);
            bool andTest22 = and2 == 1 || and2 == 0;


            if (andTest11 == false || andTest12 == false || andTest21 == false || andTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (and1 == 1 && and2 == 1)
            {
                lblSvarAnd.Text = "1";
                lblSvarAnd.ForeColor = Color.Green;
            }
            else
            {
                lblSvarAnd.Text = "0";
                lblSvarAnd.ForeColor = Color.Red;
            }
            
        }
    }
}
