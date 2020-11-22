using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2 {
    abstract class Shape {
        public virtual String print(Double area, Double perimeter) {
            area = Math.Round(area, 5);
            perimeter = Math.Round(perimeter, 5);
            return "Perimeter : " + perimeter + "   Area : " + area;
        }
    }
}
