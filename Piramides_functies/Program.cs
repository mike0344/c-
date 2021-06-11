using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramides_functies
{
    class Program
    {
        static void PrintLinksuitgelijndePiramide(int diepte, char symbool='*')
        {
            for (int i = 1; i <= diepte; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(symbool);
                }
                System.Console.WriteLine();
            }
        }

        static void PrintRechtssuitgelijndePiramide(int diepte, char symbool = '*')
        {
            for (int i = 1; i <= diepte; i++)
            {
                for (int j = 1; j <= diepte; j++)
                {
                    if (j <= diepte-i)
                    {
                        System.Console.Write(' ');
                    } else
                    {
                        System.Console.Write(symbool);
                    }
                }
                System.Console.WriteLine();
            }
        }

        static void PrintGecentreerdePiramide(int diepte, char symbool = '*')
        {
            for (int i = 1; i <= diepte; i++)
            {
                for (int j = 1; j < diepte+i; j++)
                {
                    if (j <= diepte - i)
                    {
                        System.Console.Write(' ');
                    }
                    else
                    {
                        System.Console.Write(symbool);
                    }
                }
                System.Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintLinksuitgelijndePiramide(5);
            System.Console.WriteLine();
            PrintLinksuitgelijndePiramide(5, '+');
            System.Console.WriteLine();
            PrintRechtssuitgelijndePiramide(5, '+');
            System.Console.WriteLine();
            PrintGecentreerdePiramide(10, '+');
            Console.ReadLine();
        }
    }
}
