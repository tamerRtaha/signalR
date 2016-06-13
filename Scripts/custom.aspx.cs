using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class custom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("EnglishName " + Thread.CurrentThread.CurrentCulture.EnglishName + "<br>");
        Response.Write("Name " + Thread.CurrentThread.CurrentCulture.Name + "<br>");
        Response.Write("DisplayName " + Thread.CurrentThread.CurrentCulture.DisplayName + "<br>");
        Response.Write("NativeName " + Thread.CurrentThread.CurrentCulture.NativeName + "<br>");
    }

    protected void Upload(object sender, EventArgs e)
    {
        string base64 = Request.Form["imgCropped"];
        byte[] bytes = Convert.FromBase64String(base64.Split(',')[1]);
        using (System.IO.FileStream stream = new System.IO.FileStream(Server.MapPath("~/Images/Cropped.png"), System.IO.FileMode.Create))
        {
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
        }
    }

}