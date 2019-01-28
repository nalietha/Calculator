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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Numbers
        private void btnOne_Click(object sender, EventArgs e)
        {
            Display.AppendText("1");      
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Display.AppendText("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Display.AppendText("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Display.AppendText("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Display.AppendText("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Display.AppendText("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Display.AppendText("6");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Display.AppendText("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Display.AppendText("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Display.AppendText("0");
        }
        #endregion

        #region Operations
        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnNegitive_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Display.Text = (Convert.ToInt64(lblPart2.Text) ;
        }
        #endregion

        #region OtherOps

        private void btnDEL_Click(object sender, EventArgs e)
        {
            //Display.Text.Remove( (Display.TextLength) == 0 ? 0 : (Display.TextLength) - 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //btnFraction

        }

        #endregion

        private void btnSQRT_Click(object sender, EventArgs e)
        {

        }

        private void btnExpo_Click(object sender, EventArgs e)
        {

        }

        private void btnXYExpo_Click(object sender, EventArgs e)
        {

        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            Display.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            lblPart2.Text = "";
        }

        public void moveup()
        {
            lblPart2.Text = Display.Text;
        }
    }
}
