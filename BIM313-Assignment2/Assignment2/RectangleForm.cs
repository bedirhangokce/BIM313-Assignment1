using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment2 {
    class RectangleForm : Form {
        private Button rectangleFormButton;
        private Label rectangleFormText;
        private PictureBox rectangleFormPictureBox;
        private int x = 10, y = 20, h, w;
        private RectangleShape rectangleShape;
        private Rectangle rectangle;
        private bool mouseClicked = false;
        private int mouseX, mouseY;

        public RectangleForm(int edge1, int edge2) {
            rectangleShape = new RectangleShape(edge1, edge2);
            h = edge1;
            w = edge2;
            rectangle = new Rectangle(x, y, w, h);
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.rectangleFormButton = new System.Windows.Forms.Button();
            this.rectangleFormText = new System.Windows.Forms.Label();
            this.rectangleFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleFormButton
            // 
            this.rectangleFormButton.Location = new System.Drawing.Point(335, 400);
            this.rectangleFormButton.Name = "rectangleFormButton";
            this.rectangleFormButton.Size = new System.Drawing.Size(95, 23);
            this.rectangleFormButton.TabIndex = 0;
            this.rectangleFormButton.Text = "CALCULATE";
            this.rectangleFormButton.UseVisualStyleBackColor = true;
            this.rectangleFormButton.Click += new System.EventHandler(this.rectangleFormButton_Click);
            // 
            // rectangleFormText
            // 
            this.rectangleFormText.AutoSize = true;
            this.rectangleFormText.Location = new System.Drawing.Point(335, 370);
            this.rectangleFormText.Name = "rectangleFormText";
            this.rectangleFormText.Size = new System.Drawing.Size(0, 15);
            this.rectangleFormText.TabIndex = 1;
            // 
            // rectangleFormPictureBox
            // 
            this.rectangleFormPictureBox.Location = new System.Drawing.Point(35, 30);
            this.rectangleFormPictureBox.Name = "rectangleFormPictureBox";
            this.rectangleFormPictureBox.Size = new System.Drawing.Size(493, 317);
            this.rectangleFormPictureBox.TabIndex = 2;
            this.rectangleFormPictureBox.TabStop = false;
            this.rectangleFormPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.rectangleFormPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangleFormPictureBox_MouseDown);
            this.rectangleFormPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rectangleFormPictureBox_MouseMove);
            this.rectangleFormPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rectangleFormPictureBox_MouseUp);
            // 
            // RectangleForm
            // 
            this.ClientSize = new System.Drawing.Size(574, 441);
            this.Controls.Add(this.rectangleFormPictureBox);
            this.Controls.Add(this.rectangleFormText);
            this.Controls.Add(this.rectangleFormButton);
            this.Name = "RectangleForm";
            ((System.ComponentModel.ISupportInitialize)(this.rectangleFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            using (Pen pen = new Pen(Color.HotPink, 2)) {
                _ = rectangle;
            e.Graphics.DrawRectangle(pen, rectangle);
            rectangleShape = new RectangleShape(w,h);
            rectangleFormText.Text = rectangleShape.print(rectangleShape.calculateArea(), 
                rectangleShape.calculatePerimeter());
            }
        }

        private void rectangleFormPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked) {
                this.rectangle.Height = e.Y - 10;
                this.rectangle.Width = e.X - 10;
            }
            this.Refresh();
        }

        private void rectangleFormPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void rectangleFormPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
        private void rectangleFormButton_Click(object sender, EventArgs e) {

            h = this.rectangle.Height;
            w = this.rectangle.Width;
            rectangleShape = new RectangleShape(h,w);
            rectangleFormText.Text =
                rectangleShape.print(rectangleShape.calculateArea(),
                    rectangleShape.calculatePerimeter());
            this.Refresh();
        }
    }
}
