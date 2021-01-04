using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCookie
{
    public partial class WebFormCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] form = Request.Form.AllKeys;
            HttpCookie formCookie = new HttpCookie("utilisateur");

            for(int i = 0; i < form.Length; i++ )
            {
                Response.Write(Request["txtNom"]);
            }
        }
    }
}