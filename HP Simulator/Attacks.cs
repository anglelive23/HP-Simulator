using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Simulator
{
    internal class Attacks
    {
        public string AttackName { get; set; }
        public int AttackDamage { get; set; }
        public List<Attacks> AttacksList { get; set; } = new List<Attacks>();

        public Attacks()
        {
        }

        public void RegisterAttacks()
        {
            AttacksList.Add(new Attacks() { AttackDamage = 1, AttackName = "Normal Attack"});
            AttacksList.Add(new Attacks() { AttackDamage = 10, AttackName = "Whirlwind" });
            AttacksList.Add(new Attacks() { AttackDamage = 20, AttackName = "Blitz Rush"});
        }

        public int GetRandomAttackDamage()
        {
            // Random attack generator
            Random randomizer = new Random();
            var randomAttack = randomizer.Next(0, AttacksList.Count); // Random attack generator
            var attackDamage = AttacksList[randomAttack].AttackDamage; // attackDamage of the Random attack

            // Attack warning message
            var message = (attackDamage == 1) ? "Normal attack incoming" : $"Watch out special attack incoming: {AttacksList[randomAttack].AttackName}";
            Console.Write(message);

            return attackDamage;
        }
    }
}
