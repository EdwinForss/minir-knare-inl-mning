using System;
using System.Collections.Generic;

namespace inlämning_10_31
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum;
            float num1;
            float num2;
            Console.WriteLine("Välkomen till min minräknare:)");
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

            public static void CloseProgram()
            {
                System.Environment.Exit(0);
            }










        }



    }




}

