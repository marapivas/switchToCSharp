namespace GuardiansApp.Models
{
    public class ShipCargoResponse
    {
        public int caliber25 { get; set; }
        public int caliber30 { get; set; }
        public int caliber50 { get; set; }
        public string shipstatus { get; set; }
        public bool ready { get; set; }

        public ShipCargoResponse(Ship ship)
        {
            caliber25 = ship.caliber25;
            caliber30 = ship.caliber30;
            caliber50 = ship.caliber50;
            shipstatus = ship.shipstatus;
            ready = ship.ready;
        }
    }
}
