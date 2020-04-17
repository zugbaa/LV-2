using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Die
    {
        private int numberOfSides;
        //private Random randomGenerator;
        private RandomGenerator randomGenerator;

        //zadatak 1
        //public Die(int numberOfSides)
        //{
        //    this.numberOfSides = numberOfSides;
        //    this.randomGenerator = new Random();
        //}

        //zadatak 2
        //public Die(int numberOfSides, Random randomGenerator)
        //{
        //    this.numberOfSides = numberOfSides;
        //    this.randomGenerator = randomGenerator;
        //}

        //zadatak 3
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }


        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
