using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPrimeNum.Model
{
    public class PrimeNums
    {
        private List<int> allNums;

        public List<int> AllNums
        {
            get { return allNums; }
            set { allNums = value; }
        }


        private List<int> primeNumbers;

        public List<int> PrimeNumbers
        {
            get { return primeNumbers; }
            set { primeNumbers = value; }
        }


        public PrimeNums(List<int> listNumbers)
        {
            this.AllNums = listNumbers;
        }
        public PrimeNums() : this(new List<int>()) { }

        public bool IsPrime(int number)
        {
            bool result = true;

            for (int delitel = 2; delitel < number; delitel++)
            {
                if (number % delitel == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public List<int> OnlyPrimeNumbers(List<int> numbers)
        {
            List<int> resultPrimeNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (IsPrime(item))
                {
                    resultPrimeNumbers.Add(item);
                }
            }
            return resultPrimeNumbers;
        }
    }
}
}
