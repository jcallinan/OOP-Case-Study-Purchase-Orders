using System;
using System.Collections.Generic;
using System.Text;

namespace POClassLibrary
{
    public class StandardPO : PurchaseOrder
    {
        public StandardPO(string title) : base(title)
        {

        }
        public bool Save()
        {
            return true;
        }
    }
}
