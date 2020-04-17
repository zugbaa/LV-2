using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceroller = new DiceRoller();
            int i;

            //1.zadatak
            //for (i = 0; i < 20; i++)
            //{
            //    diceroller.InsertDie(new Die(6));
            //}
            //diceroller.RollAllDice();
            //IList<int> results = diceroller.GetRollingResults();
            //foreach (int result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //zadatak 2
            //Random generator = new Random();
            //for (i = 0; i < 20; i++)
            //{
            //    diceroller.InsertDie(new Die(6,generator));
            //}
            //diceroller.RollAllDice();
            //IList<int> results = diceroller.GetRollingResults();
            //foreach (int result in results)
            //{
            //    Console.WriteLine(result);
            //}
        }
    }
}
