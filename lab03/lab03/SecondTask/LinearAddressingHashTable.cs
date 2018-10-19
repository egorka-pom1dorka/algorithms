using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03.SecondTask
{
    public class LinearAddressingHashTable
    {

        private class KeyValue
        {
            public int key;
            public int value;

            public KeyValue(int key, int value)
            {
                this.key = key;
                this.value = value;
            }
        }
        
        private KeyValue[] data;
        private int filled;
        private int stepsForAddingAmount;

        private const int PRIME_NUMBER = 827;

        public LinearAddressingHashTable(int size)
        {
            int neededSize = 1;
            while (neededSize * 2 < size)
                neededSize *= 2;

            data = new KeyValue[neededSize * 2];
            filled = 0;
        }

        public int GetLength()
            => data.Length;

        public int GetSteps()
            => stepsForAddingAmount;

        private int GetHash(int key)
            => (key * PRIME_NUMBER) % data.Length;

        public void Add(int key, int value)
        {
            if (IsFull())
                throw new Exception("HashTable is full");

            stepsForAddingAmount = 1;
            int index = FindPosition(key);
            data[index] = new KeyValue(key, value);
            filled++;
        }

        public bool IsFull()
            => filled == data.Length;

        private int FindPosition(int key)
        {
            int hash = GetHash(key);
            int index = hash;
            int increment = 1;

            while (data[index] != null)
            {
                index = hash + (int)Math.Pow(increment, 2);
                if (index >= data.Length)
                    index %= data.Length;
                increment++;

                stepsForAddingAmount++;
            }

            return index;
        }

        public int GetValue(int key)
        {
            int index = FindValuePosition(key);
            return data[index].value;
        }

        private int FindValuePosition(int key)
        {
            int hash = GetHash(key);
            int index = hash;
            int increment = 1;

            while (data[index].key != key)
            {
                index = hash + (int)Math.Pow(increment, 2);
                if (index > data.Length)
                    index -= (index / data.Length) * data.Length;
                increment++;
            }

            return index;
        }

    }
}
