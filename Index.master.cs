using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Drawing;

public partial class Index : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("school.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("college.aspx");
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("university.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // StringBuilder sb = new StringBuilder();
        string msg = "Message Successfully Sending";
       // string msg2 = "Email or Password Already Used";
    
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Usermessage values('" + txtphone.Text + "','" + txtemail.Text + "','" + txtmsg.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            lblmsg.Text = msg.ToString();
            con.Close();
        
     
    }
}
