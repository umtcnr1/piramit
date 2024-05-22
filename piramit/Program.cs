using System;

namespace piramit
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 5; // Piramit yüksekliği

            for (int i = 1; i <= height; i++)
            {
                // Boşlukları ekle
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // Kenarları ve içi boş alanı ekle
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || i == height)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.ReadLine();
            }
    }
}
