using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class hobiguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {


                int x = Convert.ToInt16(Request.QueryString["ID"]);
                txtıd.Text = x.ToString();
                txtıd.Enabled = false;
                DataSet1TableAdapters.TBLHOBITableAdapter dt = new DataSet1TableAdapters.TBLHOBITableAdapter();
                txthobi.Text = dt.secilihobilistele(Convert.ToInt16(x))[0].HOBI;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBITableAdapter dt = new DataSet1TableAdapters.TBLHOBITableAdapter();
            dt.hobiguncelle(txthobi.Text, Convert.ToInt16(txtıd.Text));
            Response.Redirect("adminhobiler.aspx");

        }
    }
}