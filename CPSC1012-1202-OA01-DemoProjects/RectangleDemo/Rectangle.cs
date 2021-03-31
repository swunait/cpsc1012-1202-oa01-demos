using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleDemo
{
    public class Rectangle
    {
        // Define data fields for storing data on the length and width of the Rectangle
        private double _length = 1;
        private double _width = 1;

        // Define properties for each data field to encapsulate data access
        public double Length
        {
            get { return _length; }
            set 
            { 
                // Validate that the new value is greater than zero,
                // otherwise throw an exception
                if (value > 0 )
                {
                    _length = value;    // assign _length with new value
                }
                else
                {
                    throw new Exception($"Length must be greater than zero.");
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set 
            {   // Validate that the new value is greater than zero
                // otherwise throw an exception.
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Width must be greater than zero.");
                }
                
            }
        }
        // Define a no-argument default constructor

        public Rectangle()
        {
            _length = 1;
            _width = 1;
        }

        // Define a paramertized constructor for a given length and width
        public Rectangle(double newLength, double newWidth)
        {
            //_length = newLength;
            //_width = newWidth;
            // Assign the parameter values to the property instead of the 
            // data fields to trigger validation if any
            Length = newLength;
            Width = newWidth;
        }

        // Define a instance-level method to return the area of this rectangle
        public double Area()
        {
            //return _length * _width;
            return Length * Width;
        }
        // Define a instance-level method to return the perimeter of this rectangle
        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
        // Define a instance-level method to return the diagonal of this rectangle
        public double Diagonal()
        {
            double value = Math.Sqrt(Width * Width + Length * Length);
            return Math.Round(value, 2);
        }
    }
}
