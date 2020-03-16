using System;
using System.Collections.Generic;
using System.Text;

namespace FinalApp
{
    public abstract class Creator
    {

        // Fields
        private int _creativityLevel = 100;
        private int _energy = 100;

        // Properties
        public int CreativityLevel 
        { 
            get => _creativityLevel;
            set
            {
                if (value >= 0 && value <= 100)
                    _creativityLevel = value;
                else
                    throw new Exception("CreativityLevel can only be a value between 0 and 100");
            }
        }
        
        public int Energy 
        { 
            get => _energy;
            set
            {
                if (value >= 0 && value <= 100)
                    _energy = value;
                else
                    throw new Exception("Energy can only be a value between 0 and 100");
            } 
        }

        // Methods
        public abstract void Create();

    }
}
