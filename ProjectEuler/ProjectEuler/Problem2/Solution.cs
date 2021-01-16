using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problem2
{
    class Solution : SolutionBase
    {
        public override string ProblemTitle => "Even Fibonacci numbers";

        protected override void Run()
        {
            var fibs = new List<int> { 1, 1 };
            var sum = 0;

            while (true)
            {
                // [^x] == xth index from the end (C# 8.0 feature)
                var fib = fibs[^1] + fibs[^2]; 

                if (fib > 4000000)
                {
                    break;
                }

                sum += (fib % 2 == 0) ? fib : 0;

                fibs.Add(fib);
            }

            Console.WriteLine(sum);
        }
    }
}
