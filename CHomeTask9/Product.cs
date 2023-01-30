using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CHomeTask9
{
    internal class Product
    {

        private double _price;
        private string _name;
        
        public string Name
        {
            set
            {
                if (value.Length>1 && value.Length < 21)
                {
                    _name = value;
                }
            }
            get
            {
                return _name;
            }
        }
        

        

        public double Price
        {
            set
            {
                if (value >= 0)
                    _price= value;
            }
            get
            {
                return _price;
            }
        }

    }
}
