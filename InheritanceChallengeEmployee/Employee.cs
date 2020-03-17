using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallengeEmployee
{
    public abstract class Employee
    {

        protected static double _raiseAmount = 1.04;
        
        // Fields
        private string _firstName;
        private string _lastName;
        private double _salary;
        private string _email;
        private string _userID;
        private bool _isWorking = false;

        // Propertied
        public string FirstName 
        { 
            get => this._firstName;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("First name must be a non-empty string");
                else
                    this._firstName = value;
            }
        }

        public string LastName
        {
            get => this._lastName;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Last name must be a non-empty string");
                else
                    this._lastName = value;
            }
        }

        public string FullName { get => $"{FirstName} {LastName}"; }

        public double Salary { get => this._salary; protected set => this._salary = value; }

        public string Email { get => this._email; }

        public string UserID { get => this._userID; }

        protected bool IsWorking { get => this._isWorking; set => this._isWorking = value; }

        // Constructor

        public Employee (string firstName, string lastName, double initialSalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._salary = initialSalary;
            this._email = $"{FirstName}.{LastName}@company.com";
            this._userID = $"{FirstName[0].ToString().ToLower()}{LastName.ToLower()}";
        }


        // Methods

        public abstract void ApplyRaise();

        public virtual void Work()
        {
            if (IsWorking)
                Console.WriteLine("Employee is already working...");
            else
            {
                IsWorking = true;
                Console.WriteLine("Employee is now working...");
            }
        }

        public virtual void Pause()
        {
            if (IsWorking)
            {
                IsWorking = false;
                Console.WriteLine("Employee has stopped working...");
            }
            else
                Console.WriteLine("Employee was not working...");
        }

        public override string ToString() => $"Employee {FullName} ({UserID}) with a salary of {Salary:c}";
    }
}
