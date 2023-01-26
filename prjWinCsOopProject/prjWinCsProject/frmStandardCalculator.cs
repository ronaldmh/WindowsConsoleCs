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
    public partial class frmStandardCalculator : Form
    {
        // preload disable buttons
        private void frmEstandarCalculator_Load(object sender, EventArgs e)
        {
            btnMemoClear.Enabled = false;
            btnMemoRecall.Enabled = false;
            btnMemoRemove.Enabled = false;
            btnMemoDisplay.Enabled = false;
        }
        //
        public frmStandardCalculator()
        {
            InitializeComponent();
            lblResult.Text = "0";
        }

        //Variables
        Double number1, number2, result, memory;
        string operation;
        bool percOperation = false;
                
        #region Buttons 0-9        
        // Third conditional to recuperate the number in the label
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
        #endregion

        #region Basic Math Operations
        //Basic Math operations
        // Addition
        private void btnAddition_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(lblResult.Text);
            lblSecondDisplay.Text = lblResult.Text + " + ";            
            lblResult.Text = "";
            operation = "+";
        }

        //Subtraction
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(lblResult.Text);
            lblSecondDisplay.Text = lblResult.Text + " - ";
            lblResult.Text = "";
            operation = "-";
        }

        //Multiplication
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(lblResult.Text);
            lblSecondDisplay.Text = lblResult.Text + " * ";
            lblResult.Text = "";
            operation = "*";
        }

        //Division
        private void btnDivision_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(lblResult.Text);
            lblSecondDisplay.Text = lblResult.Text + " / ";
            lblResult.Text = "";
            operation = "/";
        }
        #endregion

        #region Special Functions
        // Special Functions 

        // Clear screen
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lblResult.Text = string.Empty;
            lblResult.Text = "0";
            this.lblSecondDisplay.Text = "";
        }

        // Clear screen
        private void BtnCE_Click(object sender, EventArgs e)
        {
            this.lblResult.Text = string.Empty;
            lblResult.Text = "0";
            //lblSecondDisplay.Text = "";
        }

        // Button plu/minus
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            lblResult.Text = "-" + lblResult.Text;
        }

        // Button 1/n
        private void btnOneDivNumber_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(lblResult.Text);
            string tmp = lblResult.Text;
            result = 1 / number2;
            lblResult.Text = Convert.ToString(result);
            lblSecondDisplay.Text = "1/" + tmp;
        }

        // Button square
        private void btnSqr_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(lblResult.Text);
            string tmp = lblResult.Text;
            result = number2 * number2;
            lblResult.Text = Convert.ToString(result);
            lblSecondDisplay.Text = "sqr " + tmp;
        }

        // Button root
        private void btnRoot_Click(object sender, EventArgs e)
        {
            lblSecondDisplay.Text = "√(0)";
            
            number2 = Convert.ToDouble(lblResult.Text);
            string tmp = lblResult.Text;
            result = Math.Sqrt(number2);
            lblResult.Text = Convert.ToString(result);
            lblSecondDisplay.Text = "√ " + tmp;
        }

        // Button to find percentage >> shitch case in multiplication operation 
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            percOperation = true;
        }
        
        // Memory Manage
        // Addition values to memories
        private void btnMemoAdd_Click(object sender, EventArgs e)
        {
            //enable buttons
            btnMemoRecall.Enabled = true;
            btnMemoRemove.Enabled = true;
            btnMemoClear.Enabled = true;
            btnMemoDisplay.Enabled = true;
            // Adding values
            memory += Convert.ToDouble(lblResult.Text);
            lblResult.Text = Convert.ToString(memory);
        }

        // Clear memory - Disable buttons
        private void btnMemoClear_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                this.lblResult.Text = string.Empty;
            }
            else
            {
                lblResult.Text = lblResult.Text;
            }                
            
            memory = 0;
            // Disable Aux buttons memory
            btnMemoRecall.Enabled = false;
            btnMemoRemove.Enabled = false;
            btnMemoClear.Enabled = false;
            btnMemoDisplay.Enabled = false;
        }

        // removing memory
        private void btnMemoRemove_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDouble(lblResult.Text);
            lblResult.Text = Convert.ToString(memory);
        }

        // Button Delete Forward 
        private void btnDeleteFow_Click(object sender, EventArgs e)
        {
            Int16 indx = Convert.ToInt16(lblResult.Text.Length);
            lblResult.Text = lblResult.Text.Substring(0 , indx-1); 
        }

        // Recall memory
        private void btnMemoRecall_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(memory);
        }

        // Button coma
        private void btnComma_Click(object sender, EventArgs e)
        {
            lblResult.Text += ",";
        }
        #endregion

        #region Switch case operations
        //Switch case to do basic operations
        private void btnEqual_Click(object sender, EventArgs e)
        {   // Switch Cases           
            switch (operation)
            {   //Addition
                case "+":
                    {
                        number2 = Convert.ToDouble(lblResult.Text);
                        lblSecondDisplay.Text += lblResult.Text + " = ";
                        result = number1 + number2;
                        lblResult.Text = Convert.ToString(result);
                        break;
                    }
                //Subtraction
                case "-":
                    {
                        number2 = Convert.ToDouble(lblResult.Text);
                        lblSecondDisplay.Text += lblResult.Text + " = ";
                        result = number1 - number2;
                        lblResult.Text = Convert.ToString(result);
                        break;
                    }
                // Multiplication
                case "*":
                    {
                        number2 = Convert.ToDouble(lblResult.Text);
                        if (percOperation == false)
                        {
                            lblSecondDisplay.Text += lblResult.Text + " = ";
                            result = number1 * number2;
                            lblResult.Text = Convert.ToString(result);
                        }
                        else
                        {
                            lblSecondDisplay.Text += Convert.ToString(number2 / 100) + "=";
                            result = (number1 * number2) / 100;
                            lblResult.Text = Convert.ToString(result);
                            percOperation = false; // Restart operation percentage to false
                        }
                        break;
                    }
                // Division
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
        #endregion
    }
}