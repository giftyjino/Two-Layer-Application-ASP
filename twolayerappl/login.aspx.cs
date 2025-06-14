using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace twolayerappl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Connectionclass objcls = new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select count(id) from twolayer where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            string cid = objcls.Fn_scalar(s);
            if (cid == "1")
            {
                string gid = "select id from twolayer where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string j = objcls.Fn_scalar(gid);
                Session["uid"] = j;
                Response.Redirect("userprofile.aspx");
            }
            else
            {
                Label1.Text = "invalid usernmae and password";
            }
        }
    }
}