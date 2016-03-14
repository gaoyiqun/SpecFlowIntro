using System;

namespace SpecFlowIntro
{
    public class Calculator
    {
        public int FirstNumber { get; internal set; }
       
        public int SecondNumber { get; internal set; }

        public void Add()
        {
            this.Result = this.FirstNumber + this.SecondNumber;
        }

        public int Result { get; internal set; }
    }
}