<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PostScoreControl.ascx.cs" Inherits="PostScoreControl" %>

<asp:UpdatePanel ID="UpdatePanel" runat="server">
    <ContentTemplate>
        <asp:ImageButton ID="ImageButtonUpvote" Width="30px" Height="30px" ImageUrl="~/Images/upvote.png" OnCommand="ImageButtonUpvote_Command" OnClick="ImageButtonUpvote_Click" runat="server" />
        <div id="post_score" class="post_score" runat="server"></div>
        <asp:ImageButton ID="ImageButtonDownvote" Width="30px" Height="30px" ImageUrl="~/Images/downvote.png" runat="server" />
    </ContentTemplate>
</asp:UpdatePanel>