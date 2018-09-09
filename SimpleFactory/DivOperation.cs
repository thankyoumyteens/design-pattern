using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class DivOperation : Operation
    {
        public override double Result(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException("除数不能为0");
            }
            return number1 / number2;
        }
    }
}
