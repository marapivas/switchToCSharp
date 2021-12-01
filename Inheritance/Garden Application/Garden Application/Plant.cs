using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    internal class Plant
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private double waterAmount;
        public double WaterAmount
        {
            get { return waterAmount; }
            set { waterAmount = value; }
        }

        public Plant(string color)
        {
            this.color = color;
            this.waterAmount = 0;
        }
    }
}
