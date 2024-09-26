using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ViewText : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();

    DataTable dtable = new DataTable();
    

    public void gridfill()
    {
        String str="select text_linking.linkingid,text_linking.fromusername, text_linking.tousername,textdata.textcontent from text_linking,textdata where text_linking.textdataid=textdata.textdataid and text_linking.tousername='"+Session["uname"].ToString()+"'";
         DataSet ds = new DataSet();
        ds = dl.GetDataSet(str);


        if (ds.Tables[0].Rows.Count > 0)
        {
          
            GridView1.DataSource = ds;
            GridView1.DataMember = "table";
            GridView1.DataBind();
        }
  
    }

    protected void Page_Load(object sender, EventArgs e)
    {
          if (!(Page.IsPostBack))
          {
              gridfill();
          }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataLayer d1 = new DataLayer();
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox chk = (CheckBox)GridView1.Rows[i].FindControl("chkmail");

            if (chk.Checked)
            {
                Label lbl = (Label)GridView1.Rows[i].FindControl("lblId");

                string qstr;


                  qstr = "select * from text_linking where linkingid='" + lbl.Text  + "'";
            DataSet dsr = dl.GetDataSet(qstr);
            if (dsr.Tables[0].Rows.Count > 0)
            {
                String textdataid = dsr.Tables[0].Rows[0]["textdataid"].ToString();
                  String fromuser = dsr.Tables[0].Rows[0]["fromusername"].ToString();

                  qstr = "select * from text_linking where textdataid='" + textdataid + "'";
            DataSet ds = dl.GetDataSet(qstr);
            if (ds.Tables[0].Rows.Count > 0)
            {
               
                qstr = "delete from text_linking where textdataid ='" + textdataid + "' and fromusername='"+fromuser+"'";
                d1.DmlCmd(qstr);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    qstr = "delete from textdata where textdataid ='" + textdataid + "'";
                    d1.DmlCmd(qstr);
                    gridfill();
                }
                  gridfill();

                //  Response.Write("<script language='javascript'>alert('Record Deleted...')</script>");
               
            }

           
            }


            gridfill();

            }
        }
    }
}