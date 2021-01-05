using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCookie
{
    public partial class index3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNom.ServerChange += new EventHandler(Text_Change);
        }

        protected void Text_Change ( object sender, EventArgs e)
        {
            txtNom.Value = "va te faire";
        }
    }
}