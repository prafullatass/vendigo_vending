namespace vendigo_vending.Models.ParentClass
{
    public class Item
    {
        public string Name {get;set;}
        public int Qty { get;set; }
        public double Price {get;set;}
        public Item (string name, int qty, double price) {
            Name = name;
            Qty = qty;
            Price = price;
        }
        public void addStock (int newStock) {
            Qty += newStock;
        }
    }
}