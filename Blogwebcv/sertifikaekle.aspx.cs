using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class sertifikaekle : System.Web.UI.Page
    {
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.sertifikaekle(txtodul.Text);
            Response.Redirect("adminsertifikalar.aspx");
        }
    }
}