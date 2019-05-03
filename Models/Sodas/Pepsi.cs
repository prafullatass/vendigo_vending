using System;
using System.Collections.Generic;
using vendigo_vending.Interfaces;
using vendigo_vending.Models.ParentClass;

namespace vendigo_vending.Models.Sodas
{
    public class Pepsi : Item, IJapanesSoda
    {
        public List<string> FoodColors {
            get;
            set;
        }
        public bool RfIdChip { set;get; }

        public void RfIdBroadcast () {
            Console.WriteLine("rfid broadcast frequency");
        }
        public Pepsi(string name, int qty, double price) : base(name, qty, price)
        {
        }
    }
}