using System;
using System.Collections.Generic;
using System.Text;

namespace POClassLibrary
{
    public class ContractPO : PurchaseOrder
    {
        public double contractRate;
        public double contractTotal;
         UOM UOM;
        public ContractPO(string title) : base(title)
        {

        }
    }
}
