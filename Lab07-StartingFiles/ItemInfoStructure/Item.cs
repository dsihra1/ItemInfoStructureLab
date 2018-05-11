using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemInfoStructure
{
    public struct Item
    {

        public const string StoreName = "df";

        private int number;

        private double price;

        private string description;

        public int ItemNumber
        {
            get { return number; }

            set
            {
                number = value;

            }
        }
        public double ItemPrice
        {
            get { return price; }

            set
            {
                   price = value;
            }
        }

        public string ItemDescription
        {
            get { return description; }

            set
            {
                    description = value;
            }
           
           
        }

    }
}
