using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal interface ICalc
    {
        event EventHandler GotResult;
        void summ(double x);
        void summ(int x);
        void subtract(double x);
        void subtract(int x);
        void multiply(double x);
        void multiply(int x);
        void divide(double x);
        void divide(int x);
        void RaiseEvent();
    }
}