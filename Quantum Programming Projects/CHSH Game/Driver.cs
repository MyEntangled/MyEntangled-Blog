using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.CHSH
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                var res = CHSH_Game.Run(qsim, 1000).Result;
                System.Console.WriteLine(
                  $"Your win rate is {res}/1000");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}