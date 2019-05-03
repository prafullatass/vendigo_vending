
// List of colors - Must list all food colors used in the product
// RfId Frequency - All Japanese products must have an rfid chip in them
// RfIdBroadcast() - This method will print a message that states the rfid broadcast frequency

using System.Collections.Generic;

namespace vendigo_vending.Interfaces
{
    public interface IJapanesProduct
    {
        List<string> FoodColors{get;set;}
        bool RfIdChip{set;}
        void RfIdBroadcast();

    }
}