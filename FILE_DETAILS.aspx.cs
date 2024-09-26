using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Threading;


public partial class FILE_DETAILS : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
        }
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {

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
                        dupstatus+= 1;
                        
                        
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



            String str = "insert into file_details(file_name, file_size, file_type, username, dupliaction,keyGen)values('" + userphoto1 + "','" + lblfileSize.Text + "','" + lblfileType.Text + "','" + Session["uname"].ToString() + "','" + dupstatus + "','" + link + "')";
            dl.DmlCmd(str);

            str = "select * from file_details where username='" + Session["uname"].ToString() + "' order by file_details_id desc";
            DataSet dsid = dl.GetDataSet(str);
            id = dsid.Tables[0].Rows[0]["file_details_id"].ToString();

            str = "insert into file_link(file_id,keyGen,username,filelink,type)values('" + id + "','" + link + "','" + Session["uname"].ToString() + "','" + filelink + "','" + lblfileType.Text + "')";
            dl.DmlCmd(str);

            Response.Redirect("FILE_DETAILS.aspx");
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



            String str = "insert into file_details(file_name, file_size, file_type, username, dupliaction,keyGen)values('" + filename1 + "','" + lblfileSize.Text + "','" + lblfileType.Text + "','" + Session["uname"].ToString() + "','" + dupstatus + "','" + link + "')";
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

}