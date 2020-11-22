namespace Assignment2
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Radius = new System.Windows.Forms.Label();
            this.Edge1 = new System.Windows.Forms.Label();
            this.Edge2 = new System.Windows.Forms.Label();
            this.Edge1TextBox = new System.Windows.Forms.TextBox();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.Edge2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "REDIRECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(47, 194);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(42, 15);
            this.Radius.TabIndex = 2;
            this.Radius.Text = "Radius";
            // 
            // Edge1
            // 
            this.Edge1.AutoSize = true;
            this.Edge1.Location = new System.Drawing.Point(47, 239);
            this.Edge1.Name = "Edge1";
            this.Edge1.Size = new System.Drawing.Size(39, 15);
            this.Edge1.TabIndex = 3;
            this.Edge1.Text = "Edge1";
            // 
            // Edge2
            // 
            this.Edge2.AutoSize = true;
            this.Edge2.Location = new System.Drawing.Point(47, 286);
            this.Edge2.Name = "Edge2";
            this.Edge2.Size = new System.Drawing.Size(39, 15);
            this.Edge2.TabIndex = 4;
            this.Edge2.Text = "Edge2";
            // 
            // Edge1TextBox
            // 
            this.Edge1TextBox.Location = new System.Drawing.Point(145, 236);
            this.Edge1TextBox.Name = "Edge1TextBox";
            this.Edge1TextBox.Size = new System.Drawing.Size(117, 23);
            this.Edge1TextBox.TabIndex = 5;
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(145, 191);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(117, 23);
            this.RadiusTextBox.TabIndex = 5;
            // 
            // Edge2TextBox
            // 
            this.Edge2TextBox.Location = new System.Drawing.Point(145, 283);
            this.Edge2TextBox.Name = "Edge2TextBox";
            this.Edge2TextBox.Size = new System.Drawing.Size(117, 23);
            this.Edge2TextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 369);
            this.Controls.Add(this.Edge2TextBox);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.Edge1TextBox);
            this.Controls.Add(this.Edge2);
            this.Controls.Add(this.Edge1);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();



            comboBox1.Items.Add("Select");
            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox1.Items.Add("Circle");
            comboBox1.Items.Add("Rectangle");
            Radius.Hide(); RadiusTextBox.Hide();
            Edge1TextBox.Hide(); Edge2TextBox.Hide();
            Edge1.Hide(); Edge2.Hide();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Edge1;
        private System.Windows.Forms.Label Edge2;
        private System.Windows.Forms.TextBox Edge1TextBox;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.TextBox Edge2TextBox;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.TextBox TextBoxEdge1;
    }
}

