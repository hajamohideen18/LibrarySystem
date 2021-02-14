<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Addbook.aspx.cs" Inherits="LibrarySystem.Addbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 437px;
            height: 355px;
        }
    .style2
    {
        text-align: right;
        color: blue;
        height: 20px;
    }
    .style3
    {
        height: 20px;
    }

    </style>

     <script src="../js/jquery-1.9.1.min.js" type="text/javascript"></script>
     <script type="text/javascript"> 
         function Validate() {
             var status = true;
             var msg = '';
             if ($('#<%=txtbname.ClientID%>').val() == "") {
                 msg += 'Please enter Book Name!\n';
                 status = false;
             }

             if ($('#<%=txtdetail.ClientID%>').val() == "") {
                 msg += 'Please enter Book Detail!\n';
                 status = false;
             }

             if ($('#<%=txtauthor.ClientID%>').val() == "") {
                 msg += 'Please enter Author Name!\n';
                 status = false;
             }

             if (($('#<%=drpbranch.ClientID%>').val() == "") || ($('#<%=drpbranch.ClientID%>').val() == "0")) {
                 msg += 'Please Select Branch!\n';
                 status = false;
             }
             if (($('#<%=drppublication.ClientID%>').val() == "") || ($('#<%=drppublication.ClientID%>').val() == "0")) {
                 msg += 'Please select Publisher!\n';
                 status = false;
             }

             if (($('#<%=txtqnt.ClientID%>').val() == "") || ($('#<%=txtqnt.ClientID%>').val() == "0")  ) {
                 msg += 'Please enter Quantity and Value should greater then 0 !\n';
                 status = false;
             }

             if ($('#<%=txtprice.ClientID%>').val() == "") {
                 msg += 'Please enter Price!\n';
                 status = false;
             }
             else {

             }

             if (status == false) {
                 alert(msg);
                 return false;
             }
             else {

              return true;
             }



         }




     </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="tbl">
        <tr>
            <td class="tblhead">
                ADD NEW BOOK</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <table align="center" class="style1">
                    <tr>
                        <td class="lbl">
                            BookName :</td>
                        <td>
                            <asp:TextBox ID="txtbname" runat="server" CssClass="txt"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="lbl">
                            Detail :
                        </td>
                        <td>
                            <asp:TextBox ID="txtdetail" runat="server" CssClass="txt" TextMode="MultiLine" 
                                Height="50px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="lbl">
                            Autor :
                        </td>
                        <td>
                            <asp:TextBox ID="txtauthor" runat="server" CssClass="txt"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="lbl">
                            Publication :</td>
                        <td>
                            <asp:DropDownList ID="drppublication" runat="server" CssClass="txt">
                                
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="lbl">
                            Branch :
                        </td>
                        <td class="style3" align="left">
                            <asp:DropDownList ID="drpbranch" runat="server" CssClass="txt">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="lbl">
                            Price :
                        </td>
                        <td>
                            <asp:TextBox ID="txtprice" runat="server" CssClass="txt"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="lbl">
                            Quantity&nbsp; :</td>
                        <td>
                            <asp:TextBox ID="txtqnt" runat="server" CssClass="txt"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="lbl">
                            Book Photo :  
                        </td>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="txt" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btnadd" runat="server" CssClass="btn" Text="ADD Book" OnClientClick="return Validate();" OnClick="btnadd_Click"
                               />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>


