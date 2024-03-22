namespace WinFormsApp1
{
    partial class farmer_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(farmer_login));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 38);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 0;
            label1.Text = "Add product ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Product Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 124);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Quantity";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(350, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(169, 208);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 5;
            button1.Text = "Add!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(467, 208);
            button2.Name = "button2";
            button2.Size = new Size(135, 50);
            button2.TabIndex = 6;
            button2.Text = "Remove!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 124);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(578, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(1, 0);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 9;
            button3.Text = "homepage";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(708, 0);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 10;
            button4.Text = "logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(97, 0);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 11;
            button5.Text = "dashbord";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // farmer_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 510);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "farmer_login";
            Text = "farmer_login";
            Load += farmer_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}