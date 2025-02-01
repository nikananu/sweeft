using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CoinCalculator
    {
        public static int MinCoins(int amount)
        {
            int[] coins = { 50, 20, 10, 5, 1 };
            int count = 0;

            foreach (int coin in coins)
            {
                while (amount >= coin)
                {
                    amount -= coin;
                    count++;
                }
            }

            return count;
        }
    }
}
