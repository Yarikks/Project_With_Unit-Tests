using System;

namespace TestAnQualityLab
{
    public class Program
    {
        static public void Main(string[] args)
        {
            double a=0, b=0;

            ShowPreview();

            SetNumbers(ref a, ref b);

            ShowResult(TopNumber(a, b), BottomNumber(a, b));         

            Console.ReadLine();
        }

        /// <summary>
        /// Set numbers "a" and "b".
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static public void SetNumbers(ref double a, ref double b)
        {
            Console.Write("Enter number \"a\": ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter number \"b\": ");
            b = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Shows preview (formula).
        /// </summary>
        static public void ShowPreview()
        {
            Console.WriteLine("     Formula\n");
            Console.WriteLine("     2a - b^2");
            Console.WriteLine("x = -----------");
            Console.WriteLine("    3(a^2 - 3b)\n\n");
        }

        /// <summary>
        /// Calculate top number from formula.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public double TopNumber(double a, double b)
        {
            double top = (2 * a) - (b * b);

            return top;
        }

        /// <summary>v
        /// Calculate bottom number from formula.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public double BottomNumber(double a, double b)
#pragma warning restore CS1585 // Модификатор члена "static" должен указываться перед типом и именем члена.
        {
            double bottom = 3 * ((a * a) - (3 * b));

            return bottom;
        }


        /// <summary>
        /// Show result of formula.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        static public void ShowResult(double top, double bottom)
        {
            if (top == 0 || bottom ==0)
            {
                Console.WriteLine("Division by zero! Try another numbers.");
            }
            else
            {
                Console.WriteLine($"Result is: {CalculateResult(top,bottom)}");
            }
        }

        /// <summary>
        /// Calculate result by formula.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        static public double CalculateResult(double top, double bottom)
        {
            return top / bottom;
        }
    }
}
