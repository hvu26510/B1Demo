namespace B1Demo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCong = new System.Windows.Forms.RadioButton();
            this.rbTru = new System.Windows.Forms.RadioButton();
            this.rbNhan = new System.Windows.Forms.RadioButton();
            this.rbChia = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbTru);
            this.panel1.Controls.Add(this.rbChia);
            this.panel1.Controls.Add(this.rbNhan);
            this.panel1.Controls.Add(this.rbCong);
            this.panel1.Location = new System.Drawing.Point(75, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 157);
            this.panel1.TabIndex = 0;
            // 
            // rbCong
            // 
            this.rbCong.AutoSize = true;
            this.rbCong.Location = new System.Drawing.Point(48, 28);
            this.rbCong.Name = "rbCong";
            this.rbCong.Size = new System.Drawing.Size(60, 20);
            this.rbCong.TabIndex = 0;
            this.rbCong.TabStop = true;
            this.rbCong.Text = "Cong";
            this.rbCong.UseVisualStyleBackColor = true;
            // 
            // rbTru
            // 
            this.rbTru.AutoSize = true;
            this.rbTru.Location = new System.Drawing.Point(48, 107);
            this.rbTru.Name = "rbTru";
            this.rbTru.Size = new System.Drawing.Size(48, 20);
            this.rbTru.TabIndex = 1;
            this.rbTru.TabStop = true;
            this.rbTru.Text = "Tru";
            this.rbTru.UseVisualStyleBackColor = true;
            // 
            // rbNhan
            // 
            this.rbNhan.AutoSize = true;
            this.rbNhan.Location = new System.Drawing.Point(293, 28);
            this.rbNhan.Name = "rbNhan";
            this.rbNhan.Size = new System.Drawing.Size(60, 20);
            this.rbNhan.TabIndex = 2;
            this.rbNhan.TabStop = true;
            this.rbNhan.Text = "Nhan";
            this.rbNhan.UseVisualStyleBackColor = true;
            // 
            // rbChia
            // 
            this.rbChia.AutoSize = true;
            this.rbChia.Location = new System.Drawing.Point(293, 107);
            this.rbChia.Name = "rbChia";
            this.rbChia.Size = new System.Drawing.Size(55, 20);
            this.rbChia.TabIndex = 3;
            this.rbChia.TabStop = true;
            this.rbChia.Text = "Chia";
            this.rbChia.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "So thu 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "So thu 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tinh Toan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "z";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNhan;
        private System.Windows.Forms.RadioButton rbTru;
        private System.Windows.Forms.RadioButton rbCong;
        private System.Windows.Forms.RadioButton rbChia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

