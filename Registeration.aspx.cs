using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Registeration : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
     

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
    
    }
    protected void txtufname_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnusave_Click(object sender, EventArgs e)
    {

        string str = "select * from registeration  where username='" + txtuusername.Text + "'";
        DataSet ds = new DataSet();
        ds = dl.GetDataSet(str);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Response.Write("<script language='javascript'>alert('username already exist')</script>");
        }
        else
        {


            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("photo//" + FileUpload1.FileName));
            }
             str = "insert into registeration (Password, Name, Email, Mobile, Dob, Gender, Age, Address, Photo, Username)values('" + txtupassword.Text + "','" + txtufname.Text + "','" + txtuemail.Text + "','" + txtumobile.Text + "','" + txtudob.Text + "','" + rbgender.SelectedItem.Text + "','" + txtuage.Text + "','" + txtuaddress.Text + "','" + FileUpload1.FileName + "','" + txtuusername.Text + "')";
            dl.DmlCmd(str);
            DateTime dt = DateTime.Now;
            String str1 = "insert into user_creation (Username, Password, User_type, Email, DateCreated) values ('" + txtuusername.Text + "','" + txtupassword.Text + "','User','" + txtuemail.Text + "','" + dt.ToString("yyyy-MM-dd") + "')";
            dl.DmlCmd(str1);

            Response.Write("<script language='javascript'>alert('Registered succesfully')</script>");
        }
    }

    protected void btnuclr_Click(object sender, EventArgs e)
    {

    }
}