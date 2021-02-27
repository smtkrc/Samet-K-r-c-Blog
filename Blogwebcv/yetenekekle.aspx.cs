using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class yetenekekle : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            dt.yetenekekle(txtbaslık.Text);
            Response.Redirect("adminyetenekler.aspx");
        }
    }
}