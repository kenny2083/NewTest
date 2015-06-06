using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string json = JsonHandler.GetJsonFromUrl("http://www.reddit.com/r/funny/hot.json");
        //Label1.Text = json;

        List<Post> posts = JsonHandler.GetPosts("http://www.reddit.com/hot.json");

        RepeaterPosts.DataSource = posts;
        RepeaterPosts.DataBind();

        //comment
    }
    protected void LinkButtonSubreddit_Click(object sender, EventArgs e)
    {
        string subreddit = ((LinkButton)sender).CommandArgument;
        List<Post> posts = JsonHandler.GetPosts("http://www.reddit.com/r/"+ subreddit +".json");

        RepeaterPosts.DataSource = posts;
        RepeaterPosts.DataBind();
    }
    protected void RepeaterPosts_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "upvote")
        {
            //((ImageButton)re).ImageUrl = "~/Images/upvote_pressed.png";
            ((ImageButton)RepeaterPosts.Controls[e.Item.ItemIndex]).ImageUrl = "~/Images/upvote_pressed.png";
        }
    }
    protected void ButtonUpvote_Click(object sender, EventArgs e)
    {
        ((Button)sender).Text = "Hello";
    }
}