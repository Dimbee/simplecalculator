using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class StringTointConverter
    {
        public int convert(string input)
        {
            try
            {
                int convertedNumber;
                bool isConvertedSuccessfully = int.TryParse(input, out convertedNumber);

                if (!isConvertedSuccessfully)
                {
                    throw new Exception("Conversion was not successful.");
                }

                return convertedNumber;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
