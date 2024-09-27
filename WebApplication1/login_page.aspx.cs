using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Connection_class conobj = new Connection_class();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //----------------------- Login-----------------------------------------------------------
            /*string s = "select count(Id) from t3 where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = conobj.scalar_fun(s);
            if (cid == "1")
            {
                Response.Redirect("UserProfile.aspx");
            }
            else
            {
                Label1.Text = "invalid login user";
            }*/

            // ---------------------------------------------------loginend-----------------------------

            //------------------------ view profile after login-----------------------------------------

            string s = "select count(Id) from t3 where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = conobj.scalar_fun(s);
            if (cid == "1")
            {
                int id1 = 0;
                string str = "select Id from t3 where Username='"+TextBox1.Text+ "' and  Password='"+ TextBox2.Text + "'";
                SqlDataReader dr = conobj.reader_fun(str);
                while (dr.Read())
                {
                    id1 = Convert.ToInt32(dr["Id"].ToString());
                }
                Session["uid"] = id1;
                Response.Redirect("profileview.aspx");
            }
        }
    }
}