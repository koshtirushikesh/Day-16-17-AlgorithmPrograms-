using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumber
    {
        public void FindPrimeNumber()
        {

            for (int i = 2; i <= 1000; i++)
            {
                bool isPrimeNumber = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    { 
                        isPrimeNumber=false; break; 
                    }
                }

                if (isPrimeNumber)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
