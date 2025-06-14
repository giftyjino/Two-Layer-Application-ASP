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
    public partial class userprofile : System.Web.UI.Page
    {
        Connectionclass objcls = new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select name,age,address,photo from twolayer where id=" + Session["uid"] + "";
            SqlDataReader dr = objcls.fn_sqlreader(sel);
            while(dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }
            DataSet ds = objcls.fn_exAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            DataTable dt = objcls.fn_exdatatable(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();
            
            


        }

      

    }
}