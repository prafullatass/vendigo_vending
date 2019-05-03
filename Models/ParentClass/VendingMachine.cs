using System.Collections.Generic;

namespace vendigo_vending.Models.ParentClass {
    public class VendingMachine<T> {
        List<T> Products = new List<T> ();
        public string Name {get;set;}
        private int Capacity { get; set; }

        public VendingMachine (int capacity, string name) {
            Capacity = capacity;
            Name = name;
        }
    }
}