using System.Windows.Forms;

namespace Weather
{
    partial class Form1
    {
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.PictureBox picIcon2;
        private Bunifu.Framework.UI.BunifuCustomLabel labDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel labTemp; 
        private Bunifu.Framework.UI.BunifuCustomLabel labHumidity; 
        private Bunifu.Framework.UI.BunifuCustomLabel labCloudiness; 
        private Bunifu.Framework.UI.BunifuCustomLabel labWindSpeed;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;

        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuCustomLabel labDetails2;
        private Bunifu.Framework.UI.BunifuCustomLabel labTemp2;
        private Bunifu.Framework.UI.BunifuCustomLabel labHumidity2;
        private Bunifu.Framework.UI.BunifuCustomLabel labCloudiness2;
        private Bunifu.Framework.UI.BunifuCustomLabel labWindSpeed2;



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.picIcon2 = new System.Windows.Forms.PictureBox();
            this.labDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labTemp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labHumidity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labCloudiness = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labWindSpeed = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Temperature = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTextbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.labDetails2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labTemp2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labHumidity2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labCloudiness2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labWindSpeed2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon2)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuThinButton21.ButtonText = "Get Weather";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(14, 73);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(211, 44);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(14, 19);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(211, 45);
            this.bunifuTextbox1.TabIndex = 2;
            this.bunifuTextbox1.text = "";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picIcon.Location = new System.Drawing.Point(234, 18);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(161, 98);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 4;
            this.picIcon.TabStop = false;
            // 
            // picIcon2
            // 
            this.picIcon2.BackColor = System.Drawing.Color.Transparent;
            this.picIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picIcon2.Location = new System.Drawing.Point(240, 18);
            this.picIcon2.Name = "picIcon2";
            this.picIcon2.Size = new System.Drawing.Size(148, 99);
            this.picIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon2.TabIndex = 31;
            this.picIcon2.TabStop = false;
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("HP Simplified Hans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.Location = new System.Drawing.Point(155, 136);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(103, 26);
            this.labDetails.TabIndex = 5;
            this.labDetails.Text = "Weather";
            this.labDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.Transparent;
            this.labTemp.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.labTemp.Location = new System.Drawing.Point(84, 214);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(0, 19);
            this.labTemp.TabIndex = 6;
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.labHumidity.Location = new System.Drawing.Point(284, 214);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(0, 19);
            this.labHumidity.TabIndex = 7;
            // 
            // labCloudiness
            // 
            this.labCloudiness.AutoSize = true;
            this.labCloudiness.BackColor = System.Drawing.Color.Transparent;
            this.labCloudiness.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.labCloudiness.Location = new System.Drawing.Point(84, 302);
            this.labCloudiness.Name = "labCloudiness";
            this.labCloudiness.Size = new System.Drawing.Size(0, 19);
            this.labCloudiness.TabIndex = 8;
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.labWindSpeed.Location = new System.Drawing.Point(284, 302);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(0, 19);
            this.labWindSpeed.TabIndex = 11;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(372, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(193, 42);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Current Date";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.BackColor = System.Drawing.Color.Transparent;
            this.Temperature.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.Temperature.Location = new System.Drawing.Point(62, 181);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(104, 19);
            this.Temperature.TabIndex = 14;
            this.Temperature.Text = "Temperature";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(267, 181);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(74, 19);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Humidity";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(62, 262);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(88, 19);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Cloudiness";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(252, 262);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(94, 19);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "Wind Speed";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Get Weather";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.Location = new System.Drawing.Point(21, 74);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(211, 44);
            this.bunifuThinButton22.TabIndex = 19;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // bunifuTextbox2
            // 
            this.bunifuTextbox2.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.BackgroundImage")));
            this.bunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.Icon")));
            this.bunifuTextbox2.Location = new System.Drawing.Point(21, 20);
            this.bunifuTextbox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuTextbox2.Name = "bunifuTextbox2";
            this.bunifuTextbox2.Size = new System.Drawing.Size(211, 45);
            this.bunifuTextbox2.TabIndex = 20;
            this.bunifuTextbox2.text = "";
            // 
            // labDetails2
            // 
            this.labDetails2.AutoSize = true;
            this.labDetails2.BackColor = System.Drawing.Color.Transparent;
            this.labDetails2.Font = new System.Drawing.Font("HP Simplified Hans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails2.Location = new System.Drawing.Point(142, 137);
            this.labDetails2.Name = "labDetails2";
            this.labDetails2.Size = new System.Drawing.Size(103, 26);
            this.labDetails2.TabIndex = 20;
            this.labDetails2.Text = "Weather";
            this.labDetails2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTemp2
            // 
            this.labTemp2.AutoSize = true;
            this.labTemp2.BackColor = System.Drawing.Color.Transparent;
            this.labTemp2.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.labTemp2.Location = new System.Drawing.Point(77, 215);
            this.labTemp2.Name = "labTemp2";
            this.labTemp2.Size = new System.Drawing.Size(0, 19);
            this.labTemp2.TabIndex = 21;
            // 
            // labHumidity2
            // 
            this.labHumidity2.AutoSize = true;
            this.labHumidity2.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity2.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.labHumidity2.Location = new System.Drawing.Point(272, 215);
            this.labHumidity2.Name = "labHumidity2";
            this.labHumidity2.Size = new System.Drawing.Size(0, 19);
            this.labHumidity2.TabIndex = 22;
            // 
            // labCloudiness2
            // 
            this.labCloudiness2.AutoSize = true;
            this.labCloudiness2.BackColor = System.Drawing.Color.Transparent;
            this.labCloudiness2.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.labCloudiness2.Location = new System.Drawing.Point(77, 303);
            this.labCloudiness2.Name = "labCloudiness2";
            this.labCloudiness2.Size = new System.Drawing.Size(0, 19);
            this.labCloudiness2.TabIndex = 23;
            // 
            // labWindSpeed2
            // 
            this.labWindSpeed2.AutoSize = true;
            this.labWindSpeed2.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed2.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.labWindSpeed2.Location = new System.Drawing.Point(272, 303);
            this.labWindSpeed2.Name = "labWindSpeed2";
            this.labWindSpeed2.Size = new System.Drawing.Size(0, 19);
            this.labWindSpeed2.TabIndex = 24;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(236, 263);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(94, 19);
            this.bunifuCustomLabel7.TabIndex = 29;
            this.bunifuCustomLabel7.Text = "Wind Speed";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(51, 263);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(88, 19);
            this.bunifuCustomLabel8.TabIndex = 28;
            this.bunifuCustomLabel8.Text = "Cloudiness";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(253, 182);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(74, 19);
            this.bunifuCustomLabel9.TabIndex = 27;
            this.bunifuCustomLabel9.Text = "Humidity";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F);
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(51, 182);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(104, 19);
            this.bunifuCustomLabel10.TabIndex = 26;
            this.bunifuCustomLabel10.Text = "Temperature";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel9);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel10);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuTextbox2);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuThinButton22);
            this.bunifuGradientPanel2.Controls.Add(this.labDetails2);
            this.bunifuGradientPanel2.Controls.Add(this.labTemp2);
            this.bunifuGradientPanel2.Controls.Add(this.labHumidity2);
            this.bunifuGradientPanel2.Controls.Add(this.labCloudiness2);
            this.bunifuGradientPanel2.Controls.Add(this.labWindSpeed2);
            this.bunifuGradientPanel2.Controls.Add(this.picIcon2);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(461, 60);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(411, 341);
            this.bunifuGradientPanel2.TabIndex = 33;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.labWindSpeed);
            this.bunifuGradientPanel1.Controls.Add(this.labCloudiness);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.Temperature);
            this.bunifuGradientPanel1.Controls.Add(this.labHumidity);
            this.bunifuGradientPanel1.Controls.Add(this.labTemp);
            this.bunifuGradientPanel1.Controls.Add(this.labDetails);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTextbox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton21);
            this.bunifuGradientPanel1.Controls.Add(this.picIcon);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(28, 61);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(411, 340);
            this.bunifuGradientPanel1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 440);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon2)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Bunifu.Framework.UI.BunifuCustomLabel Temperature;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}
