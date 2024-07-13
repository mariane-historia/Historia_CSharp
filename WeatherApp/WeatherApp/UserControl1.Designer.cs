using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;  // Make sure the namespace matches your Bunifu version

namespace WeatherApp
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            bunifuThinButton2 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(109, 205);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 16);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "bunifuLabel1";
            // 
            // bunifuThinButton2
            // 
            this.bunifuThinButton2.ActiveBorderThickness = 1;
            this.bunifuThinButton2.ActiveCornerRadius = 20;
            this.bunifuThinButton2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton2.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton2.BackgroundImage")));
            this.bunifuThinButton2.ButtonText = "ThinButton";
            this.bunifuThinButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton2.IdleBorderThickness = 1;
            this.bunifuThinButton2.IdleCornerRadius = 20;
            this.bunifuThinButton2.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton2.Location = new System.Drawing.Point(211, 299);
            this.bunifuThinButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton2.Name = "bunifuThinButton2";
            this.bunifuThinButton2.Size = new System.Drawing.Size(225, 42);
            this.bunifuThinButton2.TabIndex = 1;
            this.bunifuThinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(121, 77);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(281, 75);
            this.bunifuTextbox1.TabIndex = 2;
            this.bunifuTextbox1.text = "search a city";
            // 
            // UserControl1
            // 
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.bunifuThinButton2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(782, 379);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton2;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
    }
}
