
namespace Aforge_Kutuphanesi_Ornekleri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.xuıClock1 = new XanderUI.XUIClock();
            this.SBtnTikla = new XanderUI.XUISuperButton();
            this.SBtnKaydet = new XanderUI.XUISuperButton();
            this.SBtnSeslendir = new XanderUI.XUISuperButton();
            this.SBtnCikis = new XanderUI.XUISuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(474, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(387, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "KAMERA:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(332, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 322);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(292, 309);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(51, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "QR KOD - BARKOD İŞLEMİ\r\nYAZI SESLENDİRME İŞLEMİ";
            // 
            // xuıClock1
            // 
            this.xuıClock1.CircleThickness = 6;
            this.xuıClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwentyFourHour;
            this.xuıClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuıClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuıClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuıClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuıClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuıClock1.Location = new System.Drawing.Point(855, -1);
            this.xuıClock1.Name = "xuıClock1";
            this.xuıClock1.ShowAmPm = false;
            this.xuıClock1.ShowHexagon = true;
            this.xuıClock1.ShowMinutesCircle = true;
            this.xuıClock1.ShowSecondsCircle = true;
            this.xuıClock1.Size = new System.Drawing.Size(110, 85);
            this.xuıClock1.TabIndex = 7;
            this.xuıClock1.Text = "xuıClock1";
            this.xuıClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuıClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuıClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // SBtnTikla
            // 
            this.SBtnTikla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.SBtnTikla.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SBtnTikla.ButtonImage")));
            this.SBtnTikla.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.SBtnTikla.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.SBtnTikla.ButtonText = "TIKLA";
            this.SBtnTikla.CornerRadius = 5;
            this.SBtnTikla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnTikla.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SBtnTikla.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.SBtnTikla.HoverTextColor = System.Drawing.Color.White;
            this.SBtnTikla.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.SBtnTikla.Location = new System.Drawing.Point(390, 57);
            this.SBtnTikla.Name = "SBtnTikla";
            this.SBtnTikla.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.SBtnTikla.SelectedTextColor = System.Drawing.Color.White;
            this.SBtnTikla.Size = new System.Drawing.Size(124, 40);
            this.SBtnTikla.SuperSelected = false;
            this.SBtnTikla.TabIndex = 8;
            this.SBtnTikla.TextColor = System.Drawing.Color.White;
            this.SBtnTikla.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SBtnTikla.Click += new System.EventHandler(this.SBtnTikla_Click);
            // 
            // SBtnKaydet
            // 
            this.SBtnKaydet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.SBtnKaydet.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SBtnKaydet.ButtonImage")));
            this.SBtnKaydet.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.SBtnKaydet.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.SBtnKaydet.ButtonText = "FOTO YAKALA";
            this.SBtnKaydet.CornerRadius = 5;
            this.SBtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnKaydet.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SBtnKaydet.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.SBtnKaydet.HoverTextColor = System.Drawing.Color.White;
            this.SBtnKaydet.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.SBtnKaydet.Location = new System.Drawing.Point(603, 57);
            this.SBtnKaydet.Name = "SBtnKaydet";
            this.SBtnKaydet.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.SBtnKaydet.SelectedTextColor = System.Drawing.Color.White;
            this.SBtnKaydet.Size = new System.Drawing.Size(127, 40);
            this.SBtnKaydet.SuperSelected = false;
            this.SBtnKaydet.TabIndex = 9;
            this.SBtnKaydet.TextColor = System.Drawing.Color.White;
            this.SBtnKaydet.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SBtnKaydet.Click += new System.EventHandler(this.SBtnKaydet_Click);
            // 
            // SBtnSeslendir
            // 
            this.SBtnSeslendir.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.SBtnSeslendir.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SBtnSeslendir.ButtonImage")));
            this.SBtnSeslendir.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.SBtnSeslendir.ButtonStyle = XanderUI.XUISuperButton.Style.Elliptical;
            this.SBtnSeslendir.ButtonText = "SESLENDİR";
            this.SBtnSeslendir.CornerRadius = 5;
            this.SBtnSeslendir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSeslendir.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SBtnSeslendir.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.SBtnSeslendir.HoverTextColor = System.Drawing.Color.White;
            this.SBtnSeslendir.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.SBtnSeslendir.Location = new System.Drawing.Point(41, 388);
            this.SBtnSeslendir.Name = "SBtnSeslendir";
            this.SBtnSeslendir.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.SBtnSeslendir.SelectedTextColor = System.Drawing.Color.White;
            this.SBtnSeslendir.Size = new System.Drawing.Size(205, 40);
            this.SBtnSeslendir.SuperSelected = false;
            this.SBtnSeslendir.TabIndex = 10;
            this.SBtnSeslendir.TextColor = System.Drawing.Color.White;
            this.SBtnSeslendir.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SBtnSeslendir.Click += new System.EventHandler(this.SBtnSeslendir_Click);
            // 
            // SBtnCikis
            // 
            this.SBtnCikis.BackgroundColor = System.Drawing.Color.DarkRed;
            this.SBtnCikis.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SBtnCikis.ButtonImage")));
            this.SBtnCikis.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.SBtnCikis.ButtonStyle = XanderUI.XUISuperButton.Style.Elliptical;
            this.SBtnCikis.ButtonText = "ÇIKIŞ";
            this.SBtnCikis.CornerRadius = 5;
            this.SBtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnCikis.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SBtnCikis.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.SBtnCikis.HoverTextColor = System.Drawing.Color.White;
            this.SBtnCikis.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.SBtnCikis.Location = new System.Drawing.Point(882, 385);
            this.SBtnCikis.Name = "SBtnCikis";
            this.SBtnCikis.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.SBtnCikis.SelectedTextColor = System.Drawing.Color.White;
            this.SBtnCikis.Size = new System.Drawing.Size(76, 40);
            this.SBtnCikis.SuperSelected = false;
            this.SBtnCikis.TabIndex = 11;
            this.SBtnCikis.TextColor = System.Drawing.Color.White;
            this.SBtnCikis.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SBtnCikis.Click += new System.EventHandler(this.SBtnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.SBtnCikis);
            this.Controls.Add(this.SBtnSeslendir);
            this.Controls.Add(this.SBtnKaydet);
            this.Controls.Add(this.SBtnTikla);
            this.Controls.Add(this.xuıClock1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WEB CAM KONTROLLERİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIClock xuıClock1;
        private XanderUI.XUISuperButton SBtnTikla;
        private XanderUI.XUISuperButton SBtnKaydet;
        private XanderUI.XUISuperButton SBtnSeslendir;
        private XanderUI.XUISuperButton SBtnCikis;
    }
}

