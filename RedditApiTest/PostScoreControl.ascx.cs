using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PostScoreControl : System.Web.UI.UserControl
{

    public string PostId { get; set; }
    public string PostScore { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        post_score.InnerHtml = PostScore;
    }
    protected void ImageButtonUpvote_Click(object sender, ImageClickEventArgs e)
    {
        ((ImageButton)sender).ImageUrl = "~/Images/upvote_pressed.png";
    }
    protected void ImageButtonUpvote_Command(object sender, CommandEventArgs e)
    {
        ((ImageButton)sender).ImageUrl = "~/Images/upvote_pressed.png";
    }
}