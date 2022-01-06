using System;

namespace GuardiansApp.Models
{
    public class Ship
    {
        public int caliber25 { get; set; }
        public int caliber30 { get; set;}
        public int caliber50 { get; set; }
        public string shipstatus { get; set; }
        public bool ready { get; set; }
        public int storage { get; set; }

        public Ship()
        {
            caliber25 = 5000;
            caliber30 = 5000;
            caliber50 = 0;
            storage = StorageUpdate();
            shipstatus = ShipStatusUpdate();
            
        }

        public string ShipStatusUpdate()
        {
            if (storage == 0)
            {
                ready = false;
                return "empty";
                
            }

            if (storage == 12500)
            {
                ready = true;
                return "full";
                
            }

            if(storage > 12500)
            { 
                ready = false;
                return "overload";
                
            }
            else
            {
                ready = false;
                return ((storage * 100) / 12500).ToString() + '%';
                
            }
        }   
        
        public int StorageUpdate()
        {
            return caliber25 + caliber30 + caliber50;
        }
    }
}
