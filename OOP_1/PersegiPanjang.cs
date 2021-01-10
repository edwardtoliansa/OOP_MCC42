using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class PersegiPanjang : BangunDatar
    {
        private double panjang;
        private double lebar;

        public double getSetPanjang
        {
            get { return panjang; }
            set { panjang = value; }
        }

        public double getSetLebar 
        { 
            get { return lebar; }
            set { lebar = value; }
        }

        public override double hitungLuas() 
        {
            luas = panjang * lebar;
            return luas; 
        }
    }
}
