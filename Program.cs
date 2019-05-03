using System;
using vendigo_vending.Models.Countries;
using vendigo_vending.Models.Sodas;
using vendigo_vending.Interfaces;
using vendigo_vending.Models.VendingTypes;
using vendigo_vending.Models.ParentClass;

namespace vendigo_vending {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("1 - Japan");
            Console.WriteLine ("2 - Spain");
            Console.WriteLine ("3 - US");
            string country;
            for (; ; ) {
                Console.Write ("Choose a Country : ");
                country = Console.ReadLine();
                try {
                    if (Int32.Parse (country) >= 4) {
                        Console.WriteLine ("Choose the correct option!!");
                    } else {
                        break;
                    }
                } catch (System.FormatException) {

                    Console.WriteLine("Choose a No. !!");
                }
            }
            Console.WriteLine (country);
            //Japan japan = new Japan(20);

            Coke coke = new Coke("Coke", 20, 12.99);
            Pepsi pepsi = new Pepsi("Pepsi", 10, 2.30);

            SodasVendingMachine<IJapanesSoda> jSodaVending = new SodasVendingMachine<IJapanesSoda>(25, "SODA");
            jSodaVending.SodaList.Add(coke);
            jSodaVending.SodaList.Add(pepsi);

            Japan japan = new Japan();
            japan.vendingMachines.Add((VendingMachine<IJapanesSoda>) jSodaVending);
            Console.WriteLine(jSodaVending.Name);
            japan.vendingMachines.ForEach(v => {
                Console.WriteLine($"{v.Name}");
            });
        }
    }
}