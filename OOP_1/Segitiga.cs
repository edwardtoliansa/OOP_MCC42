using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Segitiga : BangunDatar
    {
        private double alas;
        private double tinggi;

        public double getSetAlas 
        {
            get { return alas; }
            set { alas = value; }
        }

        public double getSetTinggi 
        { 
            get { return tinggi; }
            set { tinggi = value; }
        }

        public override double hitungLuas()
        {
            luas = (alas * tinggi) / 2;
            return luas;
        }
    }
}
