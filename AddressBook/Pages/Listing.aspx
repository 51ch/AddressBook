<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="AdressBook.Pages.Listing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div id="content">
        <%
            foreach (AddressBook.Models.Record record in GetRecords())
            {
                Response.Write(String.Format(@"
                        <div class='item'>
                            <h3>{2} {0} {1}</h3>
                            <h4>{3}</h4>
                            <h4>{4}</h4>
                            <button name='edit' type='submit' value='{5}'>
                                Редактировать
                            </button>
                            <button name='delete' type='submit' value='{5}'>
                                Удалить
                            </button>
                        </div>",
                    record.FirstName, record.MiddleName, record.LastName, record.Email, record.Phone, record.Id));
            }
        %>

    </div>
</asp:Content>
