using System;

namespace Delegates
{
    public class Program
    {
        public delegate int Calculation(int x, int y);
        public static void Main(string[] args)
        {
            MyDelegates myDelegates = new MyDelegates();

            int x = myDelegates.Sum.Invoke(23, 34);
            Console.WriteLine(x);

            myDelegates.DoDevide(30, 2, MyDelegates.Div);

            Calculation mySum = MySumFunc;
            int result = mySum.Invoke(100, 300);
            Console.WriteLine(result);

            MyDelegates.MathCalculate mathCal = MathCal;
            int mathResult = mathCal.Invoke(34, 23);
            Console.WriteLine(mathResult);

            float discountResult = myDelegates.CalculateDiscount(4240, 12, DiscountCalculate);
            Console.WriteLine(discountResult.ToString("F2"));

            myDelegates.Profit(1240, 12, CalculateProfit);
        }

        public static int MySumFunc(int n, int m) => n + m;
        public static int MathCal(int v, int z) => (int)Math.Sqrt(v * v + z * z);
        public static float DiscountCalculate(float x, float p) => (x / 100) * p;
        public static void CalculateProfit(float price, float profit) => Console.WriteLine(((price / 100) * profit).ToString("F2"));
    }
}
