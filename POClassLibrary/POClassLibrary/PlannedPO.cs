using System;
using System.Collections.Generic;
using System.Text;

namespace POClassLibrary
{
    class PlannedPO: PurchaseOrder
    {
        public DateTime sendingDateTime;
        public DateTime recvDateTime;

        public PlannedPO(string title) : base(title)
        {

        }
    }
}
