namespace خوازمية_قيصر
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPlanText = new System.Windows.Forms.Button();
            this.textBoxPlanText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCipherRext = new System.Windows.Forms.Button();
            this.textBoxCipherText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDecryptText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPlanText);
            this.groupBox1.Controls.Add(this.textBoxPlanText);
            this.groupBox1.Location = new System.Drawing.Point(8, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(513, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "التشفير";
            // 
            // buttonPlanText
            // 
            this.buttonPlanText.Location = new System.Drawing.Point(378, 50);
            this.buttonPlanText.Name = "buttonPlanText";
            this.buttonPlanText.Size = new System.Drawing.Size(103, 35);
            this.buttonPlanText.TabIndex = 1;
            this.buttonPlanText.Text = "شفر";
            this.buttonPlanText.UseVisualStyleBackColor = true;
            this.buttonPlanText.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPlanText
            // 
            this.textBoxPlanText.Location = new System.Drawing.Point(25, 23);
            this.textBoxPlanText.Multiline = true;
            this.textBoxPlanText.Name = "textBoxPlanText";
            this.textBoxPlanText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPlanText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPlanText.Size = new System.Drawing.Size(318, 89);
            this.textBoxPlanText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCipherRext);
            this.groupBox2.Controls.Add(this.textBoxCipherText);
            this.groupBox2.Location = new System.Drawing.Point(4, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(521, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فك التشفير";
            // 
            // buttonCipherRext
            // 
            this.buttonCipherRext.Location = new System.Drawing.Point(385, 49);
            this.buttonCipherRext.Name = "buttonCipherRext";
            this.buttonCipherRext.Size = new System.Drawing.Size(103, 35);
            this.buttonCipherRext.TabIndex = 3;
            this.buttonCipherRext.Text = "فك التشفير";
            this.buttonCipherRext.UseVisualStyleBackColor = true;
            this.buttonCipherRext.Click += new System.EventHandler(this.buttonCipherRext_Click);
            // 
            // textBoxCipherText
            // 
            this.textBoxCipherText.Location = new System.Drawing.Point(32, 22);
            this.textBoxCipherText.Multiline = true;
            this.textBoxCipherText.Name = "textBoxCipherText";
            this.textBoxCipherText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCipherText.Size = new System.Drawing.Size(318, 89);
            this.textBoxCipherText.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxKey);
            this.groupBox3.Location = new System.Drawing.Point(8, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(513, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مفتاح التشفير";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(28, 16);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKey.Size = new System.Drawing.Size(318, 24);
            this.textBoxKey.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "مسح";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDecryptText);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(4, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(521, 126);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "فك التشفير";
            // 
            // textBoxDecryptText
            // 
            this.textBoxDecryptText.Location = new System.Drawing.Point(32, 22);
            this.textBoxDecryptText.Multiline = true;
            this.textBoxDecryptText.Name = "textBoxDecryptText";
            this.textBoxDecryptText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDecryptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDecryptText.Size = new System.Drawing.Size(318, 89);
            this.textBoxDecryptText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 563);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قيصر";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPlanText;
        private System.Windows.Forms.TextBox textBoxPlanText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCipherRext;
        private System.Windows.Forms.TextBox textBoxCipherText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxDecryptText;
    }
}

