using System.Collections.Generic;
using vendigo_vending.Interfaces;
using vendigo_vending.Models.ParentClass;

namespace vendigo_vending.Models.VendingTypes
{
    public class SodasVendingMachine<T> : VendingMachine<T>
    {
        public List<T> SodaList = new List<T>();

        public SodasVendingMachine(int capacity, string name) : base(capacity, name)
        {
        }

        private int _current_Stock { get;set;}
    }
}