using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class yeteneksil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ıd = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            dt.yeteneksıl(Convert.ToInt16(ıd));
            Response.Redirect("adminyetenekler.aspx");

        }
    }
}