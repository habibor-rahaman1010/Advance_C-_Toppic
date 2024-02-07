using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Calculator<T> : ICalculator<T>
    {
        public Calculator() { }

        public T Divide(T x, T y)
        {
            dynamic? result = (dynamic?) x / (dynamic?) y;
            return result;
        }

        public T Multiplication(T x, T y)
        {
            dynamic? result = (dynamic?)x * (dynamic?)y;
            return result;
        }

        public T Subtract(T x, T y)
        {
            dynamic? result = (dynamic?)x - (dynamic?)y;
            return result;
        }

        public T Summation(T x, T y)
        {
            dynamic? result = (dynamic?)x + (dynamic?)y;
            return result;
        }
    }
}
