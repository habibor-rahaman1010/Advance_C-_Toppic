using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class MyDelegates
    {
        public delegate int AddNum(int x, int y);

        public delegate int SubNum(int x, int y);

        public delegate void MulNum(int x, int y);

        public delegate void DivNum(int x, int y);

        public delegate int MathCalculate(int x, int y);

        public AddNum Sum = (int num1, int num2) =>
        {
            return (num1 + num2);
        };

        public SubNum Sub = (int num1, int num2) =>
        {
            return num1 - num2;
        };

        public MulNum Mul = (int num1, int num2) =>
        {
            Console.WriteLine(num1 * num2);
        };

        public void DoDevide(int x, int y, DivNum div)
        {
            div.Invoke(x, y);
        }

        public static void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public float CalculateDiscount(float price, float p, Func<float, float, float> discount)
        {
            return discount.Invoke(price, p);
        }

        public void Profit(float price, float profit, Action<float, float> GetProfit)
        {
            GetProfit.Invoke(price, profit);
        }
    }
}
