using System;
using System.Linq;

namespace ProjectEuler.Problem1
{
    class Solution : SolutionBase
    {
        public override string ProblemTitle => "Multiples of 3 and 5";

        protected override void Run()
        {
            var answer = Enumerable.Range(1, 999)
                .Where(n => n % 3 == 0 || n % 5 == 0)
                .Sum();

            Console.WriteLine(answer);
        }
    }
}
