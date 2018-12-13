using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    public static class Dynamic
    {

        public static int BackPack(List<Item> items, int weight)
        {
            var prices = new int[items.Count()][];
            for (int i = 0; i < items.Count(); i++)
            {
                prices[i] = new int[weight];
                for (int j = 0; j < weight; j++)
                    prices[i][j] = 0;
            }

            for (int i = 0; i < items.Count(); i++)
            {
                var item = items.ElementAt(i);
                for (int j = 1; j < weight; j++)
                {
                    int k = j / item.weight;
                    k = k > item.amount ? item.amount : k;
                    int price1 = k * item.price;
                    int price2 = i - 1 >= 0 ? prices[i - 1][j] : 0;
                    int biggerPrice = price2 > price1 ? price2 : price1;
                    prices[i][j] = biggerPrice;
                }
            }

            return prices[items.Count() - 1][weight - 1];
        }

        public static int GetHoursesVariants(int length, int height)
        {
            int[][] variants = new int[length][];
            for (int i = 0; i < length; i++)
            {
                variants[i] = new int[height];
                for (int j = 0; j < height; j++)
                    variants[i][j] = 0;
            }

            variants[0][0] = 1;
            for (int i = 1; i < length; i++)
            {
                for (int j = 1; j < height; j++)
                {
                    int s1 = i - 2 >= 0 && j - 1 >= 0 ? variants[i - 2][j - 1] : 0;
                    int s2 = i - 1 >= 0 && j - 2 >= 0 ? variants[i - 1][j - 2] : 0;
                    variants[i][j] = s1 + s2;
                }
            }

            return variants[length - 1][height - 1];
        }

        public static int GetMaxPolyndrom(string haystack)
        {
            int len = haystack.Length;
            int maxLength = 1;
            int size = 2;

            while (size <= len)
            {
                for (int i = 0; i < len - size + 1; i++)
                {
                    string check = haystack.Substring(i, size);
                    bool isPolyndrom = true;

                    for (int j = 0; j < check.Length / 2; j++)
                    {
                        if (check.ElementAt(j) != check.ElementAt(check.Length - j - 1))
                        {
                            isPolyndrom = false;
                            break;
                        }
                    }

                    if (isPolyndrom && size > maxLength)
                        maxLength = size;
                }

                size++;
            }

            return maxLength;
        }

        public static List<int> GetMaxNonDesceasingSequence(int[] sequence)
        {
            List<int> maxSequnce = new List<int>();
            List<int> temp = new List<int>();
            temp.Add(sequence[0]);

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] >= sequence[i - 1])
                    temp.Add(sequence[i]);
                else
                {
                    if (temp.Count() > maxSequnce.Count())
                    {
                        maxSequnce.Clear();
                        foreach (var number in temp)
                            maxSequnce.Add(number);
                    }
                    temp.Clear();
                    temp.Add(sequence[i]);
                }
            }

            return maxSequnce;
        }

    }

}
