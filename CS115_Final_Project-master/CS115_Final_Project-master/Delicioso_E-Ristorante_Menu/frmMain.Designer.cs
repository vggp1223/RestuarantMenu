/* Carlos E. Gonzalez
 * Danessa Yip
 * Virginia Gonzalez
 * 
 * Final Project - Delicioso E-Ristorante Menu
 * 05/28/2021
 */

namespace Delicioso_E_Ristorante_Menu
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbxMenuOptions = new System.Windows.Forms.GroupBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.gbxViewPayment = new System.Windows.Forms.GroupBox();
            this.btnSubmitPayment = new System.Windows.Forms.Button();
            this.btnViewReceipt = new System.Windows.Forms.Button();
            this.picTotal = new System.Windows.Forms.PictureBox();
            this.gbxMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.gbxViewPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMenuOptions
            // 
            this.gbxMenuOptions.Controls.Add(this.btnSubmitOrder);
            this.gbxMenuOptions.Controls.Add(this.btnViewMenu);
            this.gbxMenuOptions.Controls.Add(this.picMenu);
            this.gbxMenuOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMenuOptions.Location = new System.Drawing.Point(0, 6);
            this.gbxMenuOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gbxMenuOptions.Name = "gbxMenuOptions";
            this.gbxMenuOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gbxMenuOptions.Size = new System.Drawing.Size(282, 364);
            this.gbxMenuOptions.TabIndex = 0;
            this.gbxMenuOptions.TabStop = false;
            this.gbxMenuOptions.Text = "View Menu and Submit Order";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(33, 268);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(210, 59);
            this.btnSubmitOrder.TabIndex = 6;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.Location = new System.Drawing.Point(33, 199);
            this.btnViewMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(210, 59);
            this.btnViewMenu.TabIndex = 5;
            this.btnViewMenu.Text = "View Menu";
            this.btnViewMenu.UseVisualStyleBackColor = true;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // picMenu
            // 
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(60, 32);
            this.picMenu.Margin = new System.Windows.Forms.Padding(2);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(150, 152);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            // 
            // gbxViewPayment
            // 
            this.gbxViewPayment.Controls.Add(this.btnSubmitPayment);
            this.gbxViewPayment.Controls.Add(this.btnViewReceipt);
            this.gbxViewPayment.Controls.Add(this.picTotal);
            this.gbxViewPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxViewPayment.Location = new System.Drawing.Point(286, 6);
            this.gbxViewPayment.Margin = new System.Windows.Forms.Padding(2);
            this.gbxViewPayment.Name = "gbxViewPayment";
            this.gbxViewPayment.Padding = new System.Windows.Forms.Padding(2);
            this.gbxViewPayment.Size = new System.Drawing.Size(280, 364);
            this.gbxViewPayment.TabIndex = 1;
            this.gbxViewPayment.TabStop = false;
            this.gbxViewPayment.Text = "View Receipt and Submit Payment";
            // 
            // btnSubmitPayment
            // 
            this.btnSubmitPayment.Location = new System.Drawing.Point(39, 268);
            this.btnSubmitPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitPayment.Name = "btnSubmitPayment";
            this.btnSubmitPayment.Size = new System.Drawing.Size(210, 59);
            this.btnSubmitPayment.TabIndex = 4;
            this.btnSubmitPayment.Text = "Submit Payment";
            this.btnSubmitPayment.UseVisualStyleBackColor = true;
            this.btnSubmitPayment.Click += new System.EventHandler(this.btnSubmitPayment_Click);
            // 
            // btnViewReceipt
            // 
            this.btnViewReceipt.Location = new System.Drawing.Point(39, 197);
            this.btnViewReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewReceipt.Name = "btnViewReceipt";
            this.btnViewReceipt.Size = new System.Drawing.Size(210, 59);
            this.btnViewReceipt.TabIndex = 3;
            this.btnViewReceipt.Text = "View Receipt";
            this.btnViewReceipt.UseVisualStyleBackColor = true;
            this.btnViewReceipt.Click += new System.EventHandler(this.btnViewReceipt_Click);
            // 
            // picTotal
            // 
            this.picTotal.Image = ((System.Drawing.Image)(resources.GetObject("picTotal.Image")));
            this.picTotal.Location = new System.Drawing.Point(68, 32);
            this.picTotal.Margin = new System.Windows.Forms.Padding(2);
            this.picTotal.Name = "picTotal";
            this.picTotal.Size = new System.Drawing.Size(150, 152);
            this.picTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTotal.TabIndex = 1;
            this.picTotal.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 376);
            this.Controls.Add(this.gbxViewPayment);
            this.Controls.Add(this.gbxMenuOptions);
            this.Name = "frmMain";
            this.Text = "Delicioso E-Ristorante Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.gbxViewPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMenuOptions;
        private System.Windows.Forms.GroupBox gbxViewPayment;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnViewMenu;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnSubmitPayment;
        private System.Windows.Forms.Button btnViewReceipt;
        private System.Windows.Forms.PictureBox picTotal;
    }
}

