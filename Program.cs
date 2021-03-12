using System;

namespace testing_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu kalkulator: ");
            menu();
            Console.Write("\nInput nomor menu [1..4]: ");
            int input = int.Parse(Console.ReadLine());

            if(input >=5)
            {
                Console.WriteLine("Maaf menu yang Anda pilih tidak tersedia");
            }
            else
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("\nHasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                }
                else if (input == 2)
                {
                    Console.WriteLine("\nHasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                }
                else if (input == 3)
                {
                    Console.WriteLine("\nHasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
                }
                else if (input == 4)
                {
                    Console.WriteLine("\nHasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
                }
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static void menu()
        {
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(int a, int b)
        {
            return (float)a / (float)b;
        }

    }
}
