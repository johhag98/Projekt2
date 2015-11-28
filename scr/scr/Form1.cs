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
            //För att storleken på fönstret inte ska kunna ändras-
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

   

        private void pbxAnd_Click(object sender, EventArgs e)
        {
            //Läser in tal 1 för AND och försöker göra om det till en int
            string andText1 = tbxAnd1.Text;
            int and1;
            //Kollar så att talet det läst in är ett tal, och om det är en etta eller nolla
            //Den första boolen blir falsk om det inte går att göra om till ett tal
            bool andTest11 = int.TryParse(andText1, out and1);
            //Den andra boolen blir falsk om det inte är en etta eller en nolla
            bool andTest12 = and1 == 1 || and1 == 0;

            //Läser in tal 2 för AND och försöker göra om det till en int
            string andText2 = tbxAnd2.Text;
            int and2;
            bool andTest21 = int.TryParse(andText2, out and2);
            bool andTest22 = and2 == 1 || and2 == 0;

            //Kollar om någon av boolerna är falska (Om det inte är ett tal, etta eller nolla)
            if (andTest11 == false || andTest12 == false || andTest21 == false || andTest22 == false)
            {
                lblSvarAnd.Text = "X";
                lblSvarAnd.ForeColor = Color.Black;
                //Visar ett felmeddelande
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Kollar så att båda talen är lika med ett
            if ((and1 == 1) && (and2 == 1))
            {
                //Om båda talen är lika med ett blir svaret en grön etta
                lblSvarAnd.Text = "1";
                lblSvarAnd.ForeColor = Color.Green;
            }
            else
            {
                //För allt annat blir svaret en röd nolla
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
            bool OrTest21 = int.TryParse(OrText2, out Or2);
            bool OrTest22 = Or2 == 1 || Or2 == 0;


            if (OrTest11 == false || OrTest12 == false || OrTest21 == false || OrTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblSvarAnd.Text = "X";
                lblSvarAnd.ForeColor = Color.Black;
            }
            //Kollar så att något av talen är lika med ett
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

            string andText2 = tbxNand2.Text;
            int and2;
            bool andTest21 = int.TryParse(andText2, out and2);
            bool andTest22 = and2 == 1 || and2 == 0;


            if (andTest11 == false || andTest12 == false || andTest21 == false || andTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNandSvar.Text = "X";
                lblNandSvar.ForeColor = Color.Black;
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

        private void pbxNor_Click(object sender, EventArgs e)
        {
            string andText1 = tbxNor1.Text;
            int and1;
            bool andTest11 = int.TryParse(andText1, out and1);
            bool andTest12 = and1 == 1 || and1 == 0;

            string andText2 = tbxNor2.Text;
            int and2;
            bool andTest21 = int.TryParse(andText2, out and2);
            bool andTest22 = and2 == 1 || and2 == 0;


            if (andTest11 == false || andTest12 == false || andTest21 == false || andTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNandSvar.Text = "X";
                lblNandSvar.ForeColor = Color.Black;
            }


            if (and1 == 1 || and2 == 1)
            {
                lblSvarNor.Text = "0";
                lblSvarNor.ForeColor = Color.Red;
            }
            else
            {
                lblSvarNor.Text = "1";
                lblSvarNor.ForeColor = Color.Green;
            }
        }

        private void pbxXor_Click(object sender, EventArgs e)
        {
            string andText1 = tbxXor1.Text;
            int and1;
            bool andTest11 = int.TryParse(andText1, out and1);
            bool andTest12 = and1 == 1 || and1 == 0;

            string andText2 = tbxXor2.Text;
            int and2;
            bool andTest21 = int.TryParse(andText2, out and2);
            bool andTest22 = and2 == 1 || and2 == 0;


            if (andTest11 == false || andTest12 == false || andTest21 == false || andTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNandSvar.Text = "X";
                lblNandSvar.ForeColor = Color.Black;
            }

            //Kollar så att båda talen är lika med varandra
            if (and1 == and2)
            {
                lblSvarXor.Text = "0";
                lblSvarXor.ForeColor = Color.Red;
            }
            else
            {
                lblSvarXor.Text = "1";
                lblSvarXor.ForeColor = Color.Green;
            }
        }

        private void pbxXnor_Click(object sender, EventArgs e)
        {
            string andText1 = tbxXnor1.Text;
            int and1;
            bool andTest11 = int.TryParse(andText1, out and1);
            bool andTest12 = and1 == 1 || and1 == 0;

            string andText2 = tbxXnor2.Text;
            int and2;
            bool andTest21 = int.TryParse(andText2, out and2);
            bool andTest22 = and2 == 1 || and2 == 0;


            if (andTest11 == false || andTest12 == false || andTest21 == false || andTest22 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNandSvar.Text = "X";
                lblNandSvar.ForeColor = Color.Black;
            }

            //Kollar så att båda talen är lika med varandra
            if (and1 == and2)
            {
                lblSvarXnor.Text = "1";
                lblSvarXnor.ForeColor = Color.Green;
            }
            else
            {
                lblSvarXnor.Text = "0";
                lblSvarXnor.ForeColor = Color.Red;
            }
        }

        private void pbxNot_Click(object sender, EventArgs e)
        {
            string andText1 = tbxNot.Text;
            int and1;
            bool andTest11 = int.TryParse(andText1, out and1);
            bool andTest12 = and1 == 1 || and1 == 0;


            if (andTest11 == false || andTest12 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNandSvar.Text = "X";
                lblNandSvar.ForeColor = Color.Black;
            }

            //Kollar så att talet är lika med noll
            if (and1 == 0)
            {
                lblSvarNot.Text = "1";
                lblSvarNot.ForeColor = Color.Green;
            }
            else
            {
                lblSvarNot.Text = "0";
                lblSvarNot.ForeColor = Color.Red;
            }
        }





        //När texten i textboxarna ändras blir svarsrutorna ett svart frågetecken
        private void tbxAnd1_TextChanged(object sender, EventArgs e) { lblSvarAnd.Text = "?"; lblSvarAnd.ForeColor = Color.Black; }
        private void tbxAnd2_TextChanged(object sender, EventArgs e) { lblSvarAnd.Text = "?"; lblSvarAnd.ForeColor = Color.Black; }
        private void tbxNand1_TextChanged(object sender, EventArgs e) { lblNandSvar.Text = "?"; lblNandSvar.ForeColor = Color.Black; }
        private void tbxNand2_TextChanged(object sender, EventArgs e) { lblNandSvar.Text = "?"; lblNandSvar.ForeColor = Color.Black; }
        private void tbxOr1_TextChangeed(object sender, EventArgs e) { lblSvarOr.Text = "?"; lblSvarOr.ForeColor = Color.Black; }
        private void tbxOr2_TextChangeed(object sender, EventArgs e) { lblSvarOr.Text = "?"; lblSvarOr.ForeColor = Color.Black; }
        private void tbxNor1_TextChanged(object sender, EventArgs e) { lblSvarNor.Text = "?"; lblSvarNor.ForeColor = Color.Black; }
        private void tbxNor2_TextChanged(object sender, EventArgs e) { lblSvarNor.Text = "?"; lblSvarNor.ForeColor = Color.Black; }
        private void tbxXor1_TextChanged(object sender, EventArgs e) { lblSvarXor.Text = "?"; lblSvarXor.ForeColor = Color.Black; }
        private void tbxXor2_TextChanged(object sender, EventArgs e) { lblSvarXor.Text = "?"; lblSvarXor.ForeColor = Color.Black; }
        private void tbxXnor1_TextChanged(object sender, EventArgs e) { lblSvarXnor.Text = "?"; lblSvarXnor.ForeColor = Color.Black; }
        private void tbxXnor2_TextChanged(object sender, EventArgs e) { lblSvarXnor.Text = "?"; lblSvarXnor.ForeColor = Color.Black; }
        private void tbxNot_TextChanged(object sender, EventArgs e) { lblSvarNot.Text = "?"; lblSvarNot.ForeColor = Color.Black; }
    }
}
