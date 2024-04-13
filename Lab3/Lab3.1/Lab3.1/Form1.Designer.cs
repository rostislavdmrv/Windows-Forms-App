namespace Lab3._1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mathFormulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.graduationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abbreviatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mathFormulaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mathFormulaToolStripMenuItem
            // 
            this.mathFormulaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algebraToolStripMenuItem});
            this.mathFormulaToolStripMenuItem.Name = "mathFormulaToolStripMenuItem";
            this.mathFormulaToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.mathFormulaToolStripMenuItem.Text = "Math formula";
            // 
            // algebraToolStripMenuItem
            // 
            this.algebraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.algebraToolStripMenuItem.Name = "algebraToolStripMenuItem";
            this.algebraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.algebraToolStripMenuItem.Text = "Algebra";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graduationToolStripMenuItem,
            this.abbreviatedToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "6th grade";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // graduationToolStripMenuItem
            // 
            this.graduationToolStripMenuItem.Name = "graduationToolStripMenuItem";
            this.graduationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.graduationToolStripMenuItem.Text = "Graduation";
            this.graduationToolStripMenuItem.Click += new System.EventHandler(this.graduationToolStripMenuItem_Click);
            // 
            // abbreviatedToolStripMenuItem
            // 
            this.abbreviatedToolStripMenuItem.Name = "abbreviatedToolStripMenuItem";
            this.abbreviatedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abbreviatedToolStripMenuItem.Text = "abbreviated";
            this.abbreviatedToolStripMenuItem.Click += new System.EventHandler(this.abbreviatedToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem3.Text = "7th grade";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem4.Text = "8th grade";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mathFormulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graduationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abbreviatedToolStripMenuItem;
    }
}

