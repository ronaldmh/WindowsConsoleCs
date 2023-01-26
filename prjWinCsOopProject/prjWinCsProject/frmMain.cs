using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void estandarCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new object from the class frmEstandarCalculator
            frmStandardCalculator frmOp = new frmStandardCalculator();
            frmOp.Show();            
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the program ?",
               "Closing Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Form Standard Calculator
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Create a new object from the class frmEstandarCalculator
            frmStandardCalculator frmOp = new frmStandardCalculator();
            frmOp.Show();            
        }
        // Form About Us
        private void aboutOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new object from the class frmEstandarCalculator
            frmAboutUs frmOp = new frmAboutUs();
            frmOp.Show();            
        }
        // Form Scientific
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmScientificCalculator frmOp = new frmScientificCalculator();
            frmOp.Show();
        }
        // Form Scientific
        private void scientificCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScientificCalculator frmOp = new frmScientificCalculator();
            frmOp.Show();
        }
        // Form User´s Manual 
        private void usersManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManual frmOp = new frmUserManual();
            frmOp.Show();            
        }
        
        // Form Exchange
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmChange frmOp = new frmChange();
            frmOp.Show();
        }

        private void moneyExchangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChange frmOp = new frmChange();
            frmOp.Show();
        }
    }
}
