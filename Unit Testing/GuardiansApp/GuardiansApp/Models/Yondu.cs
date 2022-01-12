using System;

namespace GuardiansApp.Models
{
    public class Yondu
    {
        public double distance { get; set; }
        public double time { get; set; }
        public double speed { get; set; }

        public Yondu(double distance, double time)
        {
            this.distance = distance;
            this.time = time;
            speed = distance / time;

        }

        public Yondu()
        {
        }
    }

}
