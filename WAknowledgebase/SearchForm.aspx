<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForm.aspx.cs" Inherits="WAknowledgebase.SearchForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.4.4.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.fcbkcomplete.js" type="text/javascript"></script>
    <link href="Scripts/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <select id="selectContries" >
            </select>
        </div>
    </div>
    </form>
</body>
<script type="text/javascript">
    $(document).ready(function () {
        $("#selectContries").fcbkcomplete({
            json_url: '<%=ResolveUrl("~/BaseWebService.asmx/GetQuestions") %>',
                addontab: false,
                height: 10,
                maxitems:1,
                complete_text: "Сұрақты енгізіңіз...",
                onselect: alertData,
                onremove: alertData
            });
      });

        function alertData() {
            alert($('#selectContries').val());
        }
</script>
</html>
