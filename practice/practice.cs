using System;
class Practice
{
    public static void Main(string[] args)
    {
        Practice practice = new Practice();
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(practice.MaxProfit(prices));
    }
    public int MaxProfit(int[] prices)
    {
        int temp = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[i] < prices[j])
                {
                    temp += prices[j] - prices[i];
                    i = j;
                }
                else
                {
                    i = j;
                }
            }
            if (prices[i] < prices[i + 1])
            {
                temp += prices[i + 1] - prices[i];
            }
            
        }
        return temp;

    }
}