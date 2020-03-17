using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallengeEmployee
{
    class Trainee : Employee
    {
        private int _workingHours;

        public int WorkingHours
        {
            get => this._workingHours;
            set
            {
                if (value < 2 && value > 8)
                    throw new Exception("Trainees can only work from 2 to a maximum of 8 hours a day...");
                else
                    this._workingHours = value;
            }
        }

        // Constructor
        public Trainee (string firstName, string lastName, double initialSalary, int workingHours)
            : base(firstName, lastName, initialSalary)
        {
            this.WorkingHours = workingHours;
        }

        // Methods
        public override void ApplyRaise()
        {
            double prevSalary = Salary;
            this.Salary *= Trainee._raiseAmount;
            Console.WriteLine($"{FullName}'s salary was raised from {prevSalary:c} to {Salary:c}");
        }

        public void Learn() => Console.WriteLine($"The trainee {FullName} is learning a lot from their colleages...");
    }
}
