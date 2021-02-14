<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LibrarySystem.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 100px;
        }
    </style>
      <script src="../js/jquery-1.9.1.min.js" type="text/javascript"></script>
     <script type="text/javascript"> 
         function Validate() {
             var status = true;
             var msg = '';
             if ($('#txtuname').val() == "") {
                 msg += 'Please enter User Name!\n';
                 status = false;
             }

             if ($('#txtupass').val() == "") {
                 msg += 'Please enter Password!\n';
                 status = false;
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




</head>
<body>
    <form id="form1" runat="server">
    <div id="head">
    
      <h1 style ="color:blue;" >Library Management</h1>  </div>
    <div id="main"><div id="img">
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/img/lin3.png" Height="314px" 
                        style="margin-left: 94px" Width="561px" />
                </td>
            </tr>
        </table>
        </div>
    <div id="login">
        <table class="tbl">
            <tr>
                <td class="tblhead" colspan="2">
                    Login Area</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lbl" runat="server" Font-Size="11px" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lbl">
                    UserName&nbsp; :</td>
                <td>
                    <asp:TextBox ID="txtuname" runat="server" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="lbl">
                    Password :
                </td>
                <td>
                    <asp:TextBox ID="txtupass" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:RadioButton ID="rdolibrary" runat="server" Checked="True" 
                        ForeColor="Blue" GroupName="a" Text="Librarian" />
&nbsp;<asp:RadioButton ID="rdosudent" runat="server" ForeColor="Blue" GroupName="a" 
                        Text="User" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Login"  OnClientClick="return Validate();"
                        Width="80px" Font-Size="10pt" onclick="Button1_Click" />

                </td>
            </tr>
        </table>
    </div>
    
    </div>
    </form>
</body>

    
</html>

