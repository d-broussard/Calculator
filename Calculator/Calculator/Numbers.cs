using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Numbers
    {
        private int _Num1 = 0;
        private int _Num2 = 0;
        public int Num1 
        {
            get { return _Num1; }
            set { _Num1 = value; }
        }
        public int Num2
        {
            get { return _Num2; }
            set { _Num2 = value; }
        }
    }
}
