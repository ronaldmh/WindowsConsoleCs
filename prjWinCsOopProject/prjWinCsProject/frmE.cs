using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWinCsProject
{
    public partial class frmEstandarCalculator : Form
    {

        private void frmEstandarCalculator_Load(object sender, EventArgs e)
        {
            btnMemoClear.Enabled = false;
            btnMemoRecall.Enabled = false;
            btnMemoRemove.Enabled = false;
            btnMemoDisplay.Enabled = false;
            
        }

        public frmEstandarCalculator()
        {
            InitializeComponent();
            lblResult.Text = "0";
            
        }

        private 

        Double number1, number2, result, memory;
        string operation;
        bool percOperation = false;

       


        private void btn1_Click(object sender, EventArgs e)
        {
            
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "1" : lblResult.Text = lblResult.Text + "1";
            
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "2" : lblResult.Text = lblResult.Text + "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "3" : lblResult.Text = lblResult.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "4" : lblResult.Text = lblResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "5" : lblResult.Text = lblResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "6" : lblResult.Text = lblResult.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "7" : lblResult.Text = lblResult.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "8" : lblResult.Text = lblResult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "9" : lblResult.Text = lblResult.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblResult.Text = (lblResult.Text == "0" && lblResult.Text != null) ? lblResult.Text = "0" : lblResult.Text = lblResult.Text + "0";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(lblResult.Text);
            lblSecondDisplay.Text = lblResult.Text + " + ";            
            lblResult.Text = "";
            operation = "+";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(lblResult.Text);
            lblSecondDisplay.Text = lblResult.Text + " - ";
            lblResult.Text = "";
            operation = "-";

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(lblResult.Text);
            lblSecondDisplay.Text = lblResult.Text + " * ";
            lblResult.Text = "";
            operation = "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(lblResult.Text);
            lblSecondDisplay.Text = lblResult.Text + " / ";
            lblResult.Text = "";
            operation = "/";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            lblSecondDisplay.Text = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            lblResult.Text = "-" + lblResult.Text;
        }

        private void btnOneDivNumber_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(lblResult.Text);
            string tmp = lblResult.Text;
            result = 1 / number2;
            lblResult.Text = Convert.ToString(result);
            lblSecondDisplay.Text = "1/" + tmp;
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(lblResult.Text);
            string tmp = lblResult.Text;
            result = number2 * number2;
            lblResult.Text = Convert.ToString(result);
            lblSecondDisplay.Text = "sqr " + tmp;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(lblResult.Text);
            string tmp = lblResult.Text;
            result = Math.Sqrt(number2);
            lblResult.Text = Convert.ToString(result);
            lblSecondDisplay.Text = "sqr " + tmp;
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            percOperation = true;
            number2 = Convert.ToDouble(lblResult.Text);            
            result = number2 * number1 / 100;
            lblResult.Text = Convert.ToString(result);
            percOperation = false;           
        }

        private void btnMemoAdd_Click(object sender, EventArgs e)
        {
            btnMemoRecall.Enabled = true;
            btnMemoRemove.Enabled = true;
            btnMemoClear.Enabled = true;
            btnMemoDisplay.Enabled = true;
            
            memory += Convert.ToDouble(lblResult.Text);
            lblResult.Text = Convert.ToString(memory);
        }

        private void btnMemoClear_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
                lblResult.Text = "0";
            else
                lblResult.Text = lblResult.Text;
            memory = 0;

            btnMemoRecall.Enabled = false;
            btnMemoRemove.Enabled = false;
            btnMemoClear.Enabled = false;
            btnMemoDisplay.Enabled = false;

            
        }

      
        private void btnMemoRemove_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDouble(lblResult.Text);
            lblResult.Text = Convert.ToString(memory);
        }

        private void btnDeleteFow_Click(object sender, EventArgs e)
        {
            Int16 indx = Convert.ToInt16(lblResult.Text.Length);
            lblResult.Text = lblResult.Text.Substring(0 , indx-1); 
        }

     
      

        private void btnMemoRecall_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(memory);
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            lblResult.Text += ",";
            
        }
              
        
        
        private void btnEqual_Click(object sender, EventArgs e)
        {
           
            switch (operation)
            {
                case "+":
                    {
                        number2 = Convert.ToDouble(lblResult.Text);
                        lblSecondDisplay.Text += lblResult.Text + " = ";
                        result = number1 + number2;
                        lblResult.Text = Convert.ToString(result);
                        break;
                    }

                case "-":
                    {
                        number2 = Convert.ToDouble(lblResult.Text);
                        lblSecondDisplay.Text += lblResult.Text + " = ";
                        result = number1 - number2;
                        lblResult.Text = Convert.ToString(result);
                        break;
                    }
                case "*":
                    {
                        if (percOperation == false) 
                        {
                            number2 = Convert.ToDouble(lblResult.Text);
                            lblSecondDisplay.Text += lblResult.Text + " = ";
                            result = number1 * number2;
                            lblResult.Text = Convert.ToString(result);
                        }
                        break;
                    }

                case "/":
                    {
                        number2 = Convert.ToDouble(lblResult.Text);
                        lblSecondDisplay.Text += lblResult.Text + " = ";
                        result = number1 / number2;
                        lblResult.Text = Convert.ToString(result);
                        break;
                    }
               
            }

        }



    }
}