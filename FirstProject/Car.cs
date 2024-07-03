using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Car
    {

        private string Color
        { get; set; }

        private string Brand { get; set; }

        public Car(string color , string brand)
        {
            this.Color = color;
            this.Brand = brand;
        }
    }
}
