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
            bool andTest1 = int.TryParse(andText1, out and1);
            bool andTest2 = and1 == 1 || and1 == 0;

            int and2 = int.Parse(tbxAnd2.Text);
            bool andTest12 = and2 == 1 || and2 == 0;

            if (andTest2 == false || andTest2 == false)
            {
                MessageBox.Show("Du måste skriva in antingen en etta eller nolla i båda rutorna, tack!", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
