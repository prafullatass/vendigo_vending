using System;
using System.Collections.Generic;
using vendigo_vending.Interfaces;
using vendigo_vending.Models.ParentClass;

namespace vendigo_vending.Models.Sodas {
    public class MountainDew : Item, IJapanesSoda {

        public List<string> FoodColors {
            get;
            set;
        }
        public bool RfIdChip { set;get; }
        public MountainDew (string name, int qty, double price) : base (name, qty, price) { }

        public void RfIdBroadcast () {
            Console.WriteLine("rfid broadcast frequency");
        }
    }
}