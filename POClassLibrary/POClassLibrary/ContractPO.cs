using System;
using System.Collections.Generic;
using System.Text;

namespace POClassLibrary
{
    class ContractPO : PurchaseOrder
    {
        public double contractRate;
        public double contractTotal;
        public UOM UOM;
        public ContractPO(string title) : base(title)
        {

        }
    }
}
