using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogwebcv
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.hakkımdalistele();
            Repeater1.DataBind();
            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt2 = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            Repeater2.DataSource = dt2.deneyımgetır();
            Repeater2.DataBind();
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt3 = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dt3.egıtımlıstele();
            Repeater3.DataBind();
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt4 = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            Repeater4.DataSource = dt4.yeteneklıstele();
            Repeater4.DataBind();
            DataSet1TableAdapters.TBLHOBITableAdapter dt5 = new DataSet1TableAdapters.TBLHOBITableAdapter();
            Repeater5.DataSource = dt5.hobılerılıstele();
            Repeater5.DataBind();
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt6 = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            Repeater6.DataSource = dt6.sertıfıkalıstesı();
            Repeater6.DataBind();
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt7 = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater7.DataSource = dt7.hakkımdalistele();
            Repeater7.DataBind();








        }
    }
}