<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add-PO.aspx.cs" Inherits="POWebApp.Add_PO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Title:
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            </h1>
            <br />
            <asp:Button ID="btnSavePO" runat="server" Font-Size="Large"  Text="Save" OnClick="btnSavePO_Click" />
            <br />
            <asp:Label ID="lblStatus" runat="server" Text="PO status will show here."></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
