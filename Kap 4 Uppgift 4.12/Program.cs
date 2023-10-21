using System;
namespace Uppgift4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "n";

            //Motherloop
            while (true)
            {
                squareProgram();

                Console.WriteLine("Vill du testa igen? [J]a eller [n]ej?");
                loop = Console.ReadLine().ToLower(); //"n" stänger av loopen
                
                if (loop == "n") //Stäng av
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        //Själva koden
        static void squareProgram()
        {
            //Variabler och frågor
            Console.WriteLine("Bestäm kvadraternas sidlängd:");
            int sideLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Bestäm rutnätets bredd:");
            int gridWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Bestäm rutnätets höjd:");
            int gridHeight = int.Parse(Console.ReadLine());

            //Rutnätets höjd
            for (int i = 0; i < gridHeight; i++)
            {
                //Varje liten kvadrats höjd
                for (int j = 0; j < sideLength; j++)
                {
                    //Rutnätets bredd
                    for (int k = 0; k < gridWidth; k++)
                    {
                        //Varje kvadrats bredd
                        for (int l = 0; l < sideLength; l++)
                        {
                            Console.Write("*");
                        }

                        if (k == gridWidth - 1) //Hoppar till nästa rad
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(" "); //" " efter varje kvadrat
                        }
                    }
                }
                Console.WriteLine(); //Ny rad efter varje rutnäts-del
            }
        }
    }
}