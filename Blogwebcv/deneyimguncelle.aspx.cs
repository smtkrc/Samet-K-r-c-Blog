using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class deneyimguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {


                int x = Convert.ToInt16(Request.QueryString["ID"]);
                txtıd.Text = x.ToString();
                txtıd.Enabled = false;
                DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
                txtbaslık.Text = dt.secılendeneyımgetır(Convert.ToInt16(x))[0].BASLIK;
                txtaltbaslık.Text = dt.secılendeneyımgetır(Convert.ToInt16(x))[0].ALTBASLIK;
                Txtacıklama.Text = dt.secılendeneyımgetır(Convert.ToInt16(x))[0].ACIKLAMA;
                txttarıh.Text = dt.secılendeneyımgetır(Convert.ToInt16(x))[0].TARIH;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            dt.deneyimguncelle(txtbaslık.Text, txtaltbaslık.Text, Txtacıklama.Text, txttarıh.Text,Convert.ToInt16(txtıd.Text));
            Response.Redirect("AdminDeneyimler.aspx");


        }
    }
}