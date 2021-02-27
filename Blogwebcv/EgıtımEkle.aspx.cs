using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class EgıtımEkle : System.Web.UI.Page
    {
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.egıtımekle(txtbaslık.Text, txtaltbaslık.Text, txtacıklama.Text, txtgnot.Text, txttarıh.Text);
            Response.Redirect("adminegitimler.aspx");

        }
    }
}