using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SubOperation : Operation
    {
        public override double Result(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}
