<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs" Inherits="ManageStudent.StudentDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="studentDetail" runat="server" ItemType="ManageStudent.Models.Student" 
        SelectMethod ="GetStudents" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.StudentName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/img/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" 
                            alt="<%#:Item.StudentName %>"/>

                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align:left;">
                        <b>Birthday:</b><br /><%#:Item.Birthday %>
                        <br />
                        <span><b>Student Number:</b>&nbsp;<%#:Item.StudentID%></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
