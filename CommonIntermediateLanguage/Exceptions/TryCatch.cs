using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonIntermediateLanguage.Exceptions
{
    class TryCatch
    {
        static void Main(string[] args)
        {
        
            //global try-catch block
            try
            {
                ApplicationException.Run($"x");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception was thrown by the application," + $" error message is: {ex.Message}");
            }
        }
    }
}
