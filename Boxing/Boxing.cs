using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boxing
{
    public partial class Boxing : Form
    {
        public Boxing()
        {
            InitializeComponent();
        }

        private void boxingButton_Click(object sender, EventArgs e)
        {
            // Fun with Box.
            boxingListBox.Items.Add("Creating box...");
            Box box = new Box(5, 10, 15);
            boxingListBox.Items.Add("Cloning box as newBox...");
            Box newBox = box.Clone();
            boxingListBox.Items.Add("Do box and newBox reference same object? " + ReferenceEquals(box, newBox));
            boxingListBox.Items.Add("Setting box to null...");
            box = null;
            boxingListBox.Items.Add("Is box null? " + (box == null));
            boxingListBox.Items.Add("Is newBox null? " + (newBox == null));
            boxingListBox.Items.Add("Volume : " + newBox.Volume());

            // Fun with SquareBox.
            boxingListBox.Items.Add(""); // Empty line
            boxingListBox.Items.Add("Creating squareBox...");
            SquareBox squareBox = new SquareBox(20);
            SquareBox newSquareBox = squareBox.Reference();
            boxingListBox.Items.Add("Do squareBox and newSquareBox reference same object? " + ReferenceEquals(squareBox, newSquareBox));
            boxingListBox.Items.Add("Setting squareBox to null...");
            squareBox = null;
            boxingListBox.Items.Add("Is squareBox null? " + (squareBox == null));
            boxingListBox.Items.Add("Is newSquareBox null? " + (newSquareBox == null));

            // Fun with Sphere.
            boxingListBox.Items.Add(""); // Empty line
            boxingListBox.Items.Add("Creating sphere...");
            Sphere sphere = new Sphere();
            sphere.Radius = 5;
            int mySphereRadius = Sphere.Dimensions;
            boxingListBox.Items.Add("sphere Radius value? " + (sphere.Radius));
            boxingListBox.Items.Add("mySphereRadius value? " + (mySphereRadius));
            string volumeCalculation = Sphere.VolumeCalculation();  
            Sphere newSphere = sphere.Reference();
            boxingListBox.Items.Add("Do sphere and newSphere reference same object? " + ReferenceEquals(sphere, newSphere));
            boxingListBox.Items.Add("Setting sphere to null...");
            sphere = null;
            boxingListBox.Items.Add("Is sphere null? " + (sphere == null));
            boxingListBox.Items.Add("Is newSphere null? " + (newSphere == null));

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
