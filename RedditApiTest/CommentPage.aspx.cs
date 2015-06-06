using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommentPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UpdatePageTitle("Comments");
        }
    }

    public void UpdatePageTitle(string title)
    {
        LabelTitle.Text = title;
    }
}