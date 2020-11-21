using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment2 {
    class CircleForm : Form
    {
        private Button circleFormButton;
        private Label circleFormText;
        private PictureBox CircleFormPictureBox;
        private bool mouseClicked = false;
        private Rectangle circle;
        private static int x = 10, y = 10, h, w;
        private CircleShape circleShape;
        private bool isButtonClicked = false;

        public CircleForm(int radius) {
            InitializeComponent();
            w = radius;
            h = radius;
            circleShape = new CircleShape(radius);
            circle = new Rectangle(x, y, w, h);
            
        }

        private void InitializeComponent()
        {
            this.circleFormButton = new System.Windows.Forms.Button();
            this.circleFormText = new System.Windows.Forms.Label();
            this.CircleFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CircleFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // circleFormButton
            // 
            this.circleFormButton.Location = new System.Drawing.Point(335, 400);
            this.circleFormButton.Name = "circleFormButton";
            this.circleFormButton.Size = new System.Drawing.Size(95, 23);
            this.circleFormButton.TabIndex = 0;
            this.circleFormButton.Text = "CALCULATE";
            this.circleFormButton.UseVisualStyleBackColor = true;
            this.circleFormButton.Click += new System.EventHandler(this.circleFormButton_Click);
            // 
            // circleFormText
            // 
            this.circleFormText.AutoSize = true;
            this.circleFormText.Location = new System.Drawing.Point(335, 370);
            this.circleFormText.Name = "circleFormText";
            this.circleFormText.Size = new System.Drawing.Size(0, 15);
            this.circleFormText.TabIndex = 1;
            // 
            // CircleFormPictureBox
            // 
            this.CircleFormPictureBox.Location = new System.Drawing.Point(35, 30);
            this.CircleFormPictureBox.Name = "CircleFormPictureBox";
            this.CircleFormPictureBox.Size = new System.Drawing.Size(493, 317);
            this.CircleFormPictureBox.TabIndex = 2;
            this.CircleFormPictureBox.TabStop = false;
            this.CircleFormPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.CircleFormPictureBox_Paint);
            this.CircleFormPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CircleFormPictureBox_MouseDown);
            this.CircleFormPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleFormPictureBox_MouseMove);
            this.CircleFormPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CircleFormPictureBox_MouseUp);
            // 
            // CircleForm
            // 
            this.ClientSize = new System.Drawing.Size(574, 441);
            this.Controls.Add(this.CircleFormPictureBox);
            this.Controls.Add(this.circleFormText);
            this.Controls.Add(this.circleFormButton);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            ((System.ComponentModel.ISupportInitialize)(this.CircleFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CircleFormPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isButtonClicked) {
                using (Pen pen = new Pen(Color.HotPink, 2)) {
                    _ = circle;
                    e.Graphics.DrawEllipse(pen, circle);
                    circleShape = new CircleShape((w - 10) / 2);
                    circleFormText.Text = circleShape.print(circleShape.calculateArea(),
                        circleShape.calculatePerimeter());
                }
            }
        }

        private void CircleFormPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked) {
                if (e.X > e.Y) {
                    this.circle.Height = e.X - 10;
                    this.circle.Width = e.X - 10;
                }
                else {
                    this.circle.Height = e.Y - 10;
                    this.circle.Width = e.Y - 10;
                }
                
                this.Refresh();
            }
            
        }

        private void CircleFormPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void CircleFormPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void circleFormButton_Click(object sender, EventArgs e) {
            isButtonClicked = true;
            h = this.circle.Height;
            w = this.circle.Width;
            circleShape = new CircleShape(w);
            
            circleFormText.Text = circleShape.print(circleShape.calculateArea()
                , circleShape.calculatePerimeter());
            this.Refresh();
        }

    }
}
