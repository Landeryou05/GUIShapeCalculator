using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    internal class _2DShape
    {
        public double calculation;
        public string answer;

        public string rectangleCalculation(double BaseInput, double HeightInput)
        {
            calculation = BaseInput * HeightInput;
            answer = calculation.ToString("0.00");

            return answer;
        }

        public string traingleCalculation(double BaseInput, double PerpendicularHeightInput)
        {
            calculation = (BaseInput * PerpendicularHeightInput) / 2;
            answer = calculation.ToString("0.00");

            return answer;
        }

        public string circleCalculation(double radiusInput)
        {
            calculation = Math.PI * Math.Pow(radiusInput, 2);
            answer = calculation.ToString("0.00");

            return answer;
        }
    }
}
