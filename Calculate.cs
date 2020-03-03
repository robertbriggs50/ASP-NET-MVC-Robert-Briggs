using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    class AddCalculate : ICalculate
    {

        public int performCal(int n1, int n2)
        {
            return n1 + n2;
        }

    }
    class SubtractCalculate : ICalculate
    {

        public int performCal(int n1, int n2)
        {
            return n1 - n2;
        }

    }
    class MultiplyCalculate : ICalculate
    {

        public int performCal(int n1, int n2)
        {
            return n1 * n2;
        }

    }
}
