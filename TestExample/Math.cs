using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    public interface IMathematics
    {
        int Divide(int number1, int number2);
    }
    public class Math : IMathematics
    {
        public int Divide(int number1, int number2)
            => number1 / number2;
    }
}
