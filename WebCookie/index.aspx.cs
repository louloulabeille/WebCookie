using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCookie
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*HttpCookie utilisateur = new HttpCookie("utilisateur");
            utilisateur.Values["connexion"] = DateTime.Now.ToString();
            utilisateur.Values["txtNom"] = "loulou";
            utilisateur.Values["txtPrenom"] = "labeille";

            Response.Cookies["cookie"].Value = "true";
            Response.Cookies.Add(utilisateur);*/

        }
    }
}