namespace test_2_Mihaela_Hristova_21621562
{
    partial class Form2
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
            this.l_mainScolarship = new System.Windows.Forms.Label();
            this.l_additional = new System.Windows.Forms.Label();
            this.l_taxes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mainScolarship = new System.Windows.Forms.TextBox();
            this.tb_additional = new System.Windows.Forms.TextBox();
            this.tb_taxes = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.b_end = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_mainScolarship
            // 
            this.l_mainScolarship.AutoSize = true;
            this.l_mainScolarship.Location = new System.Drawing.Point(24, 20);
            this.l_mainScolarship.Name = "l_mainScolarship";
            this.l_mainScolarship.Size = new System.Drawing.Size(136, 16);
            this.l_mainScolarship.TabIndex = 0;
            this.l_mainScolarship.Text = "Основна стипендия";
            // 
            // l_additional
            // 
            this.l_additional.AutoSize = true;
            this.l_additional.Location = new System.Drawing.Point(24, 61);
            this.l_additional.Name = "l_additional";
            this.l_additional.Size = new System.Drawing.Size(153, 16);
            this.l_additional.TabIndex = 1;
            this.l_additional.Text = "Допълнителни доходи";
            // 
            // l_taxes
            // 
            this.l_taxes.AutoSize = true;
            this.l_taxes.Location = new System.Drawing.Point(24, 109);
            this.l_taxes.Name = "l_taxes";
            this.l_taxes.Size = new System.Drawing.Size(96, 16);
            this.l_taxes.TabIndex = 2;
            this.l_taxes.Text = "Учебна такса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сума за получаване";
            // 
            // tb_mainScolarship
            // 
            this.tb_mainScolarship.Location = new System.Drawing.Point(183, 20);
            this.tb_mainScolarship.Name = "tb_mainScolarship";
            this.tb_mainScolarship.Size = new System.Drawing.Size(100, 22);
            this.tb_mainScolarship.TabIndex = 4;
            this.tb_mainScolarship.TextChanged += new System.EventHandler(this.tb_mainScolarship_TextChanged);
            this.tb_mainScolarship.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_mainScolarship_KeyPress);
            // 
            // tb_additional
            // 
            this.tb_additional.Location = new System.Drawing.Point(183, 58);
            this.tb_additional.Name = "tb_additional";
            this.tb_additional.Size = new System.Drawing.Size(100, 22);
            this.tb_additional.TabIndex = 5;
            this.tb_additional.TextChanged += new System.EventHandler(this.tb_additional_TextChanged);
            this.tb_additional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_additional_KeyPress);
            // 
            // tb_taxes
            // 
            this.tb_taxes.Location = new System.Drawing.Point(183, 103);
            this.tb_taxes.Name = "tb_taxes";
            this.tb_taxes.Size = new System.Drawing.Size(100, 22);
            this.tb_taxes.TabIndex = 6;
            this.tb_taxes.TextChanged += new System.EventHandler(this.tb_taxes_TextChanged);
            this.tb_taxes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_taxes_KeyPress);
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(183, 148);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(100, 22);
            this.tb_total.TabIndex = 7;
            // 
            // b_end
            // 
            this.b_end.Location = new System.Drawing.Point(97, 198);
            this.b_end.Name = "b_end";
            this.b_end.Size = new System.Drawing.Size(75, 23);
            this.b_end.TabIndex = 8;
            this.b_end.Text = "Край";
            this.b_end.UseVisualStyleBackColor = true;
            this.b_end.Click += new System.EventHandler(this.b_end_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 244);
            this.Controls.Add(this.b_end);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.tb_taxes);
            this.Controls.Add(this.tb_additional);
            this.Controls.Add(this.tb_mainScolarship);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_taxes);
            this.Controls.Add(this.l_additional);
            this.Controls.Add(this.l_mainScolarship);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_mainScolarship;
        private System.Windows.Forms.Label l_additional;
        private System.Windows.Forms.Label l_taxes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_mainScolarship;
        private System.Windows.Forms.TextBox tb_additional;
        private System.Windows.Forms.TextBox tb_taxes;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Button b_end;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}