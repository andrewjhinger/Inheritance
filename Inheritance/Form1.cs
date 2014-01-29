using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Ellipse ellipse = new Ellipse();
            Rectangle rectangle = new Rectangle();
        }

        public class Shape
        {
            public Shape()
            {
                Console.WriteLine("Shape constructor");
            }
        }

        public class Ellipse : Shape
        {
            public Ellipse()
            {
                Console.WriteLine("Ellipse constructor");
            }
        }

        public class Rectangle : Shape
        {
            public Rectangle()
            {
                Console.WriteLine("Rectangle constructor");
            }
        }
    }
}
