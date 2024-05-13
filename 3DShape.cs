using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    internal class _3DShape : _2DShape
    {
        string answer;

        public string cuboidCalculation(double BaseInput, double HeightInput, double DepthInput)
        {
            double cuboidCalculation = double.Parse((rectangleCalculation(BaseInput, HeightInput))) * DepthInput;

            answer = cuboidCalculation.ToString("0.00");

            return answer;
        }

        public string sqrBasedPy(double BaseEdgeInput, double PerpendicularHeightInput)
        {
            double sqrBasedPyCalculation = (Math.Pow(BaseEdgeInput, 2) * PerpendicularHeightInput / 3);

            answer = sqrBasedPyCalculation.ToString("0.00");

            return answer;
        }

        public string triBasedPy(double BaseLengthInput, double BasePerpendicularHeightInput, double PerpendicularHeightInput)
        {
            double triBasedPyCalculation = ((((BaseLengthInput * BasePerpendicularHeightInput) / 2) * PerpendicularHeightInput) / 3);

            answer = triBasedPyCalculation.ToString("0.00");

            return answer;
        }
    }
}
