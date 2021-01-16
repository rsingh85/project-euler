using System;

namespace ProjectEuler
{
    abstract class SolutionBase
    {
        public abstract string ProblemTitle { get; }

        public void Solve()
        {
            Console.WriteLine("Running solution for problem: {0}", ProblemTitle);
            Run();
        }

        public abstract void Run();
    }
}