using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    public class Item
    {
        public int amount { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

        public Item(int amount, int weight, int price)
        {
            this.amount = amount;
            this.price = price;
            this.weight = weight;
        }
    }
}
