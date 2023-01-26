namespace prjWinCsProject
{
    partial class frmChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radToDollar = new System.Windows.Forms.RadioButton();
            this.radDollarTo = new System.Windows.Forms.RadioButton();
            this.lblDollarToCurrency = new System.Windows.Forms.Label();
            this.lblCurrencyToDolar = new System.Windows.Forms.Label();
            this.lblCurrencySelected = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(311, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Money Exchange";
            // 
            // cboCountries
            // 
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(36, 109);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(297, 24);
            this.cboCountries.TabIndex = 1;
            this.cboCountries.Text = "Select Country";
            this.cboCountries.SelectedIndexChanged += new System.EventHandler(this.cboCountries_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radToDollar);
            this.groupBox1.Controls.Add(this.radDollarTo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Convertion";
            // 
            // radToDollar
            // 
            this.radToDollar.AutoSize = true;
            this.radToDollar.Location = new System.Drawing.Point(31, 84);
            this.radToDollar.Name = "radToDollar";
            this.radToDollar.Size = new System.Drawing.Size(17, 16);
            this.radToDollar.TabIndex = 1;
            this.radToDollar.UseVisualStyleBackColor = true;
            // 
            // radDollarTo
            // 
            this.radDollarTo.AutoSize = true;
            this.radDollarTo.Location = new System.Drawing.Point(31, 45);
            this.radDollarTo.Name = "radDollarTo";
            this.radDollarTo.Size = new System.Drawing.Size(17, 16);
            this.radDollarTo.TabIndex = 0;
            this.radDollarTo.UseVisualStyleBackColor = true;
            this.radDollarTo.CheckedChanged += new System.EventHandler(this.radDollarTo_CheckedChanged);
            // 
            // lblDollarToCurrency
            // 
            this.lblDollarToCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDollarToCurrency.Location = new System.Drawing.Point(465, 120);
            this.lblDollarToCurrency.Name = "lblDollarToCurrency";
            this.lblDollarToCurrency.Size = new System.Drawing.Size(371, 43);
            this.lblDollarToCurrency.TabIndex = 3;
            // 
            // lblCurrencyToDolar
            // 
            this.lblCurrencyToDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrencyToDolar.Location = new System.Drawing.Point(465, 178);
            this.lblCurrencyToDolar.Name = "lblCurrencyToDolar";
            this.lblCurrencyToDolar.Size = new System.Drawing.Size(371, 43);
            this.lblCurrencyToDolar.TabIndex = 4;
            // 
            // lblCurrencySelected
            // 
            this.lblCurrencySelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrencySelected.Location = new System.Drawing.Point(500, 247);
            this.lblCurrencySelected.Name = "lblCurrencySelected";
            this.lblCurrencySelected.Size = new System.Drawing.Size(180, 43);
            this.lblCurrencySelected.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(51, 399);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(199, 43);
            this.lblResult.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(729, 247);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(127, 38);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(729, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(729, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(500, 317);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 22);
            this.txtAmount.TabIndex = 10;
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 456);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCurrencySelected);
            this.Controls.Add(this.lblCurrencyToDolar);
            this.Controls.Add(this.lblDollarToCurrency);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboCountries);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmChange";
            this.Text = "frmChange";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboCountries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radToDollar;
        private System.Windows.Forms.RadioButton radDollarTo;
        private System.Windows.Forms.Label lblDollarToCurrency;
        private System.Windows.Forms.Label lblCurrencyToDolar;
        private System.Windows.Forms.Label lblCurrencySelected;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAmount;
    }
}