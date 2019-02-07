namespace SchoolAppTishamI
{
    partial class frmSchoolApp
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
            this.mnuSchoolApp = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblMascot = new System.Windows.Forms.Label();
            this.mnuSchoolApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchoolApp
            // 
            this.mnuSchoolApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuSchoolApp.Location = new System.Drawing.Point(0, 0);
            this.mnuSchoolApp.Name = "mnuSchoolApp";
            this.mnuSchoolApp.Size = new System.Drawing.Size(1049, 24);
            this.mnuSchoolApp.TabIndex = 0;
            this.mnuSchoolApp.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            this.mniProgram.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Onky", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.ForeColor = System.Drawing.Color.Crimson;
            this.lblSchool.Location = new System.Drawing.Point(119, 76);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(836, 41);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "Immaculata Catholic High School";
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Onky", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.ForeColor = System.Drawing.Color.Crimson;
            this.lblMascot.Location = new System.Drawing.Point(296, 117);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(463, 119);
            this.lblMascot.TabIndex = 2;
            this.lblMascot.Text = "Saints";
            // 
            // frmSchoolApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 554);
            this.Controls.Add(this.lblMascot);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.mnuSchoolApp);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.MainMenuStrip = this.mnuSchoolApp;
            this.Name = "frmSchoolApp";
            this.Text = "School App by Tisham Islam";
            this.mnuSchoolApp.ResumeLayout(false);
            this.mnuSchoolApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchoolApp;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblMascot;
    }
}

