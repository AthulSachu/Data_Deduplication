using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Data;


public partial class fileupload : System.Web.UI.Page
{

    DataSet ds = new DataSet();
    DataLayer dl = new DataLayer();


    public static bool ImageCompareString(Bitmap firstImage, Bitmap secondImage)
    {
        MemoryStream ms = new MemoryStream();
        firstImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        String firstBitmap = Convert.ToBase64String(ms.ToArray());
       // ms.Position = 0;

        secondImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        String secondBitmap = Convert.ToBase64String(ms.ToArray());
       

        if (firstBitmap.Equals(secondBitmap))
        {

        //  Response.Write("<script language='script'>alert('IMAGE FOUND !')</script>");
            return true;
        }
        else
        {
            return false;
        }
    }






    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {



    }
    protected void BTNUPLOAD_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("temp\\" + FileUpload1.FileName));

           
        }

        String s = Server.MapPath("file\\" + FileUpload1.FileName);

        String m = "D:\\deduplication\\file";
        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(m);
        System.IO.FileInfo[] file = dir.GetFiles();
        if (file.Length > 0)
        {
            for (int i = 0; i < file.Length - 1; i++)
            {
                Bitmap first = new Bitmap(file[i].FullName);
                Bitmap sec = new Bitmap(s);
                bool c = ImageCompareString(first, sec);
                if (c == true)
                {
                   
                    Response.Write("<script language='script'>alert('IMAGE FOUND !')</script>");


                    break;
                }
               
            }
        }
        else
        {
           // Response.Write("<script language='script'>alert('IMAGE FOUND !')</script>");
            FileUpload1.SaveAs(s);
        }

    }
}