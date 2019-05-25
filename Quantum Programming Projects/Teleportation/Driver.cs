using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Teleportation
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                var res = Teleportation.Run(qsim, 10000).Result;
                var (prob_0, prob_1) = res;
                System.Console.WriteLine(
                 $"The probabilities of getting 0 and 1 are {prob_0/10000.0} and {prob_1/10000.0}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}