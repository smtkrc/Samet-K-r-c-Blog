using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class egitimguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                int x = Convert.ToInt16(Request.QueryString["ID"]);
                txtıd.Text = x.ToString();
                DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                txtbaslık.Text = dt.secılıegıtımgetır(Convert.ToInt16(x))[0].BASLIK;
                txtaltbaslık.Text = dt.secılıegıtımgetır(Convert.ToInt16(x))[0].ALTBASLIK;
                Txtacıklama.Text = dt.secılıegıtımgetır(Convert.ToInt16(x))[0].ACIKLAMA;
                txtgnot.Text = dt.secılıegıtımgetır(Convert.ToInt16(x))[0].GNOT;
                txttarıh.Text = dt.secılıegıtımgetır(Convert.ToInt16(x))[0].TARIH;
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.egıtımguncelle(txtbaslık.Text, txtaltbaslık.Text, Txtacıklama.Text, txtgnot.Text, txttarıh.Text,Convert.ToInt16(txtıd.Text));
            Response.Redirect("adminegitimler.aspx");

        }
    }
}