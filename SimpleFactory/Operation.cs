using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class Operation
    {
        public abstract double Result(double number1, double number2);
    }
}
