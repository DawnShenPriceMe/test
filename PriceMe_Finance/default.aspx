<%@ Page Title="Financial Comparison - Compare and Save with PriceMe Money" Language="C#"
    MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs"
    Inherits="EasyRate.Default" %>

<%@ Register Src="~/Modules/FeaturedCarousel.ascx" TagName="FeaturedCarousel" TagPrefix="DK" %>
<%@ Register Src="~/Modules/Ads/YahooLREC.ascx" TagName="YahooLREC" TagPrefix="DK" %>
<%@ Register Src="~/Modules/TodaysInterestRates.ascx" TagName="TodaysInterestRates"
    TagPrefix="DK" %>
<%@ Register Src="~/Modules/HomeLoans/NewsInBlog.ascx" TagName="NewsInBlog" TagPrefix="DK" %>
<%@ MasterType VirtualPath="~/Main.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="topContentDiv">
        <div id="topLeftContentDiv">
            <br />
            <h1>
                Financial Comparison</h1>
            <h1>
                <span>Compare and Save Online</span></h1>
            <br />
            <DK:FeaturedCarousel ID="FeaturedCarousel" runat="server" />
        </div>
        <div id="topRightContentDiv" style="padding-top:60px;">
            <DK:NewsInBlog ID="NewsInBlog1" runat="server" />
            <%--<DK:YahooLREC ID="YahooLREC" runat="server" />--%>
        </div>
    </div>
    <br />
    <br />
    <DK:TodaysInterestRates ID="TodaysInterestRates" runat="server" />
    <br />
    <br />
    <div style="padding-left: 20px;">
        <div class="HomeAboutTitle bg">
            <h2>
                About</h2>
            <h3>
                PriceMe Money</h3>
        </div>
        <div>
            <div class="HomeAboutContent">
                <p>
                    Compare and save using PriceMe Money new financial comparison tool. We're making
                    it really easy for you to compare rates and service offerings from trusted New Zealand
                    providers. We're taking the guesswork out of the equation and offer a transparent
                    and objective view of financial products and services available in New Zealand.
                    The new sub-site is all about finding you the right product from a reputable provider
                    and saving you some money and time in the process.</p>
                <p>
                    You can presently compare credit card rates and different kinds of cards, savings
                    accounts and term deposits. We'll add comparison of KiwiSaver plans, life insurance
                    as well as other financial products shortly.</p>
                <p>
                    Finding and comparing rates and fees is quick and easy, and no personal information
                    is required. You just indicate how much you want to deposit or what type of card
                    you're interested in, and PriceMe Money returns the most relevant products available
                    in New Zealand sorted by rates and fees based on your needs. You can then make an
                    informed decision and select a Kiwi provider that best matches your needs and sign-up
                    online. It's that easy to get a good deal!</p>
            </div>
            <div style="float: left; width: 265px">
                <img src="http://images.pricemestatic.com/images/Finance/FinanceNewDesign/aboutpic.jpg"
                    alt="" width="264" height="229" />
            </div>
        </div>
    </div>
</asp:Content>
