using System;
using System.Runtime.InteropServices;

namespace part1_operators_nd_values
{
    enum Months
    {
        Jan = 1, Feb, Mar, apr, May, Jun, Jul, Aug, Sept, Oct, Nov, Dec
    };

    class Program
    {
        static void Main(string[] args)
        {
            int numa = 20;
            int numb = 10;

            Console.WriteLine(" ------------------ arithmetic operators -------------------");
            Console.WriteLine( numa + numb);
            Console.WriteLine( numa - numb);
            Console.WriteLine( numa * numb);
            Console.WriteLine( numa / numb);
            Console.WriteLine( numa % numb);
            Console.WriteLine(++numa);
            Console.WriteLine(--numb);
            Console.ReadKey();

            Console.WriteLine(" ------------------ comparision operators -------------------");
            if(numa == numb)
            {
                Console.WriteLine(numa + " " + numb + " equal");
            }
            else
            {
                Console.WriteLine(numa + " " + numb + " not equal");
            }

            if(numa != numb)
                Console.WriteLine(numa + " != " + numb + " not equal");

            if (numa > numb)
                Console.WriteLine(numa + " > " + numb);

            if(numa < numb)
            {
                Console.WriteLine(numa + " < " + numb);
            }
            else
            {
                Console.WriteLine(numa + " else: not < " + numb);
            }

            if (numa >= numb)
                Console.WriteLine(numa + " >= " + numb);

            if(numa <= numb)
            {
                Console.WriteLine(numa + " <= " + numb);
            }
            else
            {
                Console.WriteLine(numa + " else: not <= " + numb);
            }

            Console.ReadKey();
            Console.WriteLine(" -------------------- Logical operators -----------------------------");

            if(numa == 21 && numb == 9)
            {
                Console.WriteLine(numa + " true && " + numb);
            }
            else
            {
                Console.WriteLine(numa + " else && " + numb);
            }

            if(numa == 9 || numb == 21)
            {
                Console.WriteLine(numa + " true || " + numb);
            }
            else
            {
                Console.WriteLine(numa + " else || " + numb);
            }

            if (!(numa == 21 && numb == 9))
            {
                Console.WriteLine(numa + " true !NOT " + numb);
            }
            else
            {
                Console.WriteLine(numa + " else !NOT " + numb);
            }
            Console.ReadKey();

            Console.WriteLine(" ---------------- LogicalAnd ----------------------- ");
            if(Method1() & Method2())
            {
                Console.WriteLine("both methods retrun true");
            }
            else
            {
                Console.WriteLine("At least one of the methods returned false.");
            }

            Console.WriteLine("\nShortcut AND:");
            if(Method1() && Method2())
                Console.WriteLine("both methods retrun true");
            else
                Console.WriteLine("At least one of the methods returned false.");
            Console.ReadKey();

            var sum = numa += numb;
            var sum1 = numa -= numb;
            var sum2 = numa *= numb;
            var sum3 = numa /= numb;
            var sum4 = numa %= numb;
            var sum5 = numa <<= numb;
            var sum6 = numa >>= numb;
            var sum7 = numa &= numb;
            var sum8 = numa ^= numb;
            var sum9 = numa != numb;

            Console.WriteLine(sum + " += ");
            Console.WriteLine(sum1 + " -= ");
            Console.WriteLine(sum2 + " *= ");
            Console.WriteLine(sum3 + " /= ");
            Console.WriteLine(sum4 + " %= ");
            Console.WriteLine(sum5 + " <<= ");
            Console.WriteLine(sum6 + " >>= ");
            Console.WriteLine(sum7 + " &= ");
            Console.WriteLine(sum8 + " ^= ");
            Console.WriteLine(sum9 + " != ");
            Console.ReadKey();

            Console.WriteLine(" -------------- Ternary operator with Sin ----------------------");
            Console.WriteLine(mySin(30 * Math.PI / 180.0) + " - mySin(30 * Math.PI / 180.0)");
            Console.WriteLine(mySin(0.0) + " - mySin(0.0)");
            Console.ReadKey();

            Console.WriteLine(" ------------------ switch case ---------------------");

            int number = 10;

            switch(number)
            {
                case 0:
                case 2:
                case 5:
                        Console.WriteLine("It was 0,2, 5");
                    break;

                case 10:
                case 20:
                    Console.WriteLine("It was 10, 20");
                    break;

                default:
                    Console.WriteLine("Others");
                    break;
            }

            Console.ReadKey();

            Console.WriteLine(" --------------- rock paper sciccors game -------------------- ");
            Console.WriteLine(RockPaperScissors("rock", "paper"));
            Console.WriteLine(RockPaperScissors("paper", "scissors"));
            Console.WriteLine(RockPaperScissors("scissors", "rock"));
            Console.ReadKey();

            Console.WriteLine(" ------------ for and foreach --------------------- ");

            int[] arrGrades = new int[] { 78, 89, 90, 76, 98, 65 };
            Console.WriteLine(foreachMethod(arrGrades));
            Console.WriteLine("\n\n");
            Console.ReadKey();

            Console.WriteLine(" ------------- doWhile ----------------- ");
            int num = 0;
      
            do
            {
                Console.WriteLine(num);
                num++;

            } while (num < 10);
            Console.ReadKey();

            Console.WriteLine(" ------------- values types ------------- ");
            int n1 = 1;
            long n2 = 1;
            Console.WriteLine("n1 = 1 " + n1.GetType().ToString());
            Console.WriteLine("n2 = 1 " + n2.GetType().ToString());
            Console.ReadKey();

            Console.WriteLine("------------------ formating numeric types ---------------");
            Console.WriteLine("currency " + "{0:C}", 2.5);
            Console.WriteLine("decimal " + "{0:D5}", 25);
            Console.WriteLine("scentific " + "{0:E}", 250000);
            Console.WriteLine("fixed-point " + "{0:F2}", 25);
            Console.WriteLine("general " + "{0:G}", 2.5);
            Console.WriteLine("number " + "{0:N}", 2500000);
            Console.WriteLine("hexadecimal " + "{0:X}", 0xffff);
            Console.ReadKey();

            Console.WriteLine(" -------------------------- ENUM ------------------------------- ");
            string name = Enum.GetName(typeof(Months), 7);
            Console.WriteLine("The 7th month in the enum is " + name);
            Console.WriteLine("The underlying values of the months enum: ");

            foreach(int values in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(values + " ");
            }
            Console.ReadKey();

            Console.WriteLine(" -------------------------- Struct ------------------------------- ");
            Coordinates c1 = new Coordinates();
            Coordinates c2 = new Coordinates(1, 1);
            Coordinates c3;

            c3.x = 2;
            c3.y = 2;

            Console.Write("Coords 1: ");
            Console.WriteLine("x = {0}, y = {1}", c1.x, c1.y);

            Console.Write("Coords 2: ");
            Console.WriteLine("x = {0}, y = {1}", c2.x, c2.y);

            Console.Write("Coords 3: ");
            Console.WriteLine("x = {0}, y = {1}", c3.x, c3.y);
            Console.ReadKey();



        } //end of  static void Main

        static bool Method1()
        {
            Console.WriteLine("Method1 called.");
            return false;
        }

        static bool Method2()
        {
            Console.WriteLine("Method2 called.");
            return true;
        }

        static double mySin(double x)
        {
            return x != 0.0 ? Math.Sin(x) : 1.0;
        }

        public static string RockPaperScissors(string first, string second) => (first, second) switch
        {
            ("rock", "paper") => "rock is covered by paper. Paper wins",
            ("rock", "scissors") => "rock breaks scissors. Rock wins",
            ("paper", "rock") => "paper covers rock. Paper wins.",
            ("paper", "scissors") => "paper is cut by sciccors. Scissors wins.",
            ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
            ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
            (_, _) => "tie to trie"
        };

        public static int foreachMethod(Array arrGrades)
        {
            int total = 0, gradeCount = 0;

                foreach(int grade in arrGrades)
                {
                    total = total + grade;
                    gradeCount++;
                }

                return total / gradeCount;
        }

        public static int doWhileMethod(int num)
        {
            do
            {
                num++;
                return num;

            } while (num < 10);
        }

        public struct Coordinates
        {
            public int x, y;

            public Coordinates(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

    }
}
