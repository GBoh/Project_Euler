using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    public class Euler3and5Multiples {
        public static void SolvedProblem() {
            var total = 0;

            for (int i = 0; i < 1000; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    total += i;
                }
            }
            Console.WriteLine("The total is " + total);
            Console.ReadLine();
        }
    }
}
