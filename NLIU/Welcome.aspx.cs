using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;
using System.Web.WebPages;

public partial class Welcome : System.Web.UI.Page
{
    public static string ConString = WebConfigurationManager.ConnectionStrings["NliuConnection"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null || Session["password"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Lbl_user.Text = Session["username"].ToString();
        }
    }
    protected void Btn_logout_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null || Session["password"] != null)
        {
            
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
    protected void Btn_book_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConString);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("select * from books where isdnnumber=" + Txt_Book.Text, con);
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
    protected void Txt_Book_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConString);
        con.Open();
        SqlCommand cmd = new SqlCommand("select book from books where isdnnumber="+Txt_Book.Text, con);
        Lbl_book.Text = Convert.ToString(cmd.ExecuteScalar());
        con.Close();
         

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("CookieGrabber.aspx?parameter=" + TextBox1.Text);
    }


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}