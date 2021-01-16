using System;

namespace ProjectEuler
{
    abstract class SolutionBase
    {
        public abstract string ProblemText { get; }

        public void Solve()
        {
            Console.WriteLine("Running solution for problem: {0}", ProblemText);
            Run();
        }

        public abstract void Run();
    }
}