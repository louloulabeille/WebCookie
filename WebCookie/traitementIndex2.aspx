<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="traitementIndex2.aspx.cs" Inherits="WebCookie.traitementIndex2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <% 
        int loop1;
        NameValueCollection coll; 

        //Load Form variables into NameValueCollection variable.
        coll=Request.Form;
        // Get names of all forms into a string array.
        String[] arr1 = coll.AllKeys;
        for (loop1 = 0; loop1 < arr1.Length; loop1++)
        {
           Response.Write("Form: " + arr1[loop1] + "<br>");
        }
    %>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
