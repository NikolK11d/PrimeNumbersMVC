using MVCPrimeNum.Model;
using MVCPrimeNum.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPrimeNum.Controller
{
    public class PrimeNumController
    {
        private PrimeNums primeNums = new PrimeNums();
        private Display display = new Display();

        public PrimeNumController()
        {
            display.Input();
            primeNums.AllNums = display.AllNums;

            display.OnlyPrimeNumbers = primeNums.OnlyPrimeNumbers(primeNums.PrimeNumbers);
            display.Output();

        }
    }
}
