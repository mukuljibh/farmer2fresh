namespace WinFormsApp1
{
    partial class customer_purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_purchase));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 41);
            label1.TabIndex = 0;
            label1.Text = "Purchase Section";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 82);
            label2.Name = "label2";
            label2.Size = new Size(215, 38);
            label2.TabIndex = 1;
            label2.Text = "Search Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 146);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 2;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 211);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 27);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(318, 271);
            button1.Name = "button1";
            button1.Size = new Size(105, 29);
            button1.TabIndex = 6;
            button1.Text = "Generate Bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(259, 397);
            button2.Name = "button2";
            button2.Size = new Size(223, 29);
            button2.TabIndex = 7;
            button2.Text = "Place Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(-7, -3);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 8;
            button3.Text = "Homepage";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(704, -3);
            button4.Name = "button4";
            button4.Size = new Size(105, 29);
            button4.TabIndex = 9;
            button4.Text = "logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(104, -3);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "dashboard";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // customer_purchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 510);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "customer_purchase";
            Text = "customer_purchase";
            Load += customer_purchase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}