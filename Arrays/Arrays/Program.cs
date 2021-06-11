using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Wat wist ik al: Ik weet wat een array is en hoe je die moet gebruiken
            //Wat wist ik niet: Dat je in C# geen soort array_push functie hebt
            //Op welke manier zijn arrays anders: Geen array_push functie, verder geen idee


            Random random = new Random();
            double[] temps = new double[7];
     
            for (var a = 0; a < temps.Length; a++)
            {
                double temp = random.Next(0, 15) + (random.Next(0, 9) / 10.0);
                temps[a] = temp;
                Console.WriteLine(temps[a]);
            }
            Array.Sort(temps);
            Console.WriteLine("Hoogste: " + temps[6]);
            Console.WriteLine("Laagste: " + temps[0]);

            //GEMIDDELDE UITREKENEN
            double total = 0.0;
            for (var b = 0; b < temps.Length; b++)
            {
                total = total + temps[b];
            }
            double gem = total / temps.Length;
            Console.WriteLine("Gemiddelde: " + Math.Round(gem, 1));
    
            Console.ReadLine();
        }
    }
}
