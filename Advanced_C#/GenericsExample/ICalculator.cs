using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public interface ICalculator<T>
    {
        public T Summation(T x, T y);

        public T Subtract(T x, T y);

        public T Multiplication(T x, T y);

        public T Divide(T x, T y); 
    }
}
