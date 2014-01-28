using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boxing
{
    class Sphere
    {

        // Automatic class properties.
        public double Radius { get; set; }

        // Typical constructor used with double, double, double fingerprint.
        public Sphere(double Radius)
        {
            this.Radius = Radius;
        }

        // Default constructor, using this to call constructor with double, double, double fingerprint,
        // Note using explicit 0.0 double literal to prevent any forced type conversions, and 
        // placing empty method body curly braces on same line to conserve space
        public Sphere() : this(0.0) { }



        public static int Dimensions { get; private set; }
    
        // Define the static constructor to initialize the static property
        static Sphere()
        {
        // Note that you can not use this with Dimensions, as we are not using a reference to an instance
        Dimensions = 3;
        }

        // Private constructor that takes a Box as a parameter, used to clone itself.
        private Sphere(Sphere Sphere) : this(Sphere.Radius) { }



        // Define the static method VolumeCalculation
        public static string VolumeCalculation()
        {
            return "Radius X (4/3) X Math.PI";
        }

        // A method to return a cloned version of the current Box.
        // Note that cloning is rarely this simple!
        public Sphere Clone() { return new Sphere(this); }

        public Sphere Reference()
        {
            return this;
        }

        // Calculate volume of box.
        public double Volume()
        {
            return this.Radius *(4/3)*Math.PI;
        }
    }
}
