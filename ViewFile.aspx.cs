using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ViewFile : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            String str = "select * from file_details where tousername='" + Session["uname"].ToString() + "'";
            DataSet ds = dl.GetDataSet(str);
            DataTable dt = ds.Tables[0];
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "view")
        {
            LinkButton lnk = (LinkButton)e.CommandSource;
            String keygen = lnk.CommandArgument;
            String str = "select * from file_link where keyGen='" + keygen + "'";
            DataSet ds = dl.GetDataSet(str);

            string type = ds.Tables[0].Rows[0]["type"].ToString();
            if (String.Equals(type, ".jpg") || String.Equals(type, ".png"))
            {
                String file = "files/" + ds.Tables[0].Rows[0]["filelink"].ToString();
                Response.Redirect(file);
            }
            else
            {
                String file = "tempfiles/" + ds.Tables[0].Rows[0]["filelink"].ToString();
                Response.Redirect(file);
            }
        }
    }
}