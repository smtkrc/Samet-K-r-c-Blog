using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Blogwebcv
{

    public partial class girisyap : System.Web.UI.Page
    {
        SqlConnection BAGLANTI = new SqlConnection(@"Data Source=DESKTOP-5OBCDS9\SQLEXPRESS;Initial Catalog=DBBLOGWEB;Integrated Security=True");
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            BAGLANTI.Open();
            SqlCommand KOMUT = new SqlCommand("Select * From TBLADMIN where KULLANICI=@P1 and SIFRE=@P2", BAGLANTI);
            KOMUT.Parameters.AddWithValue("@P1", TextBox1.Text);
            KOMUT.Parameters.AddWithValue("@P2", TextBox2.Text);
            SqlDataReader dr = KOMUT.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("AdminDeneyimler.aspx");

            }
            else
            {
                Response.Write("Hatalı Kullanıcı adı yada şifre");
            }
            BAGLANTI.Close();
        }
    }
}