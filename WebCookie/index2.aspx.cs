using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCookie
{
    public partial class index2 : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNom.ServerChange += new EventHandler(Txt_Nom_Server_Change);
            if ( IsPostBack )
            {
                
            }
            else
            {
                this.txtNom.Value = "loudieres";
            }
            
            
            //affichage.InnerText = "Valeur du nom : " + Request.Form["txtNom"];
        }

        protected void Txt_Nom_Server_Change ( object sender, EventArgs e) 
        { 
            affichage.InnerText = "Valeur du nom : loulou";
        }
        
    }
}