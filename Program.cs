class Program
{
    static void Main()
    {
        int minStroki = 0, maxStroki = 0, indMinStroki = 0, indMaxStroki = 0, schietchikDlaProverki_1 = 0, schietchikDlaProverki_2 = 0,
            n = 3, m = 3;
        Random rand = new Random();

        int[,] array2d = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                array2d[i, j] = rand.Next(0, 10);
                Console.Write("{0,3}", array2d[i, j]);
            }
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("min строки и max столбца");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("max строки и min столбца");
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < n; i++)
        {
            minStroki = maxStroki = array2d[i, 0];
            indMinStroki = indMaxStroki = 0;
            for (int j = 0; j < m; j++)
            {
                if (array2d[i, j] <= minStroki)
                {
                    indMinStroki = j;
                    minStroki = array2d[i, j];
                }
                if (array2d[i, j] > maxStroki)
                {
                    indMaxStroki = j;
                    maxStroki = array2d[i, j];
                }
            }
            for (int j = 0; j < m; j++)
            {
                schietchikDlaProverki_1 = schietchikDlaProverki_2 = 0;
                if (j == indMinStroki)
                {
                    for (int ii = 0; ii < n; ii++)
                        if (array2d[ii, indMinStroki] >= minStroki)
                            schietchikDlaProverki_1++;
                    if (schietchikDlaProverki_1 == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                }
                if (j == indMaxStroki)
                {
                    for (int ii = 0; ii < n; ii++)
                        if (array2d[ii, indMaxStroki] <= maxStroki)
                            schietchikDlaProverki_2++;
                    if (schietchikDlaProverki_2 == 1)
                        Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write("{0,3}", array2d[i, j]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("");
        Console.WriteLine("Повтор?(ДА - клавиша enter / НЕТ - люб.др.клавиша)");
        Console.ForegroundColor = ConsoleColor.White;
        string strokaDlaPovtora;
        strokaDlaPovtora = Convert.ToString(Console.ReadLine());
        if (strokaDlaPovtora == "")
            Main();
    }
}