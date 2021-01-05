using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace WebCookie
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                HttpCookie util = new HttpCookie("utilisateur");
                string[] tabForm = Request.Form.AllKeys;

                util.Values["connexion"] = DateTime.Now.ToString();
                for (int i = 0; i < tabForm.Length; i++ )
                {
                    util.Values[tabForm[i]] = Request.Form.Get(tabForm[i]);
                }

                /*utilisateur.Values["txtNom"] = Request.Form["txtNom"];
                utilisateur.Values["txtPrenom"] = Request.Form["txtPrenom"];*/

                Response.Cookies["cookie"].Value = "true";
                Response.Cookies.Add(util);
                //Response.Redirect("WebCookies.aspx"); //-- efface le formulaire
                Server.Transfer("WebCookies.aspx",false); //-- peut rediriger mais peut garder mémoire certaines informations
            } 
        }
    }
}