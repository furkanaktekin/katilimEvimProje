<%@ Page Language="C#" Inherits="katilimEvimProje.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
        <meta charset="UTF-8">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
            <div style="width:500px;margin-right:auto;margin-left:auto">
                   <br/>
                <img src="https://www.katilimevim.com.tr/wp-content/uploads/katilimevim-logoV2.svg"/>
                <br/>
                <br/>
                 <br/>
                <br/>
                <asp:FileUpload id="FileUpload1" runat="server" style="cursor:pointer"></asp:FileUpload> 
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <asp:Button id="UploadButton" Text="Dosyayı Oku" OnClick="UploadButton_Click" runat="server" style="height:40px;border:solid 1px #0055B8;background-color:#0055B8;color:#FF6B00;cursor:pointer;font-size:20px;border-radius:5px"></asp:Button> 
                
                <br/>
                <br/>
                
                <asp:Label id="UploadStatusLabel" runat="server"></asp:Label>  
                
            </div>
	</form>
</body>
</html>