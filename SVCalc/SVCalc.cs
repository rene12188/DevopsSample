using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVCalc
{
    public class SVCalc
    {
        public float CalculateSV(float input)
        {
            var f = input < 1 ? throw new ArgumentException("Negative number") : input = input;
            double percent = GetClass(input);

            return (float)percent * input;





        }

        private float GetClass(float input)
        {

            if (input < 1000)
                return (float)0.05;
            if (input < 3000)
                return (float)0.1;
            if (input < 5000)
                return (float)0.15;
            if (input > 7000)
                return (float)0.2;

            throw new ArgumentException("tmp");

        }
    }
}
