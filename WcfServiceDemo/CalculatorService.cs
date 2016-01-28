using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Microsoft.ServiceModel.Samples
{
    public class CalculatorService: ICalculator
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

    }
}