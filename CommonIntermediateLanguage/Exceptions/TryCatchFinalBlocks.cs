using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonIntermediateLanguage.Exceptions
{
    class TryCatchFinalBlocks
    {
        private static int? DivideNumbers(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Attempt to divide by zero. " + $" Exception message: {ex.Message}" );
                return null;
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }
        }
    }
}
