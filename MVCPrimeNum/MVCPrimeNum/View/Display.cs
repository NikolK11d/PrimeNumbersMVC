using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPrimeNum.View
{
    public class Display
    {
        public List<int> AllNums { get; set; }    
        public List<int> ListPrimeNumbers { get; set; }
        public List<int> OnlyPrimeNumbers  {get; set; }

        public void Input()
        {
            Console.WriteLine("Въведете числа на един ред с интервал");
            AllNums = Console.ReadLine().Split().Select(int.Parse).ToList();
        }
        public void Output()
        {
            Console.WriteLine(string.Join(", ", OnlyPrimeNumbers));
        }
    }
}
