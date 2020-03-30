using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POWebApp
{
    public partial class Add_PO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void btnSavePO_Click(object sender, EventArgs e)
        {
            POClassLibrary.StandardPO newPO = new POClassLibrary.StandardPO(txtTitle.Text);

            if (newPO.Save())
            {
                lblStatus.Text = "Your PO is saved!";

            } else
            {
                lblStatus.Text = "Error saving PO";
            }

        }
    }
}