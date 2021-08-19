using System;

namespace EX02Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string firsteName = "Kasrten";
            string lastName = "Hansen";
            int age = 35;

            Console.WriteLine(firsteName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);

            Console.WriteLine($"Fornavn: {firsteName}. Efternavn: {lastName}. Alder: {age}.");



            
            string Bogtitel = "Lord of the Rings";
            long ISBN = 9780007117116;
            int Sidetal = 400;
            double Pris = 249.95;

            Console.WriteLine(Bogtitel);
            Console.WriteLine(ISBN);
            Console.WriteLine(Sidetal);
            Console.WriteLine(Pris);

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);

            uint maxUint = uint.MaxValue;
            uint minUint = uint.MinValue;
            Console.WriteLine(maxUint);
            Console.WriteLine(minUint);

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine(maxLong);
            Console.WriteLine(minLong);

            byte maxByte = Byte.MaxValue;
            byte minByte = Byte.MinValue;
            Console.WriteLine(maxByte);
            Console.WriteLine(minByte);

            sbyte maxsbyte = sbyte.MaxValue;
            sbyte minsbyte = sbyte.MinValue;
            Console.WriteLine(maxsbyte);
            Console.WriteLine(minsbyte);
            



        }
    }
}
