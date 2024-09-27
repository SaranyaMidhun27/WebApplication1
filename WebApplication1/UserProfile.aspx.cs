using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Connection_class conobj = new Connection_class();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string strInsert="insert into t3 values('"+TextBox1.Text+"',"+ TextBox2.Text + ",'"+ TextBox3.Text + "','"+path+"','"+ TextBox4.Text + "','"+ TextBox5.Text + "')";

            int i = conobj.nonQuery_fun(strInsert);
            if (i == 1)
            {
                Label1.Text = "inserted";
            }
        }
    }
}