using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            return double.TryParse(argTextInput, out double convertedNumber) ? convertedNumber : throw new ArgumentException("Expected a numeric value.");
        }
    }
}
