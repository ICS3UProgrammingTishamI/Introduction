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
            this.SuspendLayout();
            // 
            // lblHelloWorldInt
            // 
            this.lblHelloWorldInt.AutoSize = true;
            this.lblHelloWorldInt.Font = new System.Drawing.Font("OCR A Std", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldInt.Location = new System.Drawing.Point(293, 39);
            this.lblHelloWorldInt.Name = "lblHelloWorldInt";
            this.lblHelloWorldInt.Size = new System.Drawing.Size(186, 22);
            this.lblHelloWorldInt.TabIndex = 0;
            this.lblHelloWorldInt.Text = "Hello World";
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHelloWorldInt);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorldInt;
    }
}

