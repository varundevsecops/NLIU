using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    public static string ConString = WebConfigurationManager.ConnectionStrings["NliuConnection"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        SqlConnection con = new SqlConnection(ConString);
        SqlDataAdapter da= new SqlDataAdapter("select username,password,id from logininfo where username='"+ TextBox1.Text+"'and password='"+TextBox2.Text+"'",con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Session["username"] = TextBox1.Text;
            Session["password"] = TextBox2.Text;
            
            Response.Redirect("Welcome.aspx");
            
        }
        else
        {
            Session.RemoveAll();
            Lbl_msg.Text = "Incorrect username or password";
            
        }
    }
}