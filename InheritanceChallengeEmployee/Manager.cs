using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallengeEmployee
{
    class Manager : Employee
    {
        protected new static double _raiseAmount = 1.05;
        private string _companyCar;

        public string CompanyCar
        {
            get => this._companyCar;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("The model of the company car must be a non-empty string...");
                else
                    this._companyCar = value;
            }
        }
        
        // Constructor
        public Manager(string firstName, string lastName, double initialSalary, string companyCarModel)
            : base(firstName, lastName, initialSalary)
        {
            this.CompanyCar = companyCarModel;
        }

        // Method
        public override void ApplyRaise()
        {
            double prevSalary = Salary;
            this.Salary *= Manager._raiseAmount;
            Console.WriteLine($"{FullName}'s salary was raised from {prevSalary:c} to {Salary:c}");
        }

        public void Lead() => Console.WriteLine($"Manager {FullName} is doing a great job leading the team...");

        public override string ToString() => $"Manager {FullName} ({UserID}) with a salary of {Salary:c}";
    }
}
