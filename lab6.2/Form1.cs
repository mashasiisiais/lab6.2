using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        abstract class Solid
        {
            public abstract double GetSurfaceArea();
        }

        class RectSolid : Solid
        {
            public double C { get; set; } 
            public double D { get; set; }
            public double H { get; set; } 

            public RectSolid(double c, double d, double h)
            {
                C = c;
                D = d;
                H = h;
            }
            public override double GetSurfaceArea()
            {
                return 2 * (C * D + C * H + D * H);
            }
        }

        class Cube : Solid
        {
            public double A { get; set; } 
            public Cube(double a)
            {
                A = a;
            }
            public override double GetSurfaceArea()
            {
                return 6 * Math.Pow(A, 2);
            }
        }
    }
}



