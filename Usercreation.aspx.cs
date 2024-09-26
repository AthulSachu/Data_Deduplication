using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Usercreation : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnregsave_Click(object sender, EventArgs e)
    {
        String str ="insert into user_creation(Username, Password, User_type, Email)values('"+txtregusername.Text+"','"+txtregpassword.Text+"','"+ddlutype.SelectedItem.Text+"','"+txtemail.Text+"')";
        dl.DmlCmd(str);
    }
}