using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsProject
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }

        // Declaration of structure 
        struct CurrentConvertion
        {
            public string Country;
            public string Currency;
            public double RateChange;
        }

        // Declaration of Array structure
        CurrentConvertion[] tabOptionCurrencies = new CurrentConvertion[5];

        static Int16 nbCountries;

        private void ReadCountriesToFillArray()
        {
            StreamReader myfile = new StreamReader("Countries.txt");
            Int16 i = 0;
            while (myfile.EndOfStream == false)
            {
                tabOptionCurrencies[i].Country = myfile.ReadLine();
                tabOptionCurrencies[i].Currency = myfile.ReadLine();
                tabOptionCurrencies[i].RateChange = Convert.ToDouble(myfile.ReadLine()) / 100;

                // To fill the comboBox en each iteration read
                cboCountries.Items.Add(tabOptionCurrencies[i].Country);

                i++;
            }
            myfile.Close();
            nbCountries = i;

        }

        private void frmChange_Load(object sender, EventArgs e)
        {
            ReadCountriesToFillArray();
        }

        private void cboCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cboCountries.SelectedItem.ToString();

            for (Int16 i = 0; i < nbCountries; i++)
            {
                if (country == tabOptionCurrencies[i].Country)
                {
                    radDollarTo.Text = "US Dollar to " + tabOptionCurrencies[i].Currency;
                    radToDollar.Text = tabOptionCurrencies[i].Currency + " to US Dollar";

                    lblDollarToCurrency.Text = "1 Us Dollar = " + tabOptionCurrencies[i].RateChange + " " + tabOptionCurrencies[i].Currency;

                    lblCurrencyToDolar.Text = "1 " + tabOptionCurrencies[i].Currency + " = " + Math.Round((1 / tabOptionCurrencies[i].RateChange), 3) + " US Dollar";
                       
                }

            }
        }


        private void radDollarTo_CheckedChanged(object sender, EventArgs e)
        {
            string country = cboCountries.SelectedItem.ToString();

            for (Int16 i = 0; i < nbCountries; i++)
            {
                if (country == tabOptionCurrencies[i].Country)
                {

                    if (radDollarTo.Checked)
                    {
                        lblCurrencySelected.Text = "US Dollar";
                        
                    }
                    else if(radToDollar.Checked)
                    {
                        lblCurrencySelected.Text = tabOptionCurrencies[i].Currency;
                    }

                }

            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string country = cboCountries.SelectedItem.ToString();
            double amount, rate,convertion;
            if (radDollarTo.Checked || radToDollar.Checked)
            {
                for (Int16 i = 0; i < nbCountries; i++)
                {
                    if (country == tabOptionCurrencies[i].Country)
                    {
                        rate = tabOptionCurrencies[i].RateChange;

                        if (txtAmount.Text != "")
                        {
                            amount = Convert.ToDouble(txtAmount.Text);
                            if (amount != 0)
                            {
                                if (radDollarTo.Checked)
                                {
                                    convertion = Math.Round((amount * rate), 3);
                                    lblResult.Text = convertion + " " + tabOptionCurrencies[i].Currency + "(s)";
                                }
                                else if (radToDollar.Checked)
                                {
                                    convertion = Math.Round((amount / rate), 3);
                                    lblResult.Text = convertion + " Dollar(s)";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter a positive value");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter an amount");
                        }

                    }

            }
            }
            
            else
            {
                MessageBox.Show("Select a type of convertion");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDollarToCurrency.Text = "";
            lblCurrencyToDolar.Text = "";
            lblCurrencySelected.Text = "";
            lblResult.Text = "";
            txtAmount.Text = "";
            cboCountries.Text = "";
            radDollarTo.Checked = false;
            radToDollar.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the program ?","Closing Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
