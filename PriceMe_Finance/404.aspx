<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="AllRates._404" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="width:100%;">
    <div style="padding:20px 10px 10px 20px;vertical-align:middle;">
        <img src="http://images.pricemestatic.com/images/info.gif" width="22" height="20" alt=""/>&nbsp;
        <h1 style="display:inline-block;">Sorry, the page was not found!</h1>
        <div class="clr"></div>
    </div>
    <style type="text/css">
        #info404 li
        {
            list-style-type: disc;
            display: list-item;
            list-style-position: inside;
            font-size:16px;
        }
    </style>
    <div style="padding:20px 10px 10px 20px">
        <p style="font-size:18px;">We have noted this error and it will be reviewed by our technical staff.</p>
		<ul id="info404">
			<li>If you typed the address yourself, please confirm the spelling is correct.</li>
			<li>If you clicked a link from your favourites, the link may be out of date.</li>
			<li>Otherwise, we may be experiencing problems with our servers. We will fix this without you needing to do anything further.</li>
		</ul>
		<br/>
		<p style="font-size:16px;">If you continue to have problems please info@priceme.co.nz for assistance.</p>
    </div>
</div>

</asp:Content>
