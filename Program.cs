using System;
using System.Collections.Generic;

namespace miniräknare
{

        class Calc
        {
            public static List<string> räknalista = new List<string>();

            public static float Add(float num1, float num2)
            {
                char testOp = '+';
                float sum = (num1 + num2);
                Addräkna(num1, num2, testOp, sum);
                return sum;
            }

            public static float Sub(float num1, float num2)
            {
                char testOp = '-';
                float sum = (num1 - num2);
                Addräkna(num1, num2, testOp, sum);
                return sum;
            }

            public static float Multi(float num1, float num2)
            {
                char testOp = '*';
                float sum = (num1 * num2);
                Addräkna(num1, num2, testOp, sum);
                return sum;
            }

            public static float Div(float num1, float num2)
            {
                char testOp = '/';
                float sum = (num1 / num2);
                Addräkna(num1, num2, testOp, sum);
                return sum;
            }


            public static void Addräkna(float num1, float num2, char testOp, float sum)
            {

                string cal1 = num1.ToString();
                string cal2 = testOp.ToString();
                string cal3 = num2.ToString();
                string cal4 = sum.ToString();

                string calc = cal1 + " " + cal2 + " " + cal3 + " " + " = " + cal4;
                räknalista.Add(calc);
            }

            public static void PrintCalc()
            {
                for (int i = 0; i < räknalista.Count; i++)
                {
                    Console.WriteLine(räknalista[i]);
                }
            }

           

        class Startmenu
        {

            static void Main(string[] args)

            {
                int start = 0;

                do
                {

                    bool invalidInput = false;

                    do
                    {
                        Console.WriteLine("välkomen till min miniräknare!");
                        
                        Console.WriteLine("tryck 1 för att räkna ");
                        Console.WriteLine("tryck 2 för att se dina tidigare uträkningar ");

                        try
                        {
                            start = int.Parse(Console.ReadLine());
                            invalidInput = false;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("välj mellan 1 och 2...");
                            invalidInput = true;
                        }

                    } while (invalidInput);

                    switch (start)
                    {
                        case 1:
                            Calkylator.Välja();
                            break;

                        case 2:
                            Calc.PrintCalc();
                            break;                        

                        default:
                            Console.WriteLine("försök igen...");
                            break;

                    }

                } while (start != 0);

            }
        }







        class Calkylator
        {
            public static void Välja ()
            {
                int meny = 0;
                float sum;
                float num1;
                float num2;
                Console.WriteLine("skriv ditt namn: ");
                string namn = Console.ReadLine();
                Console.Write("hej: ");
                Console.WriteLine(namn);
                Console.WriteLine("skriv in 2 tal: ");
                num1 = float.Parse(Console.ReadLine());
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("välj vilket räknesätt du vill använda: ");
                Console.WriteLine("A.Addition");
                Console.WriteLine("B.Subtraktion");
                Console.WriteLine("C.Multiplikation");
                Console.WriteLine("D.Division");



                switch (Console.ReadLine())
                {
                    case "a":
                        sum = Calc.Add(num1, num2);
                        Console.WriteLine(sum);
                        break;

                    case "b":
                        sum = Calc.Sub(num1, num2);
                        Console.WriteLine(sum);
                        break;

                    case "c":
                        sum = Calc.Multi(num1, num2);
                        Console.WriteLine(sum);
                        break;

                    case "d":
                        while (num2 == 0)
                        {
                            Console.WriteLine("Kan inte dividera med 0: ");
                            Console.WriteLine("skriv in nytt nummer: ");
                            num2 = float.Parse(Console.ReadLine());
                        }
                        sum = Calc.Div(num1, num2);
                        Console.WriteLine(sum);
                        break;
                }
            }


        



            }








        }









    }
























