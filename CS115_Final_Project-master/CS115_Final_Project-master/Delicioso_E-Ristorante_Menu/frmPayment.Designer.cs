
namespace Delicioso_E_Ristorante_Menu
{
    partial class frmPayment
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
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.lblPaymentChoiceInstructions = new System.Windows.Forms.Label();
            this.btnSelectPaymentMethod = new System.Windows.Forms.Button();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.radDebit = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.gbxCardDetails = new System.Windows.Forms.GroupBox();
            this.lblExpYear = new System.Windows.Forms.Label();
            this.cmbxExpYear = new System.Windows.Forms.ComboBox();
            this.cmbxExpMonth = new System.Windows.Forms.ComboBox();
            this.lblExpMonth = new System.Windows.Forms.Label();
            this.btnSubmitPayment = new System.Windows.Forms.Button();
            this.txtPinNumber = new System.Windows.Forms.TextBox();
            this.lblPinNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCardInfoInstructions = new System.Windows.Forms.Label();
            this.gbxPayment.SuspendLayout();
            this.gbxCardDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPayment
            // 
            this.gbxPayment.BackColor = System.Drawing.SystemColors.Control;
            this.gbxPayment.Controls.Add(this.lblPaymentChoiceInstructions);
            this.gbxPayment.Controls.Add(this.btnSelectPaymentMethod);
            this.gbxPayment.Controls.Add(this.radCredit);
            this.gbxPayment.Controls.Add(this.radDebit);
            this.gbxPayment.Controls.Add(this.radCash);
            this.gbxPayment.Location = new System.Drawing.Point(13, 13);
            this.gbxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPayment.Size = new System.Drawing.Size(235, 295);
            this.gbxPayment.TabIndex = 0;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Payment Options";
            // 
            // lblPaymentChoiceInstructions
            // 
            this.lblPaymentChoiceInstructions.Location = new System.Drawing.Point(17, 34);
            this.lblPaymentChoiceInstructions.Name = "lblPaymentChoiceInstructions";
            this.lblPaymentChoiceInstructions.Size = new System.Drawing.Size(201, 48);
            this.lblPaymentChoiceInstructions.TabIndex = 5;
            this.lblPaymentChoiceInstructions.Text = "Please choose one of the following payment options:";
            // 
            // btnSelectPaymentMethod
            // 
            this.btnSelectPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPaymentMethod.Location = new System.Drawing.Point(48, 206);
            this.btnSelectPaymentMethod.Name = "btnSelectPaymentMethod";
            this.btnSelectPaymentMethod.Size = new System.Drawing.Size(139, 60);
            this.btnSelectPaymentMethod.TabIndex = 4;
            this.btnSelectPaymentMethod.Text = "Select Payment Method";
            this.btnSelectPaymentMethod.UseVisualStyleBackColor = true;
            this.btnSelectPaymentMethod.Click += new System.EventHandler(this.btnSubmitPaymentMethod_Click);
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Location = new System.Drawing.Point(48, 125);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(65, 22);
            this.radCredit.TabIndex = 3;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit";
            this.radCredit.UseVisualStyleBackColor = true;
            // 
            // radDebit
            // 
            this.radDebit.AutoSize = true;
            this.radDebit.Location = new System.Drawing.Point(48, 165);
            this.radDebit.Name = "radDebit";
            this.radDebit.Size = new System.Drawing.Size(60, 22);
            this.radDebit.TabIndex = 2;
            this.radDebit.TabStop = true;
            this.radDebit.Text = "Debit";
            this.radDebit.UseVisualStyleBackColor = true;
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(48, 85);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(61, 22);
            this.radCash.TabIndex = 1;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // gbxCardDetails
            // 
            this.gbxCardDetails.Controls.Add(this.lblExpYear);
            this.gbxCardDetails.Controls.Add(this.cmbxExpYear);
            this.gbxCardDetails.Controls.Add(this.cmbxExpMonth);
            this.gbxCardDetails.Controls.Add(this.lblExpMonth);
            this.gbxCardDetails.Controls.Add(this.btnSubmitPayment);
            this.gbxCardDetails.Controls.Add(this.txtPinNumber);
            this.gbxCardDetails.Controls.Add(this.lblPinNumber);
            this.gbxCardDetails.Controls.Add(this.txtCardNumber);
            this.gbxCardDetails.Controls.Add(this.lblExpDate);
            this.gbxCardDetails.Controls.Add(this.lblCardNumber);
            this.gbxCardDetails.Controls.Add(this.lblCardInfoInstructions);
            this.gbxCardDetails.Location = new System.Drawing.Point(267, 12);
            this.gbxCardDetails.Name = "gbxCardDetails";
            this.gbxCardDetails.Size = new System.Drawing.Size(344, 296);
            this.gbxCardDetails.TabIndex = 1;
            this.gbxCardDetails.TabStop = false;
            this.gbxCardDetails.Text = "Card Details";
            this.gbxCardDetails.Visible = false;
            // 
            // lblExpYear
            // 
            this.lblExpYear.AutoSize = true;
            this.lblExpYear.Location = new System.Drawing.Point(241, 100);
            this.lblExpYear.Name = "lblExpYear";
            this.lblExpYear.Size = new System.Drawing.Size(38, 18);
            this.lblExpYear.TabIndex = 12;
            this.lblExpYear.Text = "Year";
            // 
            // cmbxExpYear
            // 
            this.cmbxExpYear.FormattingEnabled = true;
            this.cmbxExpYear.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.cmbxExpYear.Location = new System.Drawing.Point(231, 121);
            this.cmbxExpYear.Name = "cmbxExpYear";
            this.cmbxExpYear.Size = new System.Drawing.Size(59, 26);
            this.cmbxExpYear.TabIndex = 11;
            // 
            // cmbxExpMonth
            // 
            this.cmbxExpMonth.FormattingEnabled = true;
            this.cmbxExpMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbxExpMonth.Location = new System.Drawing.Point(153, 121);
            this.cmbxExpMonth.Name = "cmbxExpMonth";
            this.cmbxExpMonth.Size = new System.Drawing.Size(62, 26);
            this.cmbxExpMonth.TabIndex = 10;
            // 
            // lblExpMonth
            // 
            this.lblExpMonth.AutoSize = true;
            this.lblExpMonth.Location = new System.Drawing.Point(159, 100);
            this.lblExpMonth.Name = "lblExpMonth";
            this.lblExpMonth.Size = new System.Drawing.Size(50, 18);
            this.lblExpMonth.TabIndex = 8;
            this.lblExpMonth.Text = "Month";
            // 
            // btnSubmitPayment
            // 
            this.btnSubmitPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPayment.Location = new System.Drawing.Point(104, 207);
            this.btnSubmitPayment.Name = "btnSubmitPayment";
            this.btnSubmitPayment.Size = new System.Drawing.Size(142, 60);
            this.btnSubmitPayment.TabIndex = 7;
            this.btnSubmitPayment.Text = "Submit Payment";
            this.btnSubmitPayment.UseVisualStyleBackColor = true;
            this.btnSubmitPayment.Click += new System.EventHandler(this.btnSubmitPayment_Click);
            // 
            // txtPinNumber
            // 
            this.txtPinNumber.Location = new System.Drawing.Point(144, 166);
            this.txtPinNumber.MaxLength = 3;
            this.txtPinNumber.Name = "txtPinNumber";
            this.txtPinNumber.Size = new System.Drawing.Size(159, 24);
            this.txtPinNumber.TabIndex = 6;
            this.txtPinNumber.Visible = false;
            // 
            // lblPinNumber
            // 
            this.lblPinNumber.AutoSize = true;
            this.lblPinNumber.Location = new System.Drawing.Point(22, 166);
            this.lblPinNumber.Name = "lblPinNumber";
            this.lblPinNumber.Size = new System.Drawing.Size(86, 18);
            this.lblPinNumber.TabIndex = 5;
            this.lblPinNumber.Text = "Pin Number";
            this.lblPinNumber.Visible = false;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(144, 62);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(159, 24);
            this.txtCardNumber.TabIndex = 3;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(22, 124);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(112, 18);
            this.lblExpDate.TabIndex = 2;
            this.lblExpDate.Text = "Expiration Date ";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(22, 65);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(97, 18);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblCardInfoInstructions
            // 
            this.lblCardInfoInstructions.AutoSize = true;
            this.lblCardInfoInstructions.Location = new System.Drawing.Point(22, 34);
            this.lblCardInfoInstructions.Name = "lblCardInfoInstructions";
            this.lblCardInfoInstructions.Size = new System.Drawing.Size(291, 18);
            this.lblCardInfoInstructions.TabIndex = 0;
            this.lblCardInfoInstructions.Text = "Please enter the following card information:";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 321);
            this.Controls.Add(this.gbxCardDetails);
            this.Controls.Add(this.gbxPayment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPayment";
            this.Text = "Submit Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.gbxCardDetails.ResumeLayout(false);
            this.gbxCardDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.Button btnSelectPaymentMethod;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.RadioButton radDebit;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.Label lblPaymentChoiceInstructions;
        private System.Windows.Forms.GroupBox gbxCardDetails;
        private System.Windows.Forms.Label lblCardInfoInstructions;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtPinNumber;
        private System.Windows.Forms.Label lblPinNumber;
        private System.Windows.Forms.Button btnSubmitPayment;
        private System.Windows.Forms.ComboBox cmbxExpYear;
        private System.Windows.Forms.ComboBox cmbxExpMonth;
        private System.Windows.Forms.Label lblExpMonth;
        private System.Windows.Forms.Label lblExpYear;
    }
}