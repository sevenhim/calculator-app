namespace CalculatorConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;
            double a, b;

            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu calculator : \n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");
            Console.Write("Input nomor menu [1..4] : ");
            pilih = Console.ReadLine()[0];
            Console.WriteLine();

            Console.Write("Inputkan nilai a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inputkan nilai b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            switch (pilih)
            {
                case '1':
                    Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, (a + b));
                    Console.WriteLine();
                    break;

                case '2':
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, (a - b));
                    Console.WriteLine();
                    break;

                case '3':
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, (a * b));
                    Console.WriteLine();
                    break;

                case '4':
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, (a / b));
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Sembarang key untuk keluar");
                    Console.ReadKey();
                    break;
            }
            Console.Write("Tekan Sembarang key untuk keluar");
            Console.ReadKey();
        }
    }

}
