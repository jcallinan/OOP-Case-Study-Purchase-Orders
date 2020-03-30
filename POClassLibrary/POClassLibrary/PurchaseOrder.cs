using System;
using System.Collections.Generic;
using System.Text;

namespace POClassLibrary
{
    public class PurchaseOrder
    {
        string title;
        double grandTotal;
        double taxTotal;
        double freightTotal;
        LineItem[] LineItems;
        public string[] InvoiceNumber;

        public PurchaseOrder(string title)
        {

        }
    }
}
