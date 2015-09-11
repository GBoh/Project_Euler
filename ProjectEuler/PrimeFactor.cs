using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    public class PrimeFactor {
        public static void SolvedProblem() {

            //variables
            var numberToFactor = 600851475143;
            long factorDiv = numberToFactor;
            List<long> primeFactors = new List<long>();
            List<int> PrimeNumbers = new List<int>();
            var primeNumber = 2;//starting prime number
            PrimeNumbers.Add(primeNumber);//adds starting number to list

            //iterate through prime numbers to check if factorDiv is evenely divisible by a prime number
            while (true) {
                for (int i = 0; i < PrimeNumbers.Count; i++) {
                    if (factorDiv % PrimeNumbers[i] == 0) {
                        factorDiv /= PrimeNumbers[i];

                        primeFactors.Add(PrimeNumbers[i]);
                        if (IsPrimeFactor(primeFactors, numberToFactor)) {
                            Console.WriteLine("done");
                            break;
                        };
                    }
                }

                primeNumber++;
                if (IsPrime(primeNumber)) {
                    PrimeNumbers.Add(primeNumber);//adds prime number to the primeNumbers' list
                }
            }
        }


        //determines if the current prime numbers are a factor of the numberToFactor
        public static bool IsPrimeFactor(List<long> listOfNumbers, long numberToFactor) {
            var factor = 1L;
            foreach (var number in listOfNumbers) {
                factor *= number;
                if (numberToFactor == factor) {

                    //writes all the numbers of the prime factor
                    Console.Write("Number has been factored \n");
                    foreach (var numb in listOfNumbers) {
                        Console.WriteLine(numb);
                    }
                    return true;
                }
            }
            return false;
        }


        //determines if the number is prime
        public static bool IsPrime(int number) {
            var sqrNum = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= sqrNum; i++) {
                if (number % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
