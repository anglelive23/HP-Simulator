using System;

namespace HP_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Attacks attacks = new Attacks(true); // true means Register Initial Attacks
            Simulator simulator = new Simulator(attacks); // Simulate the game with Registered attacks
        }
    }
}
