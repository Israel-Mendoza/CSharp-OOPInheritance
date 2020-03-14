using System;
using System.Collections.Generic;
using System.Text;

namespace FinalApp
{
    class Programmer : Creator
    {
        public override void Create()
        {
            if (base.CreativityLevel > 70 && base.Energy > 80)
            {
                this.BrainStormSolutions();
                this.PickMostOptimalSolution();
                this.WriteCode();
                this.TestCode();
            }
            else
                throw new Exception("Cannot create a program... Programmer is either out of ideas or is tired...");
        }

        private void BrainStormSolutions()
        {
            base.CreativityLevel -= 15;
            base.Energy -= 10;
            Console.WriteLine("Brain storming solutions...");
        }

        private void PickMostOptimalSolution()
        {
            base.CreativityLevel -= 5;
            base.Energy -= 5;
            Console.WriteLine("Picking most optimal solution...");
        }

        private void WriteCode()
        {
            base.CreativityLevel -= 10;
            base.Energy -= 5;
            Console.WriteLine("Witing code...");
        }

        private void TestCode()
        {
            base.CreativityLevel -= 5;
            base.Energy -= 5;
            Console.WriteLine("Testing code...");
        }
    }
}
