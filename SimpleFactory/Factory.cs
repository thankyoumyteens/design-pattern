using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class Factory
    {
        public static Operation GetInstance(String op)
        {
            switch (op)
            {
                case "+":
                    return new AddOperation();
                case "-":
                    return new SubOperation();
                case "*":
                    return new MulOperation();
                case "/":
                    return new DivOperation();
                default:
                    return null;
            }
        }
    }
}
