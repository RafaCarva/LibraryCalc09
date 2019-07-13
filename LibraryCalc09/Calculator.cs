using System;
using LibraryCalc09.Entities;

namespace LibraryCalc09
{
    public class Calculator : IOperations
    {
        public Calculator() { }

        public double OperationAdd(double x, double y)
        {
            return x + y;
        }

        public double OperationAdd(double x, double y, double z)
        {
            return x + y + z;
        }

        public double OperationDivide(double x, double y)
        {
            return x / y;
        }

        public double OperationMultiply(double x, double y)
        {
           return x * y;
        }

        public double OperationMultiply(double x, double y, double z)
        {
            return x * y * z;
        }

        public double OperationSubtract(double x, double y)
        {
            return x - y;
        }

        public double OperationSubtract(double x, double y, double z)
        {
            return x - y - z;
        }
    }
}