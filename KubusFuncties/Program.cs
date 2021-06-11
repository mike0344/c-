using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KubusFuncties
{
    class Program
    {
        static double OmtrekKubus(double lengte)
        {
            int ribben = 12;
            return ribben * lengte;
        }

        static double OppervlakteZijde(double lengte)
        {
            return lengte * lengte;
        }

        static double OppervlakteKubus(double lengte)
        {
            int zijden = 6;
            return OppervlakteZijde(lengte) * zijden;
        }

        static double InhoudKubus(double lengte)
        {
            return OppervlakteZijde(lengte) * lengte;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dit programma berekent de oppervlakte omtrek en inhoud van een kubus.\n" +
                                "Geef de lengte van 1 zijde:");
            double zijde = 0.0;
            string input = Console.ReadLine();
            
            if (!Double.TryParse(input, out zijde)) 
            {
                Console.WriteLine("Voer een getal in.");
            }
            else
            {
                Console.WriteLine("Een kubus met lengte van {0} decimeter.", zijde);
                Console.WriteLine("Heeft een omtrek van {0} decimeter.", OmtrekKubus(zijde));
                Console.WriteLine("Heeft een oppervlakte van {0} decimeter.", OppervlakteKubus(zijde));
                Console.WriteLine("Heeft een inhoud van {0} decimeter.", InhoudKubus(zijde));
                // op dezelfde manier oppervlakte en inhoud laten zien

            }
                

            Console.ReadLine();
        }
    }
}
