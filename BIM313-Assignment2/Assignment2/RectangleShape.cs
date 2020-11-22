using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment2
{
    class RectangleShape : Shape, IShape {
        private readonly int edge1;
        private readonly int edge2;

        public RectangleShape(int edge1, int edge2) {
            this.edge1 = edge1;
            this.edge2 = edge2;
        }
        public double calculateArea() {
            return edge1 * edge2;
        }
        public double calculatePerimeter() {
            return 2 * (edge1 + edge2);
        }
    }

}
