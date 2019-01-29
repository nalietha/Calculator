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
        //Global Variables
        public double FirstOpperand = 0;
        public double SecondOpperand = 0;
        public char Opperand ='a';
        public double Result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Numbers
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("1");      
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (Display.Text != String.Empty)
            {
                if (Convert.ToDecimal(Display.Text) == 0)
                    Display.Text = "";
            }
            Display.AppendText("0");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Contains('.'))
                Display.AppendText(".");
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {

            if (Display.Text != String.Empty)
            {
                if (Display.Text.Contains('-'))
                    Display.Text = Display.Text.Trim('-');
                else
                    Display.Text = Display.Text.Insert(0, "-");
            }
        }
        #endregion

        #region Operations
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (FirstOpperand == 0)
            {
                FirstOpperand = Convert.ToInt64(Display.Text);
                Opperand = '+';
                lblPart2.Text = Display.Text;
                Display.Text = "";
            }
            else
            {
                FirstOpperand += Convert.ToInt64(Display.Text);
                Opperand = '+';
                lblPart2.Text = FirstOpperand.ToString();
                Display.Text = "";
            }
        }

        private void btnNegitive_Click(object sender, EventArgs e)
        {
            if (FirstOpperand == 0)
            {
                FirstOpperand = Convert.ToDouble(Display.Text);
                Opperand = '-';
                lblPart2.Text = Display.Text;
                Display.Text = "";
            }
            else
            {
                FirstOpperand -= Convert.ToDouble(Display.Text);
                Opperand = '-';
                lblPart2.Text = FirstOpperand.ToString();
                Display.Text = "";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (FirstOpperand == 0)
            {
                FirstOpperand = Convert.ToDouble(Display.Text);
                Opperand = '*';
                lblPart2.Text = Display.Text;
                Display.Text = "";
            }
            else
            {
                FirstOpperand *= Convert.ToDouble(Display.Text);
                Opperand = '*';
                lblPart2.Text = FirstOpperand.ToString();
                Display.Text = "";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (FirstOpperand == 0)
            {
                FirstOpperand = Convert.ToDouble(Display.Text);
                Opperand = '/';
                lblPart2.Text = Display.Text;
                Display.Text = "";
            }
            else if(Convert.ToDouble(Display.Text) != 0)
            {
                FirstOpperand /= Convert.ToDouble(Display.Text);
                Opperand = '/';
                lblPart2.Text = FirstOpperand.ToString();
                Display.Text = "";
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (Display.Text == string.Empty)
                SecondOpperand = 0;
            else
                SecondOpperand = Convert.ToDouble(Display.Text);

            switch(Opperand)
            {
                case '+':
                    Display.Text = (FirstOpperand + SecondOpperand).ToString();
                    break;
                case '-':
                    Display.Text = (FirstOpperand - SecondOpperand).ToString();
                    break;
                case '*':
                    Display.Text = (FirstOpperand * SecondOpperand).ToString();
                    break;
                case '/':
                    if (SecondOpperand != 0)
                        Display.Text = (FirstOpperand / SecondOpperand).ToString();
                    else
                        MessageBox.Show("Cannot Divide By Zero", "!Div#0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case '^':
                    Display.Text = Math.Pow(FirstOpperand, SecondOpperand).ToString();
                    break;
                case 'a':
                    // Nothing, Is a place holder for issues 
                    break;
                default:
                    // Nothing
                    break;
            }
            lblPart2.Text = "";
            FirstOpperand = 0;
            SecondOpperand = 0;
            Opperand = 'a';
        }
        #endregion

        #region OtherOps

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if(Display.Text != String.Empty)
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);

        }

        private void btnFraction_Click(object sender, EventArgs e)
        {
            //btnFraction
            if (Display.Text != string.Empty && Display.Text != "Error")
            {
                Display.Text = (1/(Convert.ToDouble(Display.Text))).ToString();
            }
        }


        private void btnSQRT_Click(object sender, EventArgs e)
        {
            if(Display.Text != string.Empty && Display.Text != "Error")
            {
                Display.Text = (Math.Sqrt(Convert.ToDouble(Display.Text))).ToString();
            }
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            if (Display.Text != string.Empty && Display.Text != "Error")
            {
                Display.Text = (Math.Pow(Convert.ToDouble(Display.Text),2)).ToString();
            }
        }

        private void btnXYExpo_Click(object sender, EventArgs e)
        {
            if (FirstOpperand == 0)
            {
                FirstOpperand = Convert.ToDouble(Display.Text);
                Opperand = '^';
                lblPart2.Text = Display.Text;
                Display.Text = "";
            }
            else if (Convert.ToDouble(Display.Text) != 0)
            {
                FirstOpperand = Math.Pow(FirstOpperand, Convert.ToDouble(Display.Text));
                Opperand = '^';
                lblPart2.Text = FirstOpperand.ToString();
                Display.Text = "";

            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            lblPart2.Text = "";
            FirstOpperand = 0;
            SecondOpperand = 0;
            Opperand = 'a';

        }

 
        #endregion

    }
}
