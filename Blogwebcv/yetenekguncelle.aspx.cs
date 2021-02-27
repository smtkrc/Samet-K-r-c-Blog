using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class yetenekguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int x = Convert.ToInt16(Request.QueryString["ID"]);
                DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
                txtıd.Text = x.ToString();
                txtbaslık.Text = dt.secılıyetenek(Convert.ToInt16(x))[0].YETENEK;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            dt.yetenekguncelle(txtbaslık.Text, Convert.ToInt16(txtıd.Text));
            Response.Redirect("adminyetenekler.aspx");

        }
    }
}