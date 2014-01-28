using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boxing
{
    class Box
    {
        // Automatic class properties.
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor used with double, double, double fingerprint.
        public Box(double Length, double Width, double Height)
        {
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;
        }

        // Default constructor, using this to call constructor with double, double, double fingerprint.
        public Box() : this(0.0, 0.0, 0.0) { }

        // Private constructor that takes a Box as a parameter, used to clone itself.
        private Box(Box Box) : this(Box.Length, Box.Width, Box.Height) { }

        // A method to return a cloned version of the current Box.
        public Box Clone() { return new Box(this); }

        // Calculate volume of box.
        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }



    }
}
