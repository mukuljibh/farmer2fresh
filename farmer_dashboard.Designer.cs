namespace WinFormsApp1
{
    partial class farmer_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(farmer_dashboard));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 31);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 0;
            label1.Text = "Farmer Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(256, 69);
            label2.Name = "label2";
            label2.Size = new Size(225, 32);
            label2.TabIndex = 1;
            label2.Text = "Hello Farmer Mukul";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 193);
            button1.Name = "button1";
            button1.Size = new Size(114, 42);
            button1.TabIndex = 2;
            button1.Text = "Add/Remove ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(212, 193);
            button2.Name = "button2";
            button2.Size = new Size(121, 42);
            button2.TabIndex = 3;
            button2.Text = "Total Sales";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(388, 193);
            button3.Name = "button3";
            button3.Size = new Size(117, 42);
            button3.TabIndex = 4;
            button3.Text = "Confirm Order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(2, 1);
            button4.Name = "button4";
            button4.Size = new Size(111, 30);
            button4.TabIndex = 5;
            button4.Text = "Homepage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(677, 1);
            button5.Name = "button5";
            button5.Size = new Size(121, 30);
            button5.TabIndex = 6;
            button5.Text = "logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(554, 193);
            button6.Name = "button6";
            button6.Size = new Size(112, 42);
            button6.TabIndex = 7;
            button6.Text = "Review";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // farmer_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 515);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "farmer_dashboard";
            Text = "farmer_dashboard";
            Load += farmer_dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}