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
            var next = fibs[^1] + fibs[^2]; // [^x] == xth index from the end (C# 8.0 feature)
            var sum = 0;

            while (next < 4000000)
            {
                fibs.Add(next);
                sum += (next % 2 == 0) ? next : 0;
                next = fibs[^1] + fibs[^2];
            }

            Console.WriteLine(sum);
        }
    }
}