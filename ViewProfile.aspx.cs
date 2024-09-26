using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ViewProfile : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();
        }
    }
    public static string id = "";
    public void fillgrid()
    {
        string str = "select * from registeration ";
        DataSet ds = new DataSet();
        ds = dl.GetDataSet(str);
        GridView1.DataSource = ds;
        GridView1.DataMember = "table";
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowIndex = Convert.ToInt32(e.CommandArgument);
        GridViewRow row = GridView1.Rows[rowIndex];
        Label lblid = (Label)row.FindControl("lblID");
        id = lblid.Text;
        txtName.Text = GridView1.Rows[rowIndex].Cells[1].Text;
        txtEmail.Text = GridView1.Rows[rowIndex].Cells[2].Text;
        txtMobile.Text = GridView1.Rows[rowIndex].Cells[3].Text;
        txtDob.Text = GridView1.Rows[rowIndex].Cells[4].Text;
        txtGender.Text = GridView1.Rows[rowIndex].Cells[5].Text;
        txtAge.Text = GridView1.Rows[rowIndex].Cells[6].Text;
        txtAddres.Text = GridView1.Rows[rowIndex].Cells[7].Text;
        txtUsername.Text = GridView1.Rows[rowIndex].Cells[8].Text;
    }
    protected void BtnDelete_Click(object sender, EventArgs e)
    {

        String str = "delete from registeration where UserId='" + id + "'";
        dl.DmlCmd(str);
        string st1 = "delete from user_creation where Username='" + txtUsername.Text + "'";
        dl.DmlCmd(st1);
        fillgrid();
        txtName.Text = "";
        txtEmail.Text = "";
        txtEmail.Text = "";
        txtMobile.Text ="";
        txtDob.Text ="";
        txtGender.Text ="";
        txtAge.Text = "";
        txtAddres.Text ="";
    }
}