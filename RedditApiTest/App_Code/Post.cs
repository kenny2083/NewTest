using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Post
/// </summary>
public class Post
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int Score { get; set; }
    public string Thumbnail { get; set; }
    public string ImageUrl { get; set; }
    public string Subreddit { get; set; }
    public bool IsSelf { get; set; }
}