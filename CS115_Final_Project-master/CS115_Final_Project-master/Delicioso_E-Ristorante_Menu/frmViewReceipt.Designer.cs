
namespace Delicioso_E_Ristorante_Menu
{
    partial class frmViewReceipt
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
            this.lstItemizedBill = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblSalesTaxesValue = new System.Windows.Forms.Label();
            this.lblSalesTaxes = new System.Windows.Forms.Label();
            this.gbxTips = new System.Windows.Forms.GroupBox();
            this.btnComfirmTip = new System.Windows.Forms.Button();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.radTwentyFivePercent = new System.Windows.Forms.RadioButton();
            this.radFifteenPercent = new System.Windows.Forms.RadioButton();
            this.radTenPercent = new System.Windows.Forms.RadioButton();
            this.radFivePercent = new System.Windows.Forms.RadioButton();
            this.radNoTip = new System.Windows.Forms.RadioButton();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTipValue = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.gbxTips.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstItemizedBill
            // 
            this.lstItemizedBill.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemizedBill.FormattingEnabled = true;
            this.lstItemizedBill.ItemHeight = 15;
            this.lstItemizedBill.Location = new System.Drawing.Point(12, 12);
            this.lstItemizedBill.Name = "lstItemizedBill";
            this.lstItemizedBill.Size = new System.Drawing.Size(400, 379);
            this.lstItemizedBill.TabIndex = 0;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(14, 403);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalValue.Location = new System.Drawing.Point(304, 403);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(58, 20);
            this.lblSubtotalValue.TabIndex = 2;
            this.lblSubtotalValue.Text = "$00.00";
            // 
            // lblSalesTaxesValue
            // 
            this.lblSalesTaxesValue.AutoSize = true;
            this.lblSalesTaxesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTaxesValue.Location = new System.Drawing.Point(304, 435);
            this.lblSalesTaxesValue.Name = "lblSalesTaxesValue";
            this.lblSalesTaxesValue.Size = new System.Drawing.Size(58, 20);
            this.lblSalesTaxesValue.TabIndex = 4;
            this.lblSalesTaxesValue.Text = "$00.00";
            // 
            // lblSalesTaxes
            // 
            this.lblSalesTaxes.AutoSize = true;
            this.lblSalesTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTaxes.Location = new System.Drawing.Point(14, 435);
            this.lblSalesTaxes.Name = "lblSalesTaxes";
            this.lblSalesTaxes.Size = new System.Drawing.Size(99, 20);
            this.lblSalesTaxes.TabIndex = 3;
            this.lblSalesTaxes.Text = "Sales Taxes:";
            // 
            // gbxTips
            // 
            this.gbxTips.Controls.Add(this.btnComfirmTip);
            this.gbxTips.Controls.Add(this.txtTipAmount);
            this.gbxTips.Controls.Add(this.radOther);
            this.gbxTips.Controls.Add(this.radTwentyFivePercent);
            this.gbxTips.Controls.Add(this.radFifteenPercent);
            this.gbxTips.Controls.Add(this.radTenPercent);
            this.gbxTips.Controls.Add(this.radFivePercent);
            this.gbxTips.Controls.Add(this.radNoTip);
            this.gbxTips.Location = new System.Drawing.Point(13, 472);
            this.gbxTips.Name = "gbxTips";
            this.gbxTips.Size = new System.Drawing.Size(400, 112);
            this.gbxTips.TabIndex = 5;
            this.gbxTips.TabStop = false;
            this.gbxTips.Text = "Tipping";
            // 
            // btnComfirmTip
            // 
            this.btnComfirmTip.Enabled = false;
            this.btnComfirmTip.Location = new System.Drawing.Point(267, 58);
            this.btnComfirmTip.Name = "btnComfirmTip";
            this.btnComfirmTip.Size = new System.Drawing.Size(112, 23);
            this.btnComfirmTip.TabIndex = 7;
            this.btnComfirmTip.Text = "Comfirm Tip";
            this.btnComfirmTip.UseVisualStyleBackColor = true;
            this.btnComfirmTip.Click += new System.EventHandler(this.btnComfirmTip_Click);
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Enabled = false;
            this.txtTipAmount.Location = new System.Drawing.Point(267, 28);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(112, 20);
            this.txtTipAmount.TabIndex = 6;
            this.txtTipAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Location = new System.Drawing.Point(168, 61);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(93, 17);
            this.radOther.TabIndex = 5;
            this.radOther.Text = "Other Amount:";
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // radTwentyFivePercent
            // 
            this.radTwentyFivePercent.AutoSize = true;
            this.radTwentyFivePercent.Location = new System.Drawing.Point(168, 29);
            this.radTwentyFivePercent.Name = "radTwentyFivePercent";
            this.radTwentyFivePercent.Size = new System.Drawing.Size(45, 17);
            this.radTwentyFivePercent.TabIndex = 4;
            this.radTwentyFivePercent.Text = "25%";
            this.radTwentyFivePercent.UseVisualStyleBackColor = true;
            this.radTwentyFivePercent.CheckedChanged += new System.EventHandler(this.radTwentyFivePercent_CheckedChanged);
            // 
            // radFifteenPercent
            // 
            this.radFifteenPercent.AutoSize = true;
            this.radFifteenPercent.Location = new System.Drawing.Point(89, 61);
            this.radFifteenPercent.Name = "radFifteenPercent";
            this.radFifteenPercent.Size = new System.Drawing.Size(45, 17);
            this.radFifteenPercent.TabIndex = 3;
            this.radFifteenPercent.Text = "15%";
            this.radFifteenPercent.UseVisualStyleBackColor = true;
            this.radFifteenPercent.CheckedChanged += new System.EventHandler(this.radFifteenPercent_CheckedChanged);
            // 
            // radTenPercent
            // 
            this.radTenPercent.AutoSize = true;
            this.radTenPercent.Location = new System.Drawing.Point(89, 29);
            this.radTenPercent.Name = "radTenPercent";
            this.radTenPercent.Size = new System.Drawing.Size(45, 17);
            this.radTenPercent.TabIndex = 2;
            this.radTenPercent.Text = "10%";
            this.radTenPercent.UseVisualStyleBackColor = true;
            this.radTenPercent.CheckedChanged += new System.EventHandler(this.radTenPercent_CheckedChanged);
            // 
            // radFivePercent
            // 
            this.radFivePercent.AutoSize = true;
            this.radFivePercent.Location = new System.Drawing.Point(6, 61);
            this.radFivePercent.Name = "radFivePercent";
            this.radFivePercent.Size = new System.Drawing.Size(39, 17);
            this.radFivePercent.TabIndex = 1;
            this.radFivePercent.Text = "5%";
            this.radFivePercent.UseVisualStyleBackColor = true;
            this.radFivePercent.CheckedChanged += new System.EventHandler(this.radFivePercent_CheckedChanged);
            // 
            // radNoTip
            // 
            this.radNoTip.AutoSize = true;
            this.radNoTip.Checked = true;
            this.radNoTip.Location = new System.Drawing.Point(6, 29);
            this.radNoTip.Name = "radNoTip";
            this.radNoTip.Size = new System.Drawing.Size(57, 17);
            this.radNoTip.TabIndex = 0;
            this.radNoTip.TabStop = true;
            this.radNoTip.Text = "No Tip";
            this.radNoTip.UseVisualStyleBackColor = true;
            this.radNoTip.CheckedChanged += new System.EventHandler(this.radNoTip_CheckedChanged);
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(304, 636);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(58, 20);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.Text = "$00.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(14, 636);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblTipValue
            // 
            this.lblTipValue.AutoSize = true;
            this.lblTipValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipValue.Location = new System.Drawing.Point(304, 603);
            this.lblTipValue.Name = "lblTipValue";
            this.lblTipValue.Size = new System.Drawing.Size(58, 20);
            this.lblTipValue.TabIndex = 9;
            this.lblTipValue.Text = "$00.00";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(14, 603);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(34, 20);
            this.lblTip.TabIndex = 8;
            this.lblTip.Text = "Tip:";
            // 
            // frmViewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 684);
            this.Controls.Add(this.lblTipValue);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbxTips);
            this.Controls.Add(this.lblSalesTaxesValue);
            this.Controls.Add(this.lblSalesTaxes);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lstItemizedBill);
            this.Name = "frmViewReceipt";
            this.Text = "View Receipt";
            this.Load += new System.EventHandler(this.frmViewReceipt_Load);
            this.gbxTips.ResumeLayout(false);
            this.gbxTips.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblSalesTaxesValue;
        private System.Windows.Forms.Label lblSalesTaxes;
        private System.Windows.Forms.GroupBox gbxTips;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnComfirmTip;
        private System.Windows.Forms.Label lblTipValue;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton radTwentyFivePercent;
        private System.Windows.Forms.RadioButton radFifteenPercent;
        private System.Windows.Forms.RadioButton radTenPercent;
        private System.Windows.Forms.RadioButton radFivePercent;
        private System.Windows.Forms.RadioButton radNoTip;
        public System.Windows.Forms.ListBox lstItemizedBill;
    }
}