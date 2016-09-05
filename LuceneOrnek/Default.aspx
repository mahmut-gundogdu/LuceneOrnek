<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LuceneOrnek.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnEkle" runat="server" Text="indexle" OnClick="btnEkle_Click" />
        <br />
        <asp:TextBox ID="txtAra" runat="server"></asp:TextBox><asp:Button ID="btnAra" runat="server" Text="Button" OnClick="btnAra_Click" style="width: 56px" /><asp:GridView ID="gvData" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
