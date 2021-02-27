using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class sertifikaguncelle : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();

            if (Page.IsPostBack == false)
            {

                int x = Convert.ToInt16(Request.QueryString["ID"]);
                txtıd.Text = x.ToString();
                txtıd.Enabled = false;
                txtbaslık.Text = dt.secılısertıfıkalar(Convert.ToInt16(x))[0].ODUL;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.sertifikaguncelle(txtbaslık.Text, Convert.ToInt16(txtıd.Text));
            Response.Redirect("adminsertifikalar.aspx");

        }
    }
}