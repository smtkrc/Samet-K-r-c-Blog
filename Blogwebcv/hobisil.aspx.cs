using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class hobisil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLHOBITableAdapter dt = new DataSet1TableAdapters.TBLHOBITableAdapter();
            dt.hobisil(Convert.ToInt16(x));
            Response.Redirect("adminhobiler.aspx");


        }
    }
}