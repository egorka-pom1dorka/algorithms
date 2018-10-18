using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03.FirstTask
{
    public class HashTable
    {

        private class KeyValue {

            public int key;
            public int value;

            public KeyValue(int key, int value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private int size;
        private List<KeyValue>[] lists;
        private double @const;

        private const int PRIME_NUMBER = 827;

        public HashTable(int size)
        {
            @const = Knut();
            this.size = size;
            lists = new List<KeyValue>[size];
            for (int i = 0; i < size; i++)
                lists[i] = new List<KeyValue>();
        }

        private double Knut()
            => (Math.Sqrt(5) - 1) / 2;

        public int GetSize()
            => size;

        public void SetConst(double number)
            => @const = number;

        private int GetHash(int number)
        {
            number %= PRIME_NUMBER;
            double fractionPart = (number * @const) % 1;
            return (int) Math.Floor(fractionPart * size);
        }

        public void Add(int key, int value)
        {
            int index = GetHash(key);
            lists[index].Add(new KeyValue(key, value));
        }

        public int? GetValue(int key)
        {
            int index = GetHash(key);
            foreach (var item in lists[index])
            {
                if (item.key == key)
                    return item.value;
            }

            return null;
        }

        public int GetMaxListSize()
        {
            int max = 0;
            for (int i = 0; i < size; i++)
            {
                max = lists[i].Count() > max ? lists[i].Count() : max;
            }
            
            return max;
        }

        public void Show()
        {
            for (int i = 0; i < size; i++)
            {
                foreach (var item in lists[i])
                    Console.Write($"Index: {i}, key: {item.key}, value: {item.value} ||| ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
