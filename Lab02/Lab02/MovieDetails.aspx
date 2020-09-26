<%@ Page Title="Movie Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MovieDetails.aspx.cs" Inherits="Lab02.MovieDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productList" runat="server" ItemType="Lab02.Models.Movie" SelectMethod ="GetMovie" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.MovieName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.MovieName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Product Number:</b>&nbsp;<%#:Item.MovieID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
