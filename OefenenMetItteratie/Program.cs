using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenenMetItteratie
{
    class Program
    {
            //Elias Claeys 5ITN 10/12/2020
            /*Opgave:
             * Je bent in een winkel en wilt weten wat het eindtotaal 
             * is van alle producten die je hebt gekocht. Je gaat dit doen
             * door eerst het product en de prijs te vragen tot dat de gebruiker.
             * Enter in geeft. En op het einde dan u eindtotaal te tonen.
             * 
             * ANALYSE:
             * VRAAG: product
             * ALS: product = ""
             * HERHAAL: while = false
             * VRAAG: prijs
             * VRAAG: product
             * while = true
             * BEREKEN: Eindtotaal
             * TOON: $"Je eindtotaal is {eindtotaal}"
             */
        static void Main(string[] args)
        {
            //Declarations
            string product;
            double prijs, eindtotaal;

            //INITIALISATIE
            eindtotaal = 0.0;

            //VRAAG: product
            Console.Write("Wat is de naam van het product ");
            product = Console.ReadLine();
           
            //HERHAAL: while = false
            while (product != "") 
            {
                //VRAAG: prijs
                Console.Write("Wat is de prijs van het product ");
                prijs = double.Parse(Console.ReadLine());
                    
                //TOON: Product + Prijs
                Console.WriteLine($"{product}: {prijs}");

                //BEREKEN: eindtotaal
                eindtotaal = eindtotaal + prijs;

                //VRAAG: product
                Console.Write("Wat is de naam van het product ");
                product = Console.ReadLine();
            }

            //TOON: eindtotaal
            Console.WriteLine($"Het eindtotaal is {eindtotaal}");

            //Wachten...
            Console.WriteLine();
            Console.Write("Druk op enter om af te sluiten");
            Console.ReadLine();
        }
    }
}
