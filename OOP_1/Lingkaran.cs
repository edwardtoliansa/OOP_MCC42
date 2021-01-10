using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Lingkaran : BangunDatar
    {
        private double radius;
        private double pi = 3.14d;

        public double getSetRadius 
        { 
            get { return radius; }
            set { radius = value; }
        }

        public override double hitungLuas()
        {
            luas = pi * radius * radius;
            return luas;
        }
    }
}
