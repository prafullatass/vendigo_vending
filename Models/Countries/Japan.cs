using System.Collections.Generic;
using vendigo_vending.Interfaces;
using vendigo_vending.Models.ParentClass;
namespace vendigo_vending.Models.Countries
{
    public class Japan
    {
        public List<VendingMachine<IJapanesSoda>> vendingMachines =
        new List<VendingMachine<IJapanesSoda>>();

        public List<string> SoldItems = new List<string>();
        public void adjust_Stock(string SoldItemName) {
           SoldItems.Add(SoldItemName);
       }
    }
}