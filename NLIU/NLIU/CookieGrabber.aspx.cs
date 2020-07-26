using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO; 
using System.Web.UI.WebControls;

public partial class CookieGrabber : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
  
    protected void Button1_Click1(object sender, EventArgs e)
    {
        //string cookie = Request.QueryString["parameter"];
        //string path = @"G:\";
        //DirectoryInfo di = new DirectoryInfo(path + @"\MyApplicationData");
        //if (di.Exists)
        //{

        //    Response.Write("Folder already exists");
        //}
        //else
        //{
        //    di.Create();
        //}
        //FileInfo Fi = new FileInfo(path + @"\MyApplicationData\Cookies.txt");
        //if (Fi.Exists)
        //{
        //    Response.Write("File already exists");
        //}
        //else
        //{
        //    Fi.Create();
        //}
        //StreamWriter Sw = new StreamWriter(@"G:\MyApplicationData\Cookies.txt");
        //Sw.WriteLine(cookie);
        //Sw.Close();
        //StreamReader Sr = new StreamReader(@"H:\MyApplicationData\Sub1\Mydata.txt");
        //string ReadData = Sr.ReadToEnd();
        //Sr.Close();
        //Console.WriteLine("Data From File is:-");
        //Console.WriteLine(ReadData);
        //Console.Read();
        string cookie;
        ////cookie = Session.SessionID;
        cookie = Request.QueryString["parameter"].ToString();
        Response.Write(cookie);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null || Session["password"] != null)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}