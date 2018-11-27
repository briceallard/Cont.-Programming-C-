using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdiWorkshop
{
    [Serializable]
    public class Record
    {
        public Record() { }

        public Record(int sku, string name, string category, int quantity, double cost, double price)
        {
            Sku = sku;
            Name = name;
            Category = category;
            Quantity = quantity;
            Cost = cost;
            Price = price;
        }

        public int Sku { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }

        [NonSerialized]
        public string storeName;
    }
}
