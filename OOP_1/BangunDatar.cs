using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    abstract class BangunDatar
    {
        public double luas;

        public double getSetLuas
        {
            get { return luas; }
            set { luas = value; }
        }

        public abstract double hitungLuas();

    }
}
