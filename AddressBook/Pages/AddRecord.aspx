<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddRecord.aspx.cs" Inherits="AdressBook.Pages.AddRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>Имя:</p>   
    <asp:TextBox ID="tbox_FirstName" runat="server"></asp:TextBox>
    <hr />
    <p>Отчество:</p>
    <asp:TextBox ID="tbox_MiddleName" runat="server"></asp:TextBox>
    <hr />
    <p>Фамилия:</p>
    <asp:TextBox ID="tbox_LastName" runat="server"></asp:TextBox>
    <hr />
    <p>Адрес электронной почты:</p>
    <asp:TextBox ID="tbox_Email" runat="server"></asp:TextBox>
    <hr />
    <p>Номер телефона:</p>
    <asp:TextBox ID="tbox_Phone" runat="server"></asp:TextBox>
    <hr />
    <asp:Button ID="btn_Save" runat="server" Text="Сохранить" OnClick="btn_Save_Click" />
</asp:Content>
