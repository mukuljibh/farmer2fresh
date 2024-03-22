namespace WinFormsApp1
{
    partial class Customer_reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_reg));
            label5 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(323, 9);
            label5.Name = "label5";
            label5.Size = new Size(147, 35);
            label5.TabIndex = 9;
            label5.Text = "Registration";
            // 
            // button1
            // 
            button1.Location = new Point(323, 420);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 18;
            button1.Text = "Register Now!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(306, 364);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 27);
            textBox4.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(346, 316);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 16;
            label4.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(306, 286);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 27);
            textBox3.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(346, 247);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 14;
            label3.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(350, 156);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 11;
            label2.Text = "Contact";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(350, 80);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // button2
            // 
            button2.Location = new Point(1, -1);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "homepage";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Customer_reg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(808, 525);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Customer_reg";
            Text = "Customer_reg";
            Load += Customer_reg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}