<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/PostScoreControl.ascx" TagPrefix="uc1" TagName="PostScoreControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
    <script src="script/flowtype.js"></script>

    <link href="App_Themes/MainTheme/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanelPosts" runat="server">
            <ContentTemplate>
                <div class="posts_container">
                    <asp:Repeater ID="RepeaterPosts" runat="server" OnItemCommand="RepeaterPosts_ItemCommand">
                        <ItemTemplate>
                            <div class="post">
                                <a href="<%#Eval("ImageUrl") %>" class="post_thumbnail">
                                    <img src='<%#Eval("Thumbnail") %>' style="width: 100%;" />
                                </a>
                                <div class="post_title">
                                    <div><%#Eval("Title") %></div>
                                </div>
                                <div class="post_score_panel">
                                    <%--<asp:ImageButton ID="ImageButtonUpvote" Width="30px" Height="30px" ImageUrl="~/Images/upvote.png" CommandName="upvote" runat="server" />--%>
                                    <asp:Button ID="ButtonUpvote" runat="server" OnClick="ButtonUpvote_Click" Text="Up" />
                                    <div id="post_score" class="post_score" runat="server"><%#Eval("Score") %></div>
                                    <asp:ImageButton ID="ImageButtonDownvote" Width="30px" Height="30px" ImageUrl="~/Images/downvote.png" runat="server" />
                                </div>
                                <%--<div class="post_subreddit"><%#Eval("Subreddit") %></div>--%>
                                <asp:LinkButton ID="LinkButtonSubreddit" CssClass="post_subreddit" OnClick="LinkButtonSubreddit_Click" CommandArgument='<%#Eval("Subreddit") %>' runat="server"><%#Eval("Subreddit") %></asp:LinkButton>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>

    <script type="text/javascript">

        $('post_title').flowtype();

    </script>
</body>
</html>
