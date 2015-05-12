<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddReplyForm.aspx.cs" Inherits="WAknowledgebase.AddReplyForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .tbMultiline {
            min-width: 500px;
            min-height: 150px;
            border: 1px solid dodgerblue;
            border-radius: 10px;
            margin: 0px;
            width: 516px;
            height: 150px;
        }

        .replytable {
            margin: 10px;
        }

            .replytable td {
                padding: 10px 5px;
            }

        .btn {
            color: aliceblue;
            background: dodgerblue;
            border-radius: 5px;
            min-width: 100px;
        }

        select {
            width: 500px;
            /*white-space:pre-wrap;*/
        }
    </style>
    <div style="margin: 10px;">
        <asp:Label runat="server" Text="Бөлімді таңдаңыз:"></asp:Label>
        <asp:DropDownList runat="server" ID="ddlSection" ToolTip="Бөлімді таңдаңыз" Style="border-radius: 5px; border-color: darkgray;" OnSelectedIndexChanged="ddlSection_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Value="1" Text="Жеке тұлға"></asp:ListItem>
            <asp:ListItem Value="2" Text="Заңды тұлға"></asp:ListItem>
        </asp:DropDownList>

        <div style="margin: 10px">
            <h2 style="color: dodgerblue;">Сұрақ</h2>
            <asp:CheckBox runat="server" ID="cbOnlyNewQuestions" Checked="true" OnCheckedChanged="cbOnlyNewQuestions_CheckedChanged" AutoPostBack="true" Text="Жаңа сұрақтарды ғана көрсету" />
            <br />
            <table>
                <tr>
                    <td style="vertical-align: top;">
                        <label>Тізімнен сұрақты таңдаңыз:</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" Style="border-radius: 5px; border-color: darkgray;" ID="ddlQuestion" OnSelectedIndexChanged="ddlQuestion_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </td>
                </tr>
            </table>
            <div style="border: 1px solid dodgerblue; border-radius: 10px; padding: 5px; margin: 10px;">
                <asp:Label ID="lbQuestionText" runat="server" Style="color: darkblue; font-size: 18px;"></asp:Label>
            </div>
        </div>

        <div>
            <h2 style="color: dodgerblue;">Жауап</h2>
            <asp:RadioButtonList runat="server" ID="rblNewOrOldReply" AutoPostBack="true">
                <asp:ListItem Value="1" Text="Жаңа жауап қосу"></asp:ListItem>
                <asp:ListItem Value="2" Text="Жауаптар тізімінен байланыстыру"></asp:ListItem>
            </asp:RadioButtonList>

            <%if (rblNewOrOldReply.SelectedIndex == 0)
              { %>

            <table class="replytable">
                <tr>
                    <td style="vertical-align: top;">Жауап мәтіні:</td>
                    <td>
                        <textarea id="tbReplyText" required class="tbMultiline" runat="server" placeholder="Жауап мәтінін енгізіңіз..."></textarea>

                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top;">Қосымша мәлімет:
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="tbMultiline" Style="height: 100px !important; min-height: 100px !important;" ID="tbDescription" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td style="float: right;">
                        <asp:Button runat="server" CssClass="btn" ID="btnAddNewReply" OnClick="btnAddNewReply_Click" Text="Қосу" />
                        <asp:Button runat="server" Text="Болдырмау" CssClass="btn" ID="btnCancel" OnClick="btnCancel_Click"/>
                    </td>
                </tr>
            </table>


            <% }
              else if (rblNewOrOldReply.SelectedIndex == 1)
              { %>

            <div style="margin: 10px;">
                <label>Тізімнен жауапты таңдаңыз</label>
                <asp:DropDownList runat="server" ID="ddlRepliesList" Style="width: 700px; border-radius: 5px; border-color: darkgray;" OnSelectedIndexChanged="ddlRepliesList_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                <br />
                <div style="border: 1px solid dodgerblue; border-radius: 10px; padding: 5px; margin: 10px;">
                    <asp:Label ID="lbReplyText" runat="server" Style="color: darkblue; font-size: 18px;"></asp:Label>
                </div>
                <asp:Button runat="server" CssClass="btn" ID="btnConnect" Text="Байланыстыру" OnClick="btnConnect_Click"/>
                <asp:Button runat="server" Text="Болдырмау" CssClass="btn" ID="btnCalcel2" OnClick="btnCancel_Click"/>
            </div>

            <% } %>
        </div>
    </div>

</asp:Content>
