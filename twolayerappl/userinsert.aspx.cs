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
    public partial class userinsert : System.Web.UI.Page
    {
        Connectionclass objcls = new Connectionclass();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string strinsert="insert into twolayer values('"+TextBox1.Text+"',"+TextBox2.Text+",'"+TextBox3.Text+"','"+ p +"','"+ TextBox4.Text+"','"+TextBox5.Text+"')";
                int i = objcls.Fn_Nonquery(strinsert);
            if(i==1)
            {
                Label1.Text = "inserted";
            }
        }
    }
}