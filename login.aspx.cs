using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class login : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtpassword_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string str = "select * from user_creation  where username='" + txtusername.Text + "'";
        DataSet ds = new DataSet();
        ds = dl.GetDataSet(str);
        if (ds.Tables[0].Rows.Count > 0)
        {
            str = "select * from user_creation  where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";

     DataSet dsp = new DataSet();
            dsp = dl.GetDataSet(str);
            if (dsp.Tables[0].Rows.Count > 0)
            {
                Session["uname"] = txtusername.Text;
                if (dsp.Tables[0].Rows[0]["User_type"].ToString() == "Admin")
                {
                    Response.Redirect("ViewProfile.aspx");
                }
                else
                {
                    Response.Redirect("searchfriends.aspx");
                }
               // Response.Redirect("FILE_DETAILS.aspx");
               Response.Redirect("Changepassword.aspx");
            }
            else
            {
                Response.Write("<script language='javascript'>alert('Invalid Password...')</script>");
            }
               
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Invalid User...')</script>");

        }
    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtpassword.Text = "";
        txtusername.Text = "";

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registeration.aspx");
    }
}