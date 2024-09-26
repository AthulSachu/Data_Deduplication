using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Threading;

public partial class Delete : System.Web.UI.Page
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
            String id = lnk.CommandArgument;
            String str = "";
            str = "select * from file_details where file_details_id='" + id + "'";
            DataSet dsr = dl.GetDataSet(str);
            if (dsr.Tables[0].Rows.Count>0)
            {

                str = "select count(keygen)as a from file_details where keyGen='" + dsr.Tables[0].Rows[0]["keyGen"].ToString() + "'";
                DataSet dsc =dl.GetDataSet(str);
                if (int.Parse(dsc.Tables[0].Rows[0]["a"].ToString()) > 1)
                {
                    str = "delete from file_details where file_details_id='" + id + "'";
                    dl.DmlCmd(str);
                    str = "delete from file_link where file_id='" + id + "'";
                    dl.DmlCmd(str);
                    Response.Redirect("Delete.aspx");
                }
                else
                {
                    String g = "Select * from file_link where file_id='" + id + "'";
                    DataSet fileid = dl.GetDataSet(g);
                    string fl = fileid.Tables[0].Rows[0]["filelink"].ToString();
                    string f2 = fileid.Tables[0].Rows[0]["type"].ToString();
    
                     
                    //FileStream dnf = new FileStream(Server.MapPath("files/" + fl), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    //dnf.Close();
                    //dnf.Dispose();
                    
                    string processName = "WebDev.WebServer40.exe";
                    Process[] processes = Process.GetProcessesByName(processName);
                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }
                    str = "delete from file_details where file_details_id='" + id + "'";
                    dl.DmlCmd(str);
                    str = "delete from file_link where file_id='" + id + "'";
                    dl.DmlCmd(str);
                   if(String.Equals(f2,".jpg")||String.Equals(f2,".png"))
                   {

                    if (File.Exists(Server.MapPath("files/" + fl)))
                    {
                        File.Delete(Server.MapPath("files/" + fl));
                    }
                    Response.Redirect("Delete.aspx");
                   }
                   else
                   {
                       if (File.Exists(Server.MapPath("tempfiles/" + fl)))
                       {
                           File.Delete(Server.MapPath("tempfiles/" + fl));
                       }
                       Response.Redirect("Delete.aspx");
                   }
                }
            }
            
        }
    }
}