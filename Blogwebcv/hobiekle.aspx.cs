using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class hobiekle : System.Web.UI.Page
    {
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBITableAdapter dt = new DataSet1TableAdapters.TBLHOBITableAdapter();
            dt.hobiekle(txtbaslık.Text);
            Response.Redirect("adminhobiler.aspx");
        }
    }
}