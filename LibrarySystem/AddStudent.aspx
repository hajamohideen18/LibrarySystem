<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="LibrarySystem.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 471px;
            height: 415px;
        }
    </style>

    <script src="../js/jquery-1.9.1.min.js" type="text/javascript"></script>
     <script type="text/javascript"> 
         function Validate() {
             var status = true;
             var msg = '';
             if ($('#<%=txtsname.ClientID%>').val() == "") {
                 msg += 'Please enter Student Name!\n';
                 status = false;
             }

             if ($('#<%= txtmobile.ClientID%>').val() == "") {
                 msg += 'Please enter Mobile No!\n';
                 status = false;
             }

             if ($('#<%=txtemail.ClientID%>').val() == "") {
                 msg += 'Please enter Email !\n';
                 status = false;
             }

             if ($('#<%=txtpass.ClientID%>').val() == "") {
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


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="tbl">
    <tr>
        <td class="tblhead">
            ADD NEW STUDENT</td>
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
                        Student Name :</td>
                    <td>
                        <asp:TextBox ID="txtsname" runat="server" CssClass="txt"></asp:TextBox>
                        </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="lbl">
                        Branch : </td>
                    <td>
                            <asp:DropDownList ID="drpbranch" runat="server" CssClass="txt">
                            </asp:DropDownList>
                        </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="lbl">
                        Gender&nbsp; : </td>
                    <td>
                        <asp:RadioButton ID="rdomale" runat="server" Checked="True" Text="MALE" />
                        <asp:RadioButton ID="rdofemale" runat="server" Text="FEMALE" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
               <%-- <tr>
                    <td class="lbl">
                        BirthDate : </td>
                    <td>
                        <asp:DropDownList ID="drpdd" runat="server">
                            <asp:ListItem>DD</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                             <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                             <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem>23</asp:ListItem>
                            <asp:ListItem>24</asp:ListItem>
                            <asp:ListItem>25</asp:ListItem>
                            <asp:ListItem>26</asp:ListItem>
                            <asp:ListItem>27</asp:ListItem>
                            <asp:ListItem>28</asp:ListItem>
                            <asp:ListItem>29</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>31</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="drpmm" runat="server">
                            <asp:ListItem>MM</asp:ListItem>
                            <asp:ListItem>jan</asp:ListItem>
                            <asp:ListItem>feb</asp:ListItem>
                            <asp:ListItem>mar</asp:ListItem>
                            <asp:ListItem>apr</asp:ListItem>
                            <asp:ListItem>may</asp:ListItem>
                            <asp:ListItem>jun</asp:ListItem>
                            <asp:ListItem>jul</asp:ListItem>
                            <asp:ListItem>aug</asp:ListItem>
                            <asp:ListItem>sep</asp:ListItem>
                            <asp:ListItem>oct</asp:ListItem>
                            <asp:ListItem>nov</asp:ListItem>
                            <asp:ListItem>dec</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="drpyyyy" runat="server">
                            <asp:ListItem>YYYY</asp:ListItem>
                            <asp:ListItem>1980</asp:ListItem>
                            <asp:ListItem>1981</asp:ListItem>
                            <asp:ListItem>1982</asp:ListItem>
                            <asp:ListItem>1983</asp:ListItem>
                            <asp:ListItem>1984</asp:ListItem>
                            <asp:ListItem>1985</asp:ListItem>
                            <asp:ListItem>1986</asp:ListItem>
                            <asp:ListItem>1987</asp:ListItem>
                            <asp:ListItem>1988</asp:ListItem>
                            <asp:ListItem>1989</asp:ListItem>
                            <asp:ListItem>1990</asp:ListItem>
                            <asp:ListItem>1991</asp:ListItem>
                             <asp:ListItem>1992</asp:ListItem>
                            <asp:ListItem>1993</asp:ListItem>
                             <asp:ListItem>1994</asp:ListItem>
                            <asp:ListItem>1995</asp:ListItem>
                             <asp:ListItem>1996</asp:ListItem>
                            <asp:ListItem>1997</asp:ListItem>
                             <asp:ListItem>1998</asp:ListItem>
                            <asp:ListItem>1999</asp:ListItem>
                             <asp:ListItem>2000</asp:ListItem>
                            <asp:ListItem>2001</asp:ListItem>
                             <asp:ListItem>2002</asp:ListItem>
                             <asp:ListItem>2003</asp:ListItem>
                             <asp:ListItem>2004</asp:ListItem>
                             <asp:ListItem>2005</asp:ListItem>
                             <asp:ListItem>2006</asp:ListItem>
                             <asp:ListItem>2007</asp:ListItem>
                             <asp:ListItem>2008</asp:ListItem>
                             <asp:ListItem>2009</asp:ListItem>
                             <asp:ListItem>2010</asp:ListItem>
                             <asp:ListItem>2011</asp:ListItem>
                             <asp:ListItem>2012</asp:ListItem>
                             <asp:ListItem>2013</asp:ListItem>
                             <asp:ListItem>2014</asp:ListItem>
                             <asp:ListItem>2015</asp:ListItem>
                             <asp:ListItem>2016</asp:ListItem>
                             <asp:ListItem>2017</asp:ListItem>
                             <asp:ListItem>2018</asp:ListItem>
                             <asp:ListItem>2019</asp:ListItem>
                             <asp:ListItem>2020</asp:ListItem>
                             <asp:ListItem>2021</asp:ListItem>
                         </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>--%>
                <tr>
                    <td class="lbl">
                        Mobile : </td>
                    <td>
                        <asp:TextBox ID="txtmobile" runat="server" CssClass="txt"></asp:TextBox>
                        </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="lbl">
                        Address : </td>
                    <td>
                        <asp:TextBox ID="txtaddress" runat="server" CssClass="txt"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="lbl">
                        City : </td>
                    <td>
                        <asp:TextBox ID="txtcity" runat="server" CssClass="txt"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="lbl">
                        Pincode : </td>
                    <td>
                        <asp:TextBox ID="txtpincode" runat="server" CssClass="txt"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="lbl">
                        Photo : </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="lbl">
                        Email : </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server" CssClass="txt"></asp:TextBox>
                        </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="lbl">
                        Password : </td>
                    <td>
                        <asp:TextBox ID="txtpass" runat="server" CssClass="txt"></asp:TextBox>
                        </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnadd" runat="server" CssClass="btn" onclick="btnadd_Click" 
                            Text="ADD Student" OnClientClick="return Validate();" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>


