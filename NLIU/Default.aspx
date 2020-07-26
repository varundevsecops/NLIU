<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            background-color: #FFFF99;
            height: 650px;
            width:100%;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" visible="True">
    <div style="position:relative;left: 31%;width: 25%;height: 228px; background-color: #99CCFF;">
     <h4>
                <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login</strong></h4>
        <p>
            <span style="font-family: 'Times New Roman', Times, serif">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username:</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <span style="font-family: 'Times New Roman', Times, serif">&nbsp;&nbsp;&nbsp;&nbsp; Password:&nbsp; </span>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;</p>
        <p>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button  style="  width: 90px; height: 35px;  border-radius: 13px; position: relative;  top: 0px; left: 1px; font-family: 'Times New Roman', Times, serif;" 
            ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Lbl_msg" runat="server"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
