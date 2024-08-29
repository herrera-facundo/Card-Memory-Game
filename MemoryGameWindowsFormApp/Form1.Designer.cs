
namespace MemoryGameWindowsFormApp
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
            this.lblMatches = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.crd1 = new System.Windows.Forms.PictureBox();
            this.crd2 = new System.Windows.Forms.PictureBox();
            this.crd3 = new System.Windows.Forms.PictureBox();
            this.crd4 = new System.Windows.Forms.PictureBox();
            this.crd5 = new System.Windows.Forms.PictureBox();
            this.crd10 = new System.Windows.Forms.PictureBox();
            this.crd9 = new System.Windows.Forms.PictureBox();
            this.crd8 = new System.Windows.Forms.PictureBox();
            this.crd7 = new System.Windows.Forms.PictureBox();
            this.crd6 = new System.Windows.Forms.PictureBox();
            this.crd15 = new System.Windows.Forms.PictureBox();
            this.crd14 = new System.Windows.Forms.PictureBox();
            this.crd13 = new System.Windows.Forms.PictureBox();
            this.crd12 = new System.Windows.Forms.PictureBox();
            this.crd11 = new System.Windows.Forms.PictureBox();
            this.crd20 = new System.Windows.Forms.PictureBox();
            this.crd19 = new System.Windows.Forms.PictureBox();
            this.crd18 = new System.Windows.Forms.PictureBox();
            this.crd17 = new System.Windows.Forms.PictureBox();
            this.crd16 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.crd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd16)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(12, 9);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(60, 13);
            this.lblMatches.TabIndex = 0;
            this.lblMatches.Text = "Matches: 0";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(121, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(54, 13);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Timer: 0.0";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Location = new System.Drawing.Point(232, 9);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(54, 13);
            this.lblBest.TabIndex = 2;
            this.lblBest.Text = "Best: N/A";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(12, 340);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(106, 36);
            this.btnRestart.TabIndex = 23;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 36);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // crd1
            // 
            this.crd1.Image = ((System.Drawing.Image)(resources.GetObject("crd1.Image")));
            this.crd1.Location = new System.Drawing.Point(12, 47);
            this.crd1.Name = "crd1";
            this.crd1.Size = new System.Drawing.Size(50, 63);
            this.crd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd1.TabIndex = 25;
            this.crd1.TabStop = false;
            this.crd1.Tag = "0,0";
            this.crd1.Click += new System.EventHandler(this.card_Click);
            // 
            // crd2
            // 
            this.crd2.Image = ((System.Drawing.Image)(resources.GetObject("crd2.Image")));
            this.crd2.Location = new System.Drawing.Point(68, 47);
            this.crd2.Name = "crd2";
            this.crd2.Size = new System.Drawing.Size(50, 63);
            this.crd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd2.TabIndex = 26;
            this.crd2.TabStop = false;
            this.crd2.Tag = "0,1";
            this.crd2.Click += new System.EventHandler(this.card_Click);
            // 
            // crd3
            // 
            this.crd3.Image = ((System.Drawing.Image)(resources.GetObject("crd3.Image")));
            this.crd3.Location = new System.Drawing.Point(124, 47);
            this.crd3.Name = "crd3";
            this.crd3.Size = new System.Drawing.Size(50, 63);
            this.crd3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd3.TabIndex = 27;
            this.crd3.TabStop = false;
            this.crd3.Tag = "0,2";
            this.crd3.Click += new System.EventHandler(this.card_Click);
            // 
            // crd4
            // 
            this.crd4.Image = ((System.Drawing.Image)(resources.GetObject("crd4.Image")));
            this.crd4.Location = new System.Drawing.Point(180, 47);
            this.crd4.Name = "crd4";
            this.crd4.Size = new System.Drawing.Size(50, 63);
            this.crd4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd4.TabIndex = 28;
            this.crd4.TabStop = false;
            this.crd4.Tag = "0,3";
            this.crd4.Click += new System.EventHandler(this.card_Click);
            // 
            // crd5
            // 
            this.crd5.Image = ((System.Drawing.Image)(resources.GetObject("crd5.Image")));
            this.crd5.Location = new System.Drawing.Point(236, 47);
            this.crd5.Name = "crd5";
            this.crd5.Size = new System.Drawing.Size(50, 63);
            this.crd5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd5.TabIndex = 29;
            this.crd5.TabStop = false;
            this.crd5.Tag = "0,4";
            this.crd5.Click += new System.EventHandler(this.card_Click);
            // 
            // crd10
            // 
            this.crd10.Image = ((System.Drawing.Image)(resources.GetObject("crd10.Image")));
            this.crd10.Location = new System.Drawing.Point(236, 116);
            this.crd10.Name = "crd10";
            this.crd10.Size = new System.Drawing.Size(50, 63);
            this.crd10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd10.TabIndex = 34;
            this.crd10.TabStop = false;
            this.crd10.Tag = "1,4";
            this.crd10.Click += new System.EventHandler(this.card_Click);
            // 
            // crd9
            // 
            this.crd9.Image = ((System.Drawing.Image)(resources.GetObject("crd9.Image")));
            this.crd9.Location = new System.Drawing.Point(180, 116);
            this.crd9.Name = "crd9";
            this.crd9.Size = new System.Drawing.Size(50, 63);
            this.crd9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd9.TabIndex = 33;
            this.crd9.TabStop = false;
            this.crd9.Tag = "1,3";
            this.crd9.Click += new System.EventHandler(this.card_Click);
            // 
            // crd8
            // 
            this.crd8.Image = ((System.Drawing.Image)(resources.GetObject("crd8.Image")));
            this.crd8.Location = new System.Drawing.Point(124, 116);
            this.crd8.Name = "crd8";
            this.crd8.Size = new System.Drawing.Size(50, 63);
            this.crd8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd8.TabIndex = 32;
            this.crd8.TabStop = false;
            this.crd8.Tag = "1,2";
            this.crd8.Click += new System.EventHandler(this.card_Click);
            // 
            // crd7
            // 
            this.crd7.Image = ((System.Drawing.Image)(resources.GetObject("crd7.Image")));
            this.crd7.Location = new System.Drawing.Point(68, 116);
            this.crd7.Name = "crd7";
            this.crd7.Size = new System.Drawing.Size(50, 63);
            this.crd7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd7.TabIndex = 31;
            this.crd7.TabStop = false;
            this.crd7.Tag = "1,1";
            this.crd7.Click += new System.EventHandler(this.card_Click);
            // 
            // crd6
            // 
            this.crd6.Image = ((System.Drawing.Image)(resources.GetObject("crd6.Image")));
            this.crd6.Location = new System.Drawing.Point(12, 116);
            this.crd6.Name = "crd6";
            this.crd6.Size = new System.Drawing.Size(50, 63);
            this.crd6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd6.TabIndex = 30;
            this.crd6.TabStop = false;
            this.crd6.Tag = "1,0";
            this.crd6.Click += new System.EventHandler(this.card_Click);
            // 
            // crd15
            // 
            this.crd15.Image = ((System.Drawing.Image)(resources.GetObject("crd15.Image")));
            this.crd15.Location = new System.Drawing.Point(236, 185);
            this.crd15.Name = "crd15";
            this.crd15.Size = new System.Drawing.Size(50, 63);
            this.crd15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd15.TabIndex = 39;
            this.crd15.TabStop = false;
            this.crd15.Tag = "2,4";
            this.crd15.Click += new System.EventHandler(this.card_Click);
            // 
            // crd14
            // 
            this.crd14.Image = ((System.Drawing.Image)(resources.GetObject("crd14.Image")));
            this.crd14.Location = new System.Drawing.Point(180, 185);
            this.crd14.Name = "crd14";
            this.crd14.Size = new System.Drawing.Size(50, 63);
            this.crd14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd14.TabIndex = 38;
            this.crd14.TabStop = false;
            this.crd14.Tag = "2,3";
            this.crd14.Click += new System.EventHandler(this.card_Click);
            // 
            // crd13
            // 
            this.crd13.Image = ((System.Drawing.Image)(resources.GetObject("crd13.Image")));
            this.crd13.Location = new System.Drawing.Point(124, 185);
            this.crd13.Name = "crd13";
            this.crd13.Size = new System.Drawing.Size(50, 63);
            this.crd13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd13.TabIndex = 37;
            this.crd13.TabStop = false;
            this.crd13.Tag = "2,2";
            this.crd13.Click += new System.EventHandler(this.card_Click);
            // 
            // crd12
            // 
            this.crd12.Image = ((System.Drawing.Image)(resources.GetObject("crd12.Image")));
            this.crd12.Location = new System.Drawing.Point(68, 185);
            this.crd12.Name = "crd12";
            this.crd12.Size = new System.Drawing.Size(50, 63);
            this.crd12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd12.TabIndex = 36;
            this.crd12.TabStop = false;
            this.crd12.Tag = "2,1";
            this.crd12.Click += new System.EventHandler(this.card_Click);
            // 
            // crd11
            // 
            this.crd11.Image = ((System.Drawing.Image)(resources.GetObject("crd11.Image")));
            this.crd11.Location = new System.Drawing.Point(12, 185);
            this.crd11.Name = "crd11";
            this.crd11.Size = new System.Drawing.Size(50, 63);
            this.crd11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd11.TabIndex = 35;
            this.crd11.TabStop = false;
            this.crd11.Tag = "2,0";
            this.crd11.Click += new System.EventHandler(this.card_Click);
            // 
            // crd20
            // 
            this.crd20.Image = ((System.Drawing.Image)(resources.GetObject("crd20.Image")));
            this.crd20.Location = new System.Drawing.Point(236, 254);
            this.crd20.Name = "crd20";
            this.crd20.Size = new System.Drawing.Size(50, 63);
            this.crd20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd20.TabIndex = 44;
            this.crd20.TabStop = false;
            this.crd20.Tag = "3,4";
            this.crd20.Click += new System.EventHandler(this.card_Click);
            // 
            // crd19
            // 
            this.crd19.Image = ((System.Drawing.Image)(resources.GetObject("crd19.Image")));
            this.crd19.Location = new System.Drawing.Point(180, 254);
            this.crd19.Name = "crd19";
            this.crd19.Size = new System.Drawing.Size(50, 63);
            this.crd19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd19.TabIndex = 43;
            this.crd19.TabStop = false;
            this.crd19.Tag = "3,3";
            this.crd19.Click += new System.EventHandler(this.card_Click);
            // 
            // crd18
            // 
            this.crd18.Image = ((System.Drawing.Image)(resources.GetObject("crd18.Image")));
            this.crd18.Location = new System.Drawing.Point(124, 254);
            this.crd18.Name = "crd18";
            this.crd18.Size = new System.Drawing.Size(50, 63);
            this.crd18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd18.TabIndex = 42;
            this.crd18.TabStop = false;
            this.crd18.Tag = "3,2";
            this.crd18.Click += new System.EventHandler(this.card_Click);
            // 
            // crd17
            // 
            this.crd17.Image = ((System.Drawing.Image)(resources.GetObject("crd17.Image")));
            this.crd17.Location = new System.Drawing.Point(68, 254);
            this.crd17.Name = "crd17";
            this.crd17.Size = new System.Drawing.Size(50, 63);
            this.crd17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd17.TabIndex = 41;
            this.crd17.TabStop = false;
            this.crd17.Tag = "3,1";
            this.crd17.Click += new System.EventHandler(this.card_Click);
            // 
            // crd16
            // 
            this.crd16.Image = ((System.Drawing.Image)(resources.GetObject("crd16.Image")));
            this.crd16.Location = new System.Drawing.Point(12, 254);
            this.crd16.Name = "crd16";
            this.crd16.Size = new System.Drawing.Size(50, 63);
            this.crd16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crd16.TabIndex = 40;
            this.crd16.TabStop = false;
            this.crd16.Tag = "3,0";
            this.crd16.Click += new System.EventHandler(this.card_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 388);
            this.Controls.Add(this.crd20);
            this.Controls.Add(this.crd19);
            this.Controls.Add(this.crd18);
            this.Controls.Add(this.crd17);
            this.Controls.Add(this.crd16);
            this.Controls.Add(this.crd15);
            this.Controls.Add(this.crd14);
            this.Controls.Add(this.crd13);
            this.Controls.Add(this.crd12);
            this.Controls.Add(this.crd11);
            this.Controls.Add(this.crd10);
            this.Controls.Add(this.crd9);
            this.Controls.Add(this.crd8);
            this.Controls.Add(this.crd7);
            this.Controls.Add(this.crd6);
            this.Controls.Add(this.crd5);
            this.Controls.Add(this.crd4);
            this.Controls.Add(this.crd3);
            this.Controls.Add(this.crd2);
            this.Controls.Add(this.crd1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblMatches);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Memory Game";
            ((System.ComponentModel.ISupportInitialize)(this.crd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crd16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox crd1;
        private System.Windows.Forms.PictureBox crd2;
        private System.Windows.Forms.PictureBox crd3;
        private System.Windows.Forms.PictureBox crd4;
        private System.Windows.Forms.PictureBox crd5;
        private System.Windows.Forms.PictureBox crd10;
        private System.Windows.Forms.PictureBox crd9;
        private System.Windows.Forms.PictureBox crd8;
        private System.Windows.Forms.PictureBox crd7;
        private System.Windows.Forms.PictureBox crd6;
        private System.Windows.Forms.PictureBox crd15;
        private System.Windows.Forms.PictureBox crd14;
        private System.Windows.Forms.PictureBox crd13;
        private System.Windows.Forms.PictureBox crd12;
        private System.Windows.Forms.PictureBox crd11;
        private System.Windows.Forms.PictureBox crd20;
        private System.Windows.Forms.PictureBox crd19;
        private System.Windows.Forms.PictureBox crd18;
        private System.Windows.Forms.PictureBox crd17;
        private System.Windows.Forms.PictureBox crd16;
        private System.Windows.Forms.Timer timer;
    }
}

