
namespace Delicioso_E_Ristorante_Menu
{
    partial class frmSplashWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashWindow));
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.lblLoadingScreen = new System.Windows.Forms.Label();
            this.picRestaurant = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSplash
            // 
            this.tmrSplash.Interval = 1000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // lblLoadingScreen
            // 
            this.lblLoadingScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoadingScreen.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoadingScreen.Location = new System.Drawing.Point(311, 442);
            this.lblLoadingScreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoadingScreen.Name = "lblLoadingScreen";
            this.lblLoadingScreen.Size = new System.Drawing.Size(178, 31);
            this.lblLoadingScreen.TabIndex = 7;
            this.lblLoadingScreen.Text = "Now loading...";
            this.lblLoadingScreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picRestaurant
            // 
            this.picRestaurant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRestaurant.Image = ((System.Drawing.Image)(resources.GetObject("picRestaurant.Image")));
            this.picRestaurant.Location = new System.Drawing.Point(150, 74);
            this.picRestaurant.Margin = new System.Windows.Forms.Padding(2);
            this.picRestaurant.Name = "picRestaurant";
            this.picRestaurant.Size = new System.Drawing.Size(500, 347);
            this.picRestaurant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestaurant.TabIndex = 6;
            this.picRestaurant.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(24, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(753, 37);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Welcome to the Delicioso E-Ristorante Restaurante!";
            // 
            // frmSplashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoadingScreen);
            this.Controls.Add(this.picRestaurant);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashWindow";
            this.Text = "Splash Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSplashWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblLoadingScreen;
        private System.Windows.Forms.PictureBox picRestaurant;
        private System.Windows.Forms.Label lblTitle;
    }
}