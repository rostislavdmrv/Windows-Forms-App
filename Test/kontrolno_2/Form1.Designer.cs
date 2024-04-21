namespace test_2_Mihaela_Hristova_21621562
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
            this.l_name = new System.Windows.Forms.Label();
            this.l_middleName = new System.Windows.Forms.Label();
            this.l_surname = new System.Windows.Forms.Label();
            this.l_egn = new System.Windows.Forms.Label();
            this.l_address = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_middle_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_egn = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.RichTextBox();
            this.b_scolarship = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sb_error = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(41, 41);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(34, 16);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "Име";
            // 
            // l_middleName
            // 
            this.l_middleName.AutoSize = true;
            this.l_middleName.Location = new System.Drawing.Point(41, 84);
            this.l_middleName.Name = "l_middleName";
            this.l_middleName.Size = new System.Drawing.Size(66, 16);
            this.l_middleName.TabIndex = 1;
            this.l_middleName.Text = "Презиме";
            // 
            // l_surname
            // 
            this.l_surname.AutoSize = true;
            this.l_surname.Location = new System.Drawing.Point(41, 127);
            this.l_surname.Name = "l_surname";
            this.l_surname.Size = new System.Drawing.Size(66, 16);
            this.l_surname.TabIndex = 2;
            this.l_surname.Text = "Фамилия";
            // 
            // l_egn
            // 
            this.l_egn.AutoSize = true;
            this.l_egn.Location = new System.Drawing.Point(41, 162);
            this.l_egn.Name = "l_egn";
            this.l_egn.Size = new System.Drawing.Size(35, 16);
            this.l_egn.TabIndex = 3;
            this.l_egn.Text = "ЕГН";
            this.l_egn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_address
            // 
            this.l_address.AutoSize = true;
            this.l_address.Location = new System.Drawing.Point(41, 199);
            this.l_address.Name = "l_address";
            this.l_address.Size = new System.Drawing.Size(47, 16);
            this.l_address.TabIndex = 4;
            this.l_address.Text = "Адрес";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(116, 38);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 22);
            this.tb_name.TabIndex = 5;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            this.tb_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_name_Validating);
            // 
            // tb_middle_name
            // 
            this.tb_middle_name.Location = new System.Drawing.Point(116, 81);
            this.tb_middle_name.Name = "tb_middle_name";
            this.tb_middle_name.Size = new System.Drawing.Size(100, 22);
            this.tb_middle_name.TabIndex = 6;
            this.tb_middle_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_middle_name_KeyPress);
            this.tb_middle_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_middle_name_Validating);
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(116, 121);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 22);
            this.tb_surname.TabIndex = 7;
            this.tb_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_surname_KeyPress);
            this.tb_surname.Validating += new System.ComponentModel.CancelEventHandler(this.tb_surname_Validating);
            // 
            // tb_egn
            // 
            this.tb_egn.Location = new System.Drawing.Point(116, 159);
            this.tb_egn.Name = "tb_egn";
            this.tb_egn.Size = new System.Drawing.Size(100, 22);
            this.tb_egn.TabIndex = 8;
            this.tb_egn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_egn_KeyPress);
            this.tb_egn.Validating += new System.ComponentModel.CancelEventHandler(this.tb_egn_Validating);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(116, 199);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(100, 96);
            this.tb_address.TabIndex = 9;
            this.tb_address.Text = "";
            this.tb_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_address_KeyPress);
            this.tb_address.Validating += new System.ComponentModel.CancelEventHandler(this.tb_address_Validating);
            // 
            // b_scolarship
            // 
            this.b_scolarship.Location = new System.Drawing.Point(116, 314);
            this.b_scolarship.Name = "b_scolarship";
            this.b_scolarship.Size = new System.Drawing.Size(100, 40);
            this.b_scolarship.TabIndex = 10;
            this.b_scolarship.Text = "button1";
            this.b_scolarship.UseVisualStyleBackColor = true;
            this.b_scolarship.Click += new System.EventHandler(this.b_scolarship_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_error});
            this.statusStrip1.Location = new System.Drawing.Point(0, 356);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sb_error
            // 
            this.sb_error.Name = "sb_error";
            this.sb_error.Size = new System.Drawing.Size(41, 20);
            this.sb_error.Text = "error";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 382);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.b_scolarship);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_egn);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_middle_name);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.l_address);
            this.Controls.Add(this.l_egn);
            this.Controls.Add(this.l_surname);
            this.Controls.Add(this.l_middleName);
            this.Controls.Add(this.l_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_middleName;
        private System.Windows.Forms.Label l_surname;
        private System.Windows.Forms.Label l_egn;
        private System.Windows.Forms.Label l_address;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_middle_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_egn;
        private System.Windows.Forms.RichTextBox tb_address;
        private System.Windows.Forms.Button b_scolarship;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sb_error;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

