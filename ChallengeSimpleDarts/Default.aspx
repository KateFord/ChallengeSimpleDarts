<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="324px" ImageUrl="~/Images/dartboard.jpg" Width="402px" />
    
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="okButton" runat="server" Text="Play" OnClick="okButton_Click" />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
