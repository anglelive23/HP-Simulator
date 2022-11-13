using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HP_Simulator
{
    internal class Simulator
    {
        public Attacks AttackModel { get; set; }
        public Simulator(Attacks attacks)
        {
            this.AttackModel = attacks; // Get the Attacks
            Simulate(); // Simulate the game
        }

        async void Simulate()
        {
            var hp = 100;
            string message;

            while (hp > 0)
            {
                Thread.Sleep(5000);
                // press button to dodge or get attacked
                if(IsDodgedAttack())
                    Console.WriteLine("You dodged it. keep going.");
                else
                {
                    hp -= AttackModel.GetRandomAttackDamage();
                    message = (hp <= 0) ? ", You're dead" : $", Current HP: {hp}%";
                    Console.WriteLine(message);
                }

            }
        }

        bool IsDodgedAttack()
        {
            // assign random buttons to enter in short time
            char[] buttonsArray = new char[] { 'Q', 'W', 'E', 'A', 'S', 'D' };

            // get random pattern
            Random randomizer = new Random();
            string randomPattern = "";
            while (randomPattern.Length < 7)
            {
                randomPattern += buttonsArray[randomizer.Next(0, buttonsArray.Length)];
            }
            // print the randomPattern
            Console.WriteLine($"{randomPattern}");
            // Get the user input
            var userInput = Console.ReadLine();
            // validate userInput
            return userInput.ToUpper() == randomPattern ? true : false;
        }
    }
}
