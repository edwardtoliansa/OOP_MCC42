using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Perhitungan Luas Bangun Datar");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Jajar Genjang");
            Console.WriteLine("5. Lingkaran");
            Console.Write("Masukkan input: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            switch (temp) 
            {
                case 1:
                    Persegi p = new Persegi();
                    Console.Write("Input panjang sisi persegi: ");
                    p.getSetSisi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Luas: " + p.hitungLuas());
                    break;
                case 2:
                    PersegiPanjang pp = new PersegiPanjang();
                    Console.Write("Input panjang persegi panjang: ");
                    pp.getSetPanjang = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input lebar persegi panjang  : ");
                    pp.getSetLebar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Luas: " + pp.hitungLuas());
                    break;
                case 3:
                    Segitiga s = new Segitiga();
                    Console.Write("Input alas segitiga  : ");
                    s.getSetAlas = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input tinggi segitiga: ");
                    s.getSetTinggi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Luas: " + s.hitungLuas());
                    break;
                case 4:
                    JajarGenjang jg = new JajarGenjang();
                    Console.Write("Input alas jajar genjang  : ");
                    jg.getSetAlas = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input tinggi jajar genjang: ");
                    jg.getSetTinggi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Luas: " + jg.hitungLuas());
                    break;
                case 5:
                    Lingkaran l = new Lingkaran();
                    Console.Write("Input radius lingkaran: ");
                    l.getSetRadius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Luas: " + l.hitungLuas());
                    break;
            }
        }
    }
}
