﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PDFThisHMTL.aspx.cs" Inherits="RentalMobile.Reports.PdfThisHmtl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        .left
        {
            text-align: left;
        }
        .center
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        
        <div id="Outsideofform">
            <asp:Button ID="OutsideofformButton" runat="server" Text="Button" 
                onclick="OutsideofformButton_Click" />
        </div>
    <div>
        <div id="Report" runat="server">
            
            <asp:Label ID="Label1" runat="server" Text="HELLO THERE"></asp:Label>
            </div>
    
    </div>
    
    
      <div id="TestDiv" runat="server">
            
            <asp:Label ID="Label2" runat="server" Text="HELLO THERE"></asp:Label>
            </div>
    
    </form>
</body>
</html>
