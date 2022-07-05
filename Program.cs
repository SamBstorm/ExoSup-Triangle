using System;

namespace ExoSup_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un côté du triangle");
            string input = Console.ReadLine();
            double hypo;
            while (!double.TryParse(input, out hypo))
            {
                Console.WriteLine("Veuillez introduire un nombre...");
                input = Console.ReadLine();
            }
            if (hypo == 0) Console.WriteLine("Triangle impossible...");
            else
            {
                hypo = (hypo < 0) ? hypo * -1 : hypo;
                Console.WriteLine("Veuillez introduire un côté du triangle");
                input = Console.ReadLine();
                double coteA;
                while (!double.TryParse(input, out coteA))
                {
                    Console.WriteLine("Veuillez introduire un nombre...");
                    input = Console.ReadLine();
                }
                if (coteA == 0) Console.WriteLine("Triangle impossible...");
                else
                {
                    coteA = (coteA < 0) ? coteA * -1 : coteA;
                    if (coteA > hypo)
                    {
                        double temp = coteA;
                        coteA = hypo;
                        hypo = temp;
                    }
                    Console.WriteLine("Veuillez introduire un côté du triangle");
                    input = Console.ReadLine();
                    double coteB;
                    while (!double.TryParse(input, out coteB))
                    {
                        Console.WriteLine("Veuillez introduire un nombre...");
                        input = Console.ReadLine();
                    }
                    if (coteB == 0) Console.WriteLine("Triangle impossible...");
                    else {
                        coteB = (coteB < 0) ? coteB * -1 : coteB;
                        if (coteB > hypo)
                        {
                            double temp = coteB;
                            coteB = hypo;
                            hypo = temp;
                        }
                        Console.WriteLine($"Voici votre triangle : {hypo} {coteA} {coteB}");
                        if(hypo > coteB + coteA) Console.WriteLine("Triangle impossible...");
                        else
                        {
                            string angle = "accutangle";
                            string cote = "scalène";
                            if (hypo == coteB && hypo == coteA)
                            {
                                cote = "équilatéral";
                            }
                            else{
                                if (coteA == coteB || hypo == coteA || coteB == hypo)
                                {
                                    cote = "isocèle";
                                }
                                if (hypo * hypo == (coteA * coteA) + (coteB * coteB))
                                {
                                    angle = "rectangle";
                                }
                                else if(hypo * hypo > (coteA * coteA) + (coteB * coteB))
                                {
                                    angle = "obtusangle";
                                }
                            }
                            Console.WriteLine($"C'est un triangle {cote} et {angle}.");
                        }
                    }
                }
            }
        }
    }
}
