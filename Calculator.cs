using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Calculator : ICalc
    {
        public event EventHandler GotResult;
        public double Result = 0;
        private Stack<double> Results = new();

        public void divide(double x)
        {
            if (x == 0)
            {
                Console.WriteLine("Деление на 0 невозможно.");
            }
            else
            {
                Result /= x;
                RaiseEvent();
            }
            Results.Push(Result);
        }

        public void multiply(double x)
        {
            Results.Push(Result);
            Result *= x;
            RaiseEvent();
        }

        public void RaiseEvent()
        {
            GotResult?.Invoke(this, EventArgs.Empty);
        }

        public void subtract(double x)
        {
            Results.Push(Result);
            Result -= x;
            RaiseEvent();
        }

        public void summ(double x)
        {
            Results.Push(Result);
            Result += x;
            RaiseEvent();
        }

        public void CancelLastAction()
        {
            Result = Results.Pop();
            RaiseEvent();
        }

        public int getResultsCount()
        {
            return Results.Count;
        }

        public void summ(int x)
        {
            Results.Push(Result);
            Result += x;
            RaiseEvent();
        }

        public void subtract(int x)
        {
            Results.Push(Result);
            Result -= x;
            RaiseEvent();
        }

        public void multiply(int x)
        {
            Results.Push(Result);
            Result *= x;
            RaiseEvent();
        }

        public void divide(int x)
        {
            if (x == 0)
            {
                Console.WriteLine("Деление на 0 невозможно.");
            }
            else
            {
                Result /= x;
                RaiseEvent();
            }
            Results.Push(Result);
        }
    }
}