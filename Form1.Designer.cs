namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            farmerbut = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // farmerbut
            // 
            farmerbut.BackgroundImage = (Image)resources.GetObject("farmerbut.BackgroundImage");
            farmerbut.Location = new Point(127, 206);
            farmerbut.Name = "farmerbut";
            farmerbut.Size = new Size(142, 60);
            farmerbut.TabIndex = 0;
            farmerbut.Text = "farmer";
            farmerbut.UseVisualStyleBackColor = true;
            farmerbut.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 54);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(161, 63);
            label2.Name = "label2";
            label2.Size = new Size(459, 46);
            label2.TabIndex = 3;
            label2.Text = "Are you Farmer or Customer?";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(486, 206);
            button2.Name = "button2";
            button2.Size = new Size(151, 60);
            button2.TabIndex = 4;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 503);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(farmerbut);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "farmer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button farmerbut;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}
