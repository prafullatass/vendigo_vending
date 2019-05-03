using vendigo_vending.Models.ParentClass;

namespace vendigo_vending.Models.Sodas
{
    public class RC_Cola : Item
    {
        public RC_Cola(string name, int qty, double price) : base(name, qty, price)
        {
        }
    }
}