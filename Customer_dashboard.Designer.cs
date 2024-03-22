namespace WinFormsApp1
{
    partial class Customer_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_dashboard));
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(296, 192);
            button2.Name = "button2";
            button2.Size = new Size(121, 42);
            button2.TabIndex = 8;
            button2.Text = "Order Status";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(34, 192);
            button1.Name = "button1";
            button1.Size = new Size(157, 42);
            button1.TabIndex = 7;
            button1.Text = "Available Farmers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(265, 74);
            label2.Name = "label2";
            label2.Size = new Size(255, 32);
            label2.TabIndex = 6;
            label2.Text = "Hello Customer Mukul";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 38);
            label1.TabIndex = 5;
            label1.Text = "Customer Dashboard";
            // 
            // button4
            // 
            button4.Location = new Point(0, -1);
            button4.Name = "button4";
            button4.Size = new Size(91, 24);
            button4.TabIndex = 10;
            button4.Text = "homepage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(688, -1);
            button5.Name = "button5";
            button5.Size = new Size(114, 24);
            button5.TabIndex = 11;
            button5.Text = "logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(539, 192);
            button3.Name = "button3";
            button3.Size = new Size(123, 42);
            button3.TabIndex = 12;
            button3.Text = "Feedback";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(97, -1);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 13;
            button6.Text = "dashboard";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Customer_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 517);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customer_dashboard";
            Text = "Customer_dashboard";
            Load += Customer_dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button6;
    }
}