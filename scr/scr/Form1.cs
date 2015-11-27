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

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            lblSvarAnd.Text = "?";
            lblSvarAnd.ForeColor = Color.Black;
            lblSvarOr.Text = "?";
            lblSvarOr.ForeColor = Color.Black;
        }

        private void pbxAnd_Click(object sender, EventArgs e)
        {
            string andText1 = tbxAnd1.Text;
            int and1;
            bool andTest11 = int.TryParse(andText1, out and1);
            bool andTest12 = and1 == 1 || and1 == 0;

            string andText2 = tbxAnd2.Text;
            int and2;
            bool andTest21 = int.TryParse(andText2, out and2);
            bool andTest22 = and2 == 1 || and2 == 0;


            if (andTest11 == false || andTest12 == false || andTest21 == false || andTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblSvarAnd.Text = "X";
                lblSvarAnd.ForeColor = Color.Black;
            }

            if ((and1 == 1) && (and2 == 1))
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

        private void pbxOr_Click(object sender, EventArgs e)
        {
            string OrText1 = tbxOr1.Text;
            int Or1;
            bool OrTest11 = int.TryParse(OrText1, out Or1);
            bool OrTest12 = Or1 == 1 || Or1 == 0;

            string OrText2 = tbxOr2.Text;
            int Or2;
            bool OrTest21 = int.TryParse(OrText1, out Or2);
            bool OrTest22 = Or2 == 1 || Or2 == 0;


            if (OrTest11 == false || OrTest12 == false || OrTest21 == false || OrTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblSvarAnd.Text = "X";
                lblSvarAnd.ForeColor = Color.Black;
            }

            else if (Or1 == 1 || Or2 == 1)
            {
                lblSvarOr.Text = "1";
                lblSvarOr.ForeColor = Color.Green;
            }
            else
            {
                lblSvarOr.Text = "0";
                lblSvarOr.ForeColor = Color.Red;
            }

        }

        private void pbxNand_Click(object sender, EventArgs e)
        {
            string andText1 = tbxNand1.Text;
            int and1;
            bool andTest11 = int.TryParse(andText1, out and1);
            bool andTest12 = and1 == 1 || and1 == 0;

            string andText2= tbxNand2.Text;
            int and2;
            bool andTest21 = int.TryParse(andText2, out and2);
            bool andTest22 = and2 == 1 || and2 == 0;


            if (andTest11 == false || andTest12 == false || andTest21 == false || andTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (and1 == 1 && and2 == 1)
            {
                lblNandSvar.Text = "0";
                lblNandSvar.ForeColor = Color.Red;
            }
            else
            {
                lblNandSvar.Text = "1";
                lblNandSvar.ForeColor = Color.Green;
            }
        }

    }
}
