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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxViewPayment = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbxMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.gbxViewPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMenuOptions
            // 
            this.gbxMenuOptions.Controls.Add(this.button2);
            this.gbxMenuOptions.Controls.Add(this.button1);
            this.gbxMenuOptions.Controls.Add(this.picMenu);
            this.gbxMenuOptions.Controls.Add(this.groupBox2);
            this.gbxMenuOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMenuOptions.Location = new System.Drawing.Point(12, 12);
            this.gbxMenuOptions.Name = "gbxMenuOptions";
            this.gbxMenuOptions.Size = new System.Drawing.Size(788, 841);
            this.gbxMenuOptions.TabIndex = 0;
            this.gbxMenuOptions.TabStop = false;
            this.gbxMenuOptions.Text = "Menu Options";
            this.gbxMenuOptions.Enter += new System.EventHandler(this.gbxMenuOptions_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(248, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 108);
            this.button2.TabIndex = 4;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 108);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picMenu
            // 
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(142, 40);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(492, 470);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 2;
            this.picMenu.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(793, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 841);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbxViewPayment
            // 
            this.gbxViewPayment.Controls.Add(this.button3);
            this.gbxViewPayment.Controls.Add(this.button4);
            this.gbxViewPayment.Controls.Add(this.pictureBox1);
            this.gbxViewPayment.Controls.Add(this.groupBox3);
            this.gbxViewPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxViewPayment.Location = new System.Drawing.Point(807, 12);
            this.gbxViewPayment.Name = "gbxViewPayment";
            this.gbxViewPayment.Size = new System.Drawing.Size(788, 841);
            this.gbxViewPayment.TabIndex = 5;
            this.gbxViewPayment.TabStop = false;
            this.gbxViewPayment.Text = "Payment";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(248, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 108);
            this.button3.TabIndex = 4;
            this.button3.Text = "Submit Order";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(248, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 108);
            this.button4.TabIndex = 3;
            this.button4.Text = "View Receipt #Also include file in and file out";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(793, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(796, 841);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.gbxViewPayment);
            this.Controls.Add(this.gbxMenuOptions);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Delicioso E-Ristorante Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.gbxViewPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMenuOptions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.GroupBox gbxViewPayment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

