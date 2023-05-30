namespace PersonelBilgiSistemi
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(73, 13);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 0;
            label1.Text = "Yönetici Giriş Paneli";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 59);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 97);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 2;
            label2.Text = "Yönetici ID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 139);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 3;
            label3.Text = "Şifre : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(238, 166);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 6;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormGiris
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(372, 211);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetici Giriş Paneli";
            Load += FormGiris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}