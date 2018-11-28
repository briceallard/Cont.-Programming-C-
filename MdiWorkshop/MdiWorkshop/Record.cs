/**
 * Brice Allard
 * Contemporary Programming - C#
 * Dr. Stringfellow
 * 11-27-2018
 * 
 * Inventory Solution Software designed with MDI in mind. One parent form
 * and multiple child forms to maintain the inventory of several locations
 * at once. Menu items are demonstrated as well as sort and serialization
 * for easy data management and file storage.
 **/

using System;

namespace MdiWorkshop
{
    /// <summary>
    /// The data being stored and serialized for multiple save documents
    /// </summary>
    [Serializable]
    public class Record
    {
        // Default Constructor
        public Record() { }

        // Parameritized Constructor
        public Record(int sku, string name, string category, int quantity, double cost, double price)
        {
            Sku = sku;
            Name = name;
            Category = category;
            Quantity = quantity;
            Cost = cost;
            Price = price;
        }

        // Get/Sets - Data for items
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
