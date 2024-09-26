using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;



public partial class searchfriends : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Page.IsPostBack))
        {

           
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void btnsearchname_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = new DataSet();
            string str = "select * from registeration where username like '%"+txtsearchname.Text+"%'";
            ds = dl.GetDataSet(str);
            int cnt = 0;
            int count = ds.Tables[0].Rows.Count;
            count = count * 3;
            int n = 0, l = 0, m = 0, k = 0;
            if (ds.Tables[0].Rows.Count >= 0)
            {


                for (int i = 0; i < count; i++)
                {

                    HtmlTableRow tRow = new HtmlTableRow();
                    tab.Rows.Add(tRow);

                    HtmlTableCell tCell = new HtmlTableCell();

                    if (k == 0)
                    {
                        tCell = new HtmlTableCell();
                        if (l < ds.Tables[0].Rows.Count)
                        {
                            //pnlDynamic.Controls.Add(interiorid);
                            ImageButton im = new ImageButton();
                            im.Width = 300;
                            im.Height = 175;
                            im.ID = "UserId" + cnt;
                            im.ImageUrl = "~\\photo\\" + ds.Tables[0].Rows[l]["Photo"].ToString();
                            im.PostBackUrl = "newpage.aspx?UserId=" + ds.Tables[0].Rows[l][0].ToString();

                            tCell.Controls.Add(im);
                            tRow.Cells.Add(tCell);
                            cnt++;
                            l = l + 1;
                        }
                        else
                        {
                            k = 1;
                        }

                        if (l < ds.Tables[0].Rows.Count)
                        {
                            tCell = new HtmlTableCell();


                            ImageButton im1 = new ImageButton();
                            im1.Width = 300;
                            im1.Height = 175;
                            im1.ID = "UserId" + cnt;
                            im1.ImageUrl = "~\\photo\\" + ds.Tables[0].Rows[l]["Photo"].ToString();
                            im1.PostBackUrl = "newpage.aspx?UserId=" + ds.Tables[0].Rows[l][0].ToString();

                            tCell.Controls.Add(im1);
                            tRow.Cells.Add(tCell);
                            cnt++;
                            l = l + 1;
                        }
                        else
                        {
                            k = 1;
                        }
                        if (l < ds.Tables[0].Rows.Count)
                        {
                            tCell = new HtmlTableCell();


                            ImageButton im2 = new ImageButton();
                            im2.Width = 250;
                            im2.Height = 175;
                            im2.ID = "UserId" + cnt;
                            im2.ImageUrl = "~\\photo\\" + ds.Tables[0].Rows[l]["Photo"].ToString();
                            im2.PostBackUrl = "newpage.aspx?UserId=" + ds.Tables[0].Rows[l][0].ToString();

                            tCell.Controls.Add(im2);
                            tRow.Cells.Add(tCell);
                            cnt++;
                            l = l + 1;
                            k = 1;
                        }
                        else
                        {
                            k = 1;
                        }
                    }

                    else if (k == 1)
                    {
                        HtmlTableRow trow2 = new HtmlTableRow();
                        tab.Rows.Add(trow2);
                        if (m < ds.Tables[0].Rows.Count)
                        {
                            tCell = new HtmlTableCell();
                            Label lbl1 = new Label();
                            lbl1.Width = 250;
                            lbl1.ID = "UserId" + cnt;
                            lbl1.Text = ds.Tables[0].Rows[m]["Name"].ToString();
                            tCell.Controls.Add(lbl1);
                            trow2.Cells.Add(tCell);
                            cnt++;

                            m = m + 1;
                        }
                        else
                        {
                            k = 2;
                        }

                        if (m < ds.Tables[0].Rows.Count)
                        {
                            tCell = new HtmlTableCell();
                            Label lbl2 = new Label();
                            lbl2.Width = 250;
                            lbl2.ID = "UserId" + cnt;
                            lbl2.Text = ds.Tables[0].Rows[m]["Name"].ToString();
                            tCell.Controls.Add(lbl2);
                            trow2.Cells.Add(tCell);
                            cnt++;
                            m = m + 1;
                        }
                        else
                        {
                            k = 2;
                        }
                        if (m < ds.Tables[0].Rows.Count)
                        {
                            tCell = new HtmlTableCell();
                            Label lbl3 = new Label();
                            lbl3.Width = 250;
                            lbl3.ID = "UserId" + cnt;
                            lbl3.Text = ds.Tables[0].Rows[m]["Name"].ToString();
                            tCell.Controls.Add(lbl3);
                            trow2.Cells.Add(tCell);

                            cnt++;
                            m = m + 1;

                            k = 2;
                        }
                        else
                        {
                            k = 2;
                        }
                    }
                    else if (k == 2)
                    {
                        HtmlTableRow trow3 = new HtmlTableRow();
                        tab.Rows.Add(trow3);
                        if (n < ds.Tables[0].Rows.Count)
                        {
                            tCell = new HtmlTableCell();
                            Label lbl4 = new Label();
                            lbl4.Width = 250;
                            lbl4.ID = "UserId" + cnt;
                            lbl4.Text = ds.Tables[0].Rows[n]["Gender"].ToString();
                            tCell.Controls.Add(lbl4);
                            trow3.Cells.Add(tCell);

                            cnt++;
                            n = n + 1;
                        }
                        else
                        {
                            k = 0;
                        }
                        if (n < ds.Tables[0].Rows.Count)
                        {
                            tCell = new HtmlTableCell();
                            Label lbl5 = new Label();
                            lbl5.Width = 250;
                            lbl5.ID = "UserId" + cnt;
                            lbl5.Text = ds.Tables[0].Rows[n]["Gender"].ToString();
                            tCell.Controls.Add(lbl5);
                            trow3.Cells.Add(tCell);

                            cnt++;
                            n = n + 1;
                        }
                        else
                        {
                            k = 0;
                        }
                        if (n < ds.Tables[0].Rows.Count)
                        {
                            tCell = new HtmlTableCell();
                            Label lbl6 = new Label();
                            lbl6.Width = 250;
                            lbl6.ID = "UserId" + cnt;
                            lbl6.Text = ds.Tables[0].Rows[n]["Gender"].ToString();
                            tCell.Controls.Add(lbl6);
                            trow3.Cells.Add(tCell);

                            cnt++;
                            n = n + 1;
                            k = 0;
                        }
                        else
                        {
                            k = 0;
                        }
                    }



                }
            }
        }



        catch (Exception ex)
        { }
    }
} 