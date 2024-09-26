using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Threading;

public partial class newpage : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            String id = Request.QueryString["UserId"].ToString();
            String username = null;
            String str = "select * from registeration where userid=" + id + "";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblname.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                username = ds.Tables[0].Rows[0]["UserName"].ToString();
                lbluname.Text = Session["uname"].ToString();


            }
        }
    }
    protected void btnsend_Click(object sender, EventArgs e)
    {
        /*  String str1 = "select * from TextData where tousername='" + lblname.Text + "' and textcontent='" + txtmessage.Text + "' order by textdataid desc";
          DataSet ds = new DataSet();
          ds = dl.GetDataSet(str1);
          if (ds.Tables[0].Rows.Count > 0)
          {
              String str = "insert into text_linking(fromusername, tousername, textdataid)values('" + lbluname.Text + "','" + lblname.Text + "','" + ds.Tables[0].Rows[0]["textdataid"].ToString() + "')";
              dl.DmlCmd(str);
           
          }
          else
          {

              String str = "insert into TextData(fromusername, tousername, textcontent)values('" + lbluname.Text + "','" + lblname.Text + "','" + txtmessage.Text + "')";
              dl.DmlCmd(str);
              String str2 = "select * from TextData where tousername='" + lblname.Text + "' and textcontent='" + txtmessage.Text + "' order by textdataid desc";
          DataSet ds1 = new DataSet();
          ds1 = dl.GetDataSet(str2);
          if (ds1.Tables[0].Rows.Count > 0)
          {
              str = "insert into text_linking(fromusername, tousername, textdataid)values('" + lbluname.Text + "','" + lblname.Text + "','" + ds1.Tables[0].Rows[0]["textdataid"].ToString() + "')";
              dl.DmlCmd(str);
          }
          }*/
      /*  int count = 0;
        String str = "select * from textdata";
        //int[,] a=new int[10,10];
        DataSet ds = new DataSet();
        ds = dl.GetDataSet(str);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
            {
                String val = ds.Tables[0].Rows[k]["textcontent"].ToString();
                char[] dbtext=val.ToCharArray();
                char[] inputText=txtmessage.Text.ToCharArray();
                int[,] a = new int[txtmessage.Text.Length, val.Length];
                //a[,]=new int[txtmessage.Text.Length, val.Length];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    for (int j = 0; j < txtmessage.Text.Length; j++)
                    {
                        a[i,j] = 0;
                    }
                }
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 1; j < txtmessage.Text.Length; j++)
                    {
                        if (dbtext[i] == inputText[j])
                        {
                            count = count + 1;
                        }
                    }
                }
            }
        }*/
        int s = 1, n = 0, count = 0, flag;
         String str = "select * from textdata where textcontent='"+ txtmessage.Text  +"'";
        //int[,] a=new int[10,10];
        DataSet ds = new DataSet();
        ds = dl.GetDataSet(str);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
            {
                n = 0;
                count = 0;
                s = 1;
                flag = 0;
                String val = ds.Tables[0].Rows[k]["textcontent"].ToString();
                char[] dbtext = val.ToCharArray();
                char[] inputText = txtmessage.Text.ToCharArray();
                String[,] a = new String[txtmessage.Text.Length + 1, val.Length + 1];
                int[,] pos = new int[txtmessage.Text.Length + 1, val.Length + 1];
                a[0, 0] = "0";
                //a[,]=new int[txtmessage.Text.Length, val.Length];
                for (int i = 0; i < txtmessage.Text.Length; i++)
                {
                    if (flag == 0)
                    {
                        for (int j = 0; j < val.Length; j++)
                        {

                            a[i, s] = dbtext[j].ToString();
                            s = s + 1;
                        }
                        flag = 1;
                    }
                    a[i + 1, n] = inputText[i].ToString();
                }
                //for (int i = 1; i < val.Length; i++)
                //{
                //    for (int j = 1; j < txtmessage.Text.Length; j++)
                //    {
                //        if (inputText[i - 1] == dbtext[j - 1])
                //        {
                //            count = count + 1;
                //        }
                //    }
                //}
                int l = 1;
                for (int i = 1; i <= txtmessage.Text.Length; i++)
                {
                    for (int j = 1; j <= val.Length; j++)
                    {
                        if (a[i, 0] == a[0, j])
                        {
                            count = count + 1;
                            a[i, j] = count.ToString();
                            pos[i, j] = count;

                            try
                            {
                                if (pos[i - 1, j - 1] > 0)
                                {
                                    int val1 = int.Parse(a[i - 1, j - 1]) + 1;
                                    a[i, j] = val1.ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                            }





                            /* count = count + 1;
                             a[i, j] = count.ToString();*/
                            //int Q = int.Parse(a[i-1,j-1]);
                            //Q = Q + 1;
                            //a[i, j] = Q.ToString();
                        }
                        else
                        {
                            a[i, j] = "0";
                        }
                        count = 0;
                    }
                    l = l + 1;
                }


                for (int i = 1; i <= txtmessage.Text.Length; i++)
                {
                    for (int j = 1; j <= val.Length; j++)
                    {
                        Response.Write(a[i, j]);
                    }
                    Response.Write("\n");
                }


                int aa = dbtext.Length;
                int bb = inputText.Length;
                int P = int.Parse(a[inputText.Length, dbtext.Length]);
                int calc = (100 * P) / txtmessage.Text.Length;
                if (calc == 100)
                {
                    str = "insert into text_linking(fromusername, tousername, textdataid)values('" + lbluname.Text + "','" + lblname.Text + "','" + ds.Tables[0].Rows[k]["textdataid"].ToString() + "')";
                    dl.DmlCmd(str);
                    Label1.Text = "Match Found";
                    break;
                }
                else
                {
                    //str = "insert into TextData(fromusername, tousername, textcontent)values('" + lbluname.Text + "','" + lblname.Text + "','" + txtmessage.Text + "')";
                    //dl.DmlCmd(str);
                    //Label1.Text = "Percentage match " + calc.ToString();
                    Label1.Text = "Match Not Found";
                }
            }
        }
        else
        {
            str = "insert into TextData(fromusername, tousername, textcontent)values('" + lbluname.Text + "','" + lblname.Text + "','" + txtmessage.Text + "')";
            dl.DmlCmd(str);
            Response.Write("<script language='javascript'>alert('Message Sent')</script>");
        }
    }
    protected void txtmessage_TextChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Text == "Text")
        {
            p1.Visible = true;
            p2.Visible = false;
        }
        else
        {
            p1.Visible = false;
            p2.Visible = true;
        }
    }
    protected void btnPanelUpload_Click(object sender, EventArgs e)
    {
        if (Path.GetExtension(FileUpload1.FileName) == ".jpg" || Path.GetExtension(FileUpload1.FileName) == ".png")
        {
            Random rn = new Random();
            String n = rn.NextDouble().ToString();
            n = n.Substring(2, 3);
            String userphoto1 = "";
            int result = 0;
            int dupstatus = 0;
            String link = "";
            String id = "";
            string filelink = "";
            Panel1.Visible = true;
            if (FileUpload1.HasFile)
            {
                userphoto1 = n + FileUpload1.FileName;
                lblfileName.Text = FileUpload1.FileName;
                lblfileSize.Text = Math.Round(((decimal)FileUpload1.PostedFile.ContentLength / (decimal)1024), 2).ToString();
                lblfileType.Text = Path.GetExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("files/" + userphoto1));
            }


            // String ph = Server.MapPath("files/" + lblfileName.Text);
            FileStream inf = new FileStream(Server.MapPath("files/" + userphoto1), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            List<bool> iHash1 = GetHash(new Bitmap(inf));
            string checkDup = "select * from file_link where type='.jpg' or type ='.png'";
            DataSet dsCheckDup = dl.GetDataSet(checkDup);
            if (dsCheckDup.Tables[0].Rows.Count > 0)
            {
                for (int k = 0; k < dsCheckDup.Tables[0].Rows.Count; k++)
                {
                    //  String path = Server.MapPath("files/" + dsCheckDup.Tables[0].Rows[k]["file_name"].ToString());
                    FileStream dnf = new FileStream(Server.MapPath("files/" + dsCheckDup.Tables[0].Rows[k]["filelink"].ToString()), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    List<bool> iHash2 = GetHash(new Bitmap(dnf));
                    int equalElements = iHash1.Zip(iHash2, (i, j) => i == j).Count(eq => eq);
                    result = equalElements;
                    inf.Close();
                    inf.Dispose();
                    dnf.Close();
                    dnf.Dispose();
                    if (result == 256)
                    {
                        dupstatus = 1;


                        filelink = dsCheckDup.Tables[0].Rows[k]["filelink"].ToString();
                        link = dsCheckDup.Tables[0].Rows[k]["keyGen"].ToString();
                        //var folderPath = Server.MapPath("~/files/");
                        //System.IO.DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
                        //  String filepath = ph;
                        //string processName = ph;
                        // Process[] processes = Process.GetProcessesByName(processName);
                        // foreach (Process process in processes)
                        // {
                        //     process.Kill();
                        // }
                        if (File.Exists(Server.MapPath("files/" + userphoto1)))
                        {
                            File.Delete(Server.MapPath("files/" + userphoto1));
                        }

                        break;
                    }
                    else
                    {

                        Random rnd = new Random();
                        String ID = rnd.NextDouble().ToString();
                        link = ID.Substring(2, 4);
                        filelink = userphoto1;

                    }
                }

            }
            else
            {
                filelink = userphoto1;
                Random rnd = new Random();
                String ID = rnd.NextDouble().ToString();
                link = ID.Substring(2, 4);
            }



            String str = "insert into file_details(file_name, file_size, file_type, username, dupliaction,keyGen,tousername)values('" + userphoto1 + "','" + lblfileSize.Text + "','" + lblfileType.Text + "','" + Session["uname"].ToString() + "','" + dupstatus + "','" + link + "','" + lblname.Text  + "')";
            dl.DmlCmd(str);

            str = "select * from file_details where username='" + Session["uname"].ToString() + "' order by file_details_id desc";
            DataSet dsid = dl.GetDataSet(str);
            id = dsid.Tables[0].Rows[0]["file_details_id"].ToString();

            str = "insert into file_link(file_id,keyGen,username,filelink,type)values('" + id + "','" + link + "','" + Session["uname"].ToString() + "','" + filelink + "','" + lblfileType.Text + "')";
            dl.DmlCmd(str);
            Response.Write("<script language='javascript'>alert('File Sent')</script>");
           // Response.Redirect("FILE_DETAILS.aspx");
        }

        else if (Path.GetExtension(FileUpload1.FileName) == ".pdf" || Path.GetExtension(FileUpload1.FileName) == ".docx")
        {
            int dupstatus = 0;
            String link = "";
            String id = "";
            string filelink = "";
            String filename1 = "";
            Random rn = new Random();
            String n = rn.NextDouble().ToString();
            n = n.Substring(2, 3);
            if (FileUpload1.HasFile)
            {
                filename1 = n + FileUpload1.FileName;
                lblfileName.Text = FileUpload1.FileName;
                lblfileSize.Text = Math.Round(((decimal)FileUpload1.PostedFile.ContentLength / (decimal)1024), 2).ToString();
                lblfileType.Text = Path.GetExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("tempfiles/" + filename1));

            }
            String filename = Server.MapPath(FileUpload1.FileName);
            //FileUpload1.PostedFile.SaveAs(filename);
            FileInfo fi1 = new FileInfo(filename1);

            //string filename2 = Server.MapPath("~/tempfiles/") + FileUpload2.FileName;
            //FileUpload2.PostedFile.SaveAs(filename2);
            //FileInfo fi2 = new FileInfo(filename2);
            string checkDup = "select * from file_link where type='.docx' or type='.pdf'";
            DataSet dsCheckDup = dl.GetDataSet(checkDup);
            // Compare the two files that referenced in the textbox controls.
            if (dsCheckDup.Tables[0].Rows.Count > 0)
            {
                for (int k = 0; k < dsCheckDup.Tables[0].Rows.Count; k++)
                {
                    string filename2 = Server.MapPath("~/tempfiles/") + dsCheckDup.Tables[0].Rows[k]["filelink"].ToString();
                    FileInfo fi2 = new FileInfo(filename2);
                    if (FileCompare(filename1, filename2))
                    {
                        Response.Write("Files are equal.");
                        dupstatus = 1;
                        filelink = dsCheckDup.Tables[0].Rows[k]["filelink"].ToString();
                        link = dsCheckDup.Tables[0].Rows[k]["keyGen"].ToString();
                        if (File.Exists(Server.MapPath("tempfiles/" + filename1)))
                        {
                            File.Delete(Server.MapPath("tempfiles/" + filename1));
                        }

                        break;
                    }
                    else
                    {
                        Response.Write("Files are not equal.");
                        Random rnd = new Random();
                        String ID = rnd.NextDouble().ToString();
                        link = ID.Substring(2, 4);
                        filelink = filename1;
                    }
                }
            }
            else
            {
                filelink = filename1;
                Random rnd = new Random();
                String ID = rnd.NextDouble().ToString();
                link = ID.Substring(2, 4);
            }



            String str = "insert into file_details(file_name, file_size, file_type, username, dupliaction,keyGen,tousername)values('" + filename1 + "','" + lblfileSize.Text + "','" + lblfileType.Text + "','" + Session["uname"].ToString() + "','" + dupstatus + "','" + link + "','" + lblname.Text + "')";
            dl.DmlCmd(str);

            str = "select * from file_details where username='" + Session["uname"].ToString() + "' order by file_details_id desc";
            DataSet dsid = dl.GetDataSet(str);
            id = dsid.Tables[0].Rows[0]["file_details_id"].ToString();

            str = "insert into file_link(file_id,keyGen,username,filelink,type)values('" + id + "','" + link + "','" + Session["uname"].ToString() + "','" + filelink + "','" + lblfileType.Text + "')";
            dl.DmlCmd(str);

            Response.Redirect("FILE_DETAILS.aspx");
        }
        else
        {
            Response.Redirect("Invalid file format");
        }
    }
    public static List<bool> GetHash(Bitmap bmpSource)
    {
        List<bool> lResult = new List<bool>();
        Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16));
        for (int j = 0; j < bmpMin.Height; j++)
        {
            for (int i = 0; i < bmpMin.Width; i++)
            {
                lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
            }
        }

        return lResult;
    }
    private bool FileCompare(string file1, string file2)
    {
        int file1byte;
        int file2byte;
        FileStream fs1;
        FileStream fs2;

        // Determine if the same file was referenced two times.
        if (file1 == file2)
        {
            // Return true to indicate that the files are the same.
            return true;
        }
        String f = Server.MapPath("~/tempfiles/" + file1);
        // Open the two files.
        fs1 = new FileStream(f, FileMode.Open);
        fs2 = new FileStream(file2, FileMode.Open);

        // Check the file sizes. If they are not the same, the files 
        // are not the same.
        if (fs1.Length != fs2.Length)
        {
            // Close the file
            fs1.Close();
            fs2.Close();

            // Return false to indicate files are different
            return false;
        }

        // Read and compare a byte from each file until either a
        // non-matching set of bytes is found or until the end of
        // file1 is reached.
        do
        {
            // Read one byte from each file.
            file1byte = fs1.ReadByte();
            file2byte = fs2.ReadByte();
        }
        while ((file1byte == file2byte) && (file1byte != -1));

        // Close the files.
        fs1.Close();
        fs2.Close();

        // Return the success of the comparison. "file1byte" is 
        // equal to "file2byte" at this point only if the files are 
        // the same.
        return ((file1byte - file2byte) == 0);
    }
   
}