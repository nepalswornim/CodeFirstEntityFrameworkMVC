<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CodeFirstEntityFrameworkThirdClass.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>

    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style7 {
            width: 139px;
        }
        .auto-style8 {
            width: 139px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <nav class="navbar navbar-inverse navbar-fixed-top">
            <a class="navbar-brand" href="#">Entity Framework Code First</a>&nbsp;
        </nav>
        <div class="container">
              

        <div class="wrapper">

          
               

                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title">Login</h3>
                    </div>
                    <div class="panel-body">
                        <table class="auto-style1 table">

                            <tr>
                                <td class="auto-style7">Name</td>
                                <td>
                                    <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">Gender</td>
                                <td>
                                    <asp:DropDownList ID="ddlGender" CssClass="form-control" runat="server">
                                        <asp:ListItem>Choose Gender</asp:ListItem>
                                        <asp:ListItem>Male</asp:ListItem>
                                        <asp:ListItem>Female</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Username</td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="txtUsername" CssClass="form-control" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">Password</td>
                                <td>
                                    <asp:TextBox ID="txtPasword" CssClass="form-control" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7" colspan="2">
                                   
                                
                               
                                    <asp:Button ID="btnSubmit" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                                    <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-warning" Text="Delete" OnClick="btnDelete_Click"  />
                                    <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" Text="Cancel" OnClick="btnCancel_Click"  />
                                </td>
                            </tr>
                            <tr>
                                <td>

                                </td>
                                <td> <asp:Label ID="lblMessage" runat="server"></asp:Label> </td>
                            </tr>
                            </table>
                        
                    </div>
                    
                </div>
            
                      <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="393px">
                          <AlternatingRowStyle BackColor="#F7F7F7" />
                          <Columns>
                              <asp:CommandField ButtonType="Image" SelectImageUrl="~/css/edit.png" SelectText="Edit" ShowSelectButton="True" />
                          </Columns>
                          <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                          <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                          <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                          <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                          <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                          <SortedAscendingCellStyle BackColor="#F4F4FD" />
                          <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                          <SortedDescendingCellStyle BackColor="#D8D8F0" />
                          <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
                    </div>
          
                      </div>
         

        <nav class="navbar navbar-inverse navbar-fixed-bottom">

            <p class="navbar-text navbar-left">
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <a href="#" class="navbar-link">Swornim Nepal</a></p>
            <div class="container">
            </div>
        </nav>
    </form>
</body>
</html>
