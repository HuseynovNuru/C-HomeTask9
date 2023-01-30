using System;
using System.Collections.Generic;
using System.Text;

namespace CHomeTask9
{
    internal class Drink:Product
    {
        private double _alcoholercent;
        public double Alcoholpercent
        {
            set
            {
                if (value >= 0 && value<= 100)
                {
                    _alcoholercent = value;
                }
            }
            get
            {
                return _alcoholercent;
            }
        }
    }
}
