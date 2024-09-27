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
    public partial class profileview : System.Web.UI.Page
    {
        Connection_class conobj = new Connection_class();

        protected void Page_Load(object sender, EventArgs e)
        {
           string str= "select Name, Age,Address,Photo from t3 where Id= "+Session["uid"]+"";

            SqlDataReader dr = conobj.reader_fun(str);
            while (dr.Read())
            {
                TextBox1.Text = dr["Name"].ToString();
                TextBox2.Text = dr["Age"].ToString();

                TextBox3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();

            }

            DataSet ds = conobj.dataset_fun(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = conobj.datatable_fun(str);
            DataList1.DataSource = dt;
            DataList1.DataBind();

        }
    }
}