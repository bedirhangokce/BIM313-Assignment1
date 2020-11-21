using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class CircleShape : Shape, IShape {
        private readonly int radius;

        public CircleShape(int radius) {
            this.radius = radius;
        }
        public double calculateArea() {
            return Math.PI * radius * radius;
        }
        public double calculatePerimeter() {
            return 2 * Math.PI * radius;
        }
    }
}
