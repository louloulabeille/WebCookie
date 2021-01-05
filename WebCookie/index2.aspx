﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="WebCookie.index2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
<style type="text/css">
    body
    {
        color: Blue;
        font-family: Arial;
    }
    .inputText
    {
        border: 0.1em solid blue;
        background-color: rgb(114,197,151);
        color: white;
        margin-top: 0.3em;
    }
    #fsCoordonnees
    {
        width: 50%;
        margin: auto;
    }
       
       
    label
    {
        display: block;
        width: 135px;
        float: left;
        margin-top: 0.3em;
    }
</style>

<script type="text/javascript">
<!--
    //
    // Initialisation du formulaire
    // Association des gestionnaires d'événement
    //
    window.onload = function () {
        var elementsInput = document.getElementsByTagName('input');
        for (var i = 0; i < elementsInput.length; i++) {

            if (elementsInput[i].addEventListener) {
                elementsInput[i].addEventListener('focus', gestionnaireFocus, false);
                elementsInput[i].addEventListener('blur', gestionnaireBlur, false);
            }
            else {
                elementsInput[i].attachEvent('onfocus', gestionnaireFocus);
                elementsInput[i].attachEvent('onblur', gestionnaireBlur);
            }
        }
    };

    //
    // Affectation des styles sur prise et perte de focus
    //
    function gestionnaireFocus(e) {
        modifierStyle(e, 1);
    };
    function gestionnaireBlur(e) {
        modifierStyle(e, 2);
    };

    // Change le fond de la boite input
    function modifierStyle(e, type) {
        var target = e.target || e.srcElement;
        if (e.stopPropagation) e.stopPropagation();
        else e.cancelBubble = true;

        switch (type) {
            case 1:
                target.style.backgroundColor = 'white';
                target.style.color = '#72C597';
                break;
            case 2:
                target.style.backgroundColor = '#72C597';
                target.style.color = 'white';
                break;
        }
    };
    function envoyer() {

        document.forms['frmCoordonnees'].submit();
    };
  //-->
</script>

</head>
<body>
    <form id="frmCoordonnees" runat="server">
        <fieldset id='fsCoordonnees'>
        <legend>Saisie des informations vous concernant</legend>
        <p>
            <label for='txtNom'>
                Nom :</label>
            <input class="inputText" id="txtNom" name="txtNom"
                type="text" runat="server"/>
           
        </p>
        <p>
            <label for='txtPrenom'>
                Prénom :</label>
            <input class="inputText" id="txtPrenom" name="txtPrenom" type="text" runat="server"/>
          
        </p>
        
        <p>
            <input id='btnEnvoyer' class="inputText" onclick="envoyer()" value="Envoyer" type="button" runat="server" />
        </p>
    </fieldset>
    </form>

    <div>
        <span id="affichage" runat="server">toto</span>
    </div>
</body>
</html>
