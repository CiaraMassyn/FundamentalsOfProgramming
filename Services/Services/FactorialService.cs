using Services.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class FactorialService : IFactorialService
    {
        /*Why does this create a circle loop thing?
         * private readonly IFactorialService _factorialService;

        public FactorialService(IFactorialService factorialService)
        {
            _factorialService = factorialService;
        }*/

        public int GenerateFactorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                int factorial = 1;
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
