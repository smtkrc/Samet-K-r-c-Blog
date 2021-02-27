using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class adminegitimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater1.DataSource = dt.egıtımlıstele();
            Repeater1.DataBind();

        }
    }
}