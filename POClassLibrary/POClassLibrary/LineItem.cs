using System;
using System.Collections.Generic;
using System.Text;

namespace POClassLibrary
{
    enum UOM
    {
        LB,
        GAL,
        CASE,
        LITER
    }
    class LineItem
    {
        public double itemAmount;
        public UOM UOM;
        public string title;
        public string partNumber;
        public string vendorPartNumber;
        public string inventoryNumber;
        public double quantity;


    }
}
