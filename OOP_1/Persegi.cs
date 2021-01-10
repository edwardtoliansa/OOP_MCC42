using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Persegi : BangunDatar
    {
        private double sisi;

        public double getSetSisi
        {
            get { return sisi; }
            set { sisi = value; }
        }

        public override double hitungLuas()
        {
            luas = sisi * sisi;
            return luas;
        }
    }
}
