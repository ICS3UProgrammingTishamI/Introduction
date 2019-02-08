namespace HelloWorldIntTishamI
{
    partial class frmHelloWorldInt
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
            this.lblHelloWorldInt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radBangla = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radLatin = new System.Windows.Forms.RadioButton();
            this.radCanadian = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorldInt
            // 
            this.lblHelloWorldInt.AutoSize = true;
            this.lblHelloWorldInt.Font = new System.Drawing.Font("Racer", 63.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldInt.ForeColor = System.Drawing.Color.Chocolate;
            this.lblHelloWorldInt.Location = new System.Drawing.Point(12, 28);
            this.lblHelloWorldInt.Name = "lblHelloWorldInt";
            this.lblHelloWorldInt.Size = new System.Drawing.Size(818, 93);
            this.lblHelloWorldInt.TabIndex = 0;
            this.lblHelloWorldInt.Text = "Hello World";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCanadian);
            this.groupBox1.Controls.Add(this.radLatin);
            this.groupBox1.Controls.Add(this.radFrench);
            this.groupBox1.Controls.Add(this.radBangla);
            this.groupBox1.Controls.Add(this.radSpanish);
            this.groupBox1.Controls.Add(this.radEnglish);
            this.groupBox1.Location = new System.Drawing.Point(105, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(35, 79);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(64, 20);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Font = new System.Drawing.Font("Prestige Elite Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpanish.Location = new System.Drawing.Point(539, 217);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(166, 40);
            this.radSpanish.TabIndex = 1;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Spanish";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.radSpanish_CheckedChanged);
            // 
            // radBangla
            // 
            this.radBangla.AutoSize = true;
            this.radBangla.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBangla.Location = new System.Drawing.Point(333, 161);
            this.radBangla.Name = "radBangla";
            this.radBangla.Size = new System.Drawing.Size(111, 24);
            this.radBangla.TabIndex = 2;
            this.radBangla.TabStop = true;
            this.radBangla.Text = "Bangla";
            this.radBangla.UseVisualStyleBackColor = true;
            this.radBangla.CheckedChanged += new System.EventHandler(this.radBangla_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Font = new System.Drawing.Font("Proxy 3", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFrench.Location = new System.Drawing.Point(118, 255);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(99, 23);
            this.radFrench.TabIndex = 3;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "French";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.radFrench_CheckedChanged);
            // 
            // radLatin
            // 
            this.radLatin.AutoSize = true;
            this.radLatin.Font = new System.Drawing.Font("GothicG", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLatin.Location = new System.Drawing.Point(892, 268);
            this.radLatin.Name = "radLatin";
            this.radLatin.Size = new System.Drawing.Size(95, 35);
            this.radLatin.TabIndex = 4;
            this.radLatin.TabStop = true;
            this.radLatin.Text = "Latin";
            this.radLatin.UseVisualStyleBackColor = true;
            this.radLatin.CheckedChanged += new System.EventHandler(this.radLatin_CheckedChanged);
            // 
            // radCanadian
            // 
            this.radCanadian.AutoSize = true;
            this.radCanadian.Font = new System.Drawing.Font("Onky", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCanadian.Location = new System.Drawing.Point(589, 19);
            this.radCanadian.Name = "radCanadian";
            this.radCanadian.Size = new System.Drawing.Size(357, 64);
            this.radCanadian.TabIndex = 5;
            this.radCanadian.TabStop = true;
            this.radCanadian.Text = "Canadian";
            this.radCanadian.UseVisualStyleBackColor = true;
            this.radCanadian.CheckedChanged += new System.EventHandler(this.radCanadian_CheckedChanged);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 582);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHelloWorldInt);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International by Tisham Islam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorldInt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCanadian;
        private System.Windows.Forms.RadioButton radLatin;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radBangla;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

