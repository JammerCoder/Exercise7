<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExerciseBase.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 7</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="400px" align="center">
                <tr valign="top">
                    <td align="left">
                        <asp:Button ID="btnClickMe" runat="server" Text="ClickMe!" ToolTip="Click for Magic!" OnClick="btnClickMe_Click" />     
                    </td>
                    <td align="left">                        
                        <asp:Label ID="lblDisplay" runat="server" Text="" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Literal ID="litDisplay" runat="server" Text="Test" />
                    </td>
                </tr>
        </table>            
    </div>
    </form>
</body>
</html>
