using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hasil;

            Calculator calculator = new Calculator();

            hasil = calculator.Penjumlahan(10, 2);
            Calculator.CetakHasil(hasil);

            hasil = calculator.Penjumlahan(10, 2, 3);
            Calculator.CetakHasil(hasil);

            hasil = calculator.Pengurangan(7, 2);
            Calculator.CetakHasil(hasil);

            hasil = calculator.Perkalian(5, 2);
            Calculator.CetakHasil(hasil);

            Console.ReadKey();
        }
    }
}
