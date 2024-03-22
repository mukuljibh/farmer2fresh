namespace WinFormsApp1
{
    partial class farmer_reg2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(farmer_reg2));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(306, 68);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 136);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Contact";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(310, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 251);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(310, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(310, 309);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(310, 340);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 27);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(330, -1);
            label5.Name = "label5";
            label5.Size = new Size(147, 35);
            label5.TabIndex = 8;
            label5.Text = "Registration";
            // 
            // button1
            // 
            button1.Location = new Point(310, 399);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 9;
            button1.Text = "Register Now!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1, -1);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 10;
            button2.Text = "homepage";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(703, -1);
            button3.Name = "button3";
            button3.Size = new Size(107, 29);
            button3.TabIndex = 11;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(310, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 27);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(306, 194);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 13;
            label6.Text = "Farm name";
            // 
            // farmer_reg2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(802, 503);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "farmer_reg2";
            Text = "farmer_reg2";
            Load += farmer_reg2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox5;
        private Label label6;
    }
}