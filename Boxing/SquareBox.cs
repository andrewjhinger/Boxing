using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boxing
{
    class SquareBox
    {

        // Box field.
        public Box Box;

        // Automatic property for single dimension value (length, width and height are all the same).
        public double Dimension { get; set; }

        // Constructor with double fingerprint.
        // Note that we use this constructor to create our Box object.
        public SquareBox(double Dimension)
        {
            this.Box = new Box(Dimension, Dimension, Dimension);
            this.Dimension = Dimension;
        }

        // Default constructor, calls constructor with double fingerprint, passing double literal,
        // using space-conserving method body coding convention.
        public SquareBox() : this(0.0) { }

        // Return a reference to the current object.
        public SquareBox Reference()
        {
            return this;
        }



    }
}
