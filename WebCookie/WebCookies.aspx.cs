using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Web.UI.HtmlControls;
using System.Drawing;

namespace WebCookie
{
    public partial class WebCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableBrowser.Rows.Add(BrowserFamilyRow());
            TableBrowser.Rows.Add(VersionBrowserRow());
            TableBrowser.Rows.Add(CookiesBrowserRow(Request.Cookies));
            TableBrowser.Rows.Add(JScriptVersionBrowserRow());
            TableBrowser.Rows.Add(ActiveXBrowserRow());
            Table newtable = new Table();
            
        }

        protected TableRow CookiesBrowserRow (HttpCookieCollection cookie)
        {
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            TableCell cell2 = new TableCell();

            cell.Text = "Accepte les cookies";
            cell.BorderColor = Color.Blue;
            cell.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell);

            if ( cookie["cookie"] != null )
            {
                HttpCookie util = cookie.Get("utilisateur");
                if (util.HasKeys) //-- HasKeys indiquant si un cookie possède des sous-clés.
                {
                    String[] tabCookie = util.Values.AllKeys; 
                    for ( int i = 0; i < tabCookie.Length; i++ )
                    {
                        Response.Write(tabCookie[i] +" : "+ util.Values.Get(tabCookie[i])+"<br/>");
                    }
                    
                    TextBoxNom.Text = util["txtNom"];
                    TextBoxPrenom.Text = util["txtPrenom"];
                    TextBoxConnexion.Text = util["connexion"];
                }
                cell2.Text = "True";
            }
            else
            {
                cell2.Text = "False";
            }
            cell2.BorderColor = Color.Blue;
            cell2.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell2);
            row.BackColor = Color.LightGreen;
            return row;
        }

        protected TableRow ActiveXBrowserRow ()
        {
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            TableCell cell2 = new TableCell();
            HttpBrowserCapabilities browser = Request.Browser;

            cell.Text = "Accepte les ActiveX";
            cell.BorderColor = Color.Blue;
            cell.BorderWidth = Unit.Pixel(1);

            row.Cells.Add(cell);

            if (((System.Web.Configuration.HttpCapabilitiesBase)browser).ActiveXControls)
            {
                cell2.Text = "True";
            }
            else
            {
                cell2.Text = "False";
            }

            cell2.BorderColor = Color.Blue;
            cell2.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell2);
            row.BackColor = Color.LightGreen;
            return row;
        }

        protected TableRow JScriptVersionBrowserRow ()
        {
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            TableCell cell2 = new TableCell();
            HttpBrowserCapabilities browser = Request.Browser;

            cell.Text = "Accepte la version de javascript";
            cell.BorderColor = Color.Blue;
            cell.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell);

            cell2.Text = browser.JScriptVersion.ToString();
            cell2.BorderColor = Color.Blue;
            cell2.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell2);
            row.BackColor = Color.LightGreen;
            return row;
        }

        protected TableRow BrowserFamilyRow()
        {
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            TableCell cell2 = new TableCell();
            HttpBrowserCapabilities browser = Request.Browser;

            cell.Text = "Marque du navigateur";
            cell.BorderColor = Color.Blue;
            cell.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell);

            cell2.Text = browser.Browser;
            cell2.BorderColor = Color.Blue;
            cell2.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell2);
            row.BackColor = Color.LightGreen;

            return row;
        }

        protected TableRow VersionBrowserRow()
        {
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            TableCell cell2 = new TableCell();
            HttpBrowserCapabilities browser = Request.Browser;

            cell.Text = "Dans sa version";
            cell.BorderColor = Color.Blue;
            cell.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell);

            cell2.Text = browser.Version;
            cell2.BorderColor = Color.Blue;
            cell2.BorderWidth = Unit.Pixel(1);
            row.Cells.Add(cell2);
            row.BackColor = Color.LightGreen;
            return row;
        }
    }
}