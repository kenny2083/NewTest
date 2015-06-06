using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for JsonHandler
/// </summary>
public static class JsonHandler
{
	public static string GetJsonFromUrl(string url)
    {
        string json;
        using (var webClient = new System.Net.WebClient())
        {
            json = webClient.DownloadString(url);
        }

        return json;
    }

    public static List<Post> GetPosts(string url)
    {
        List<Post> posts = new List<Post>();

        string json = GetJsonFromUrl(url);

        dynamic things = JsonConvert.DeserializeObject(json);

        foreach (dynamic item in things.data.children)
        {
            Post post = new Post();
            post.Title = item.data.id;
            post.Title = item.data.title;
            post.IsSelf = item.data.is_self;
            if (post.IsSelf)
            {
                post.Thumbnail = "http://localhost:22457/Images/thumb_self_post.png";
            }
            else
            {
                post.Thumbnail = item.data.thumbnail;
            }
            post.ImageUrl = item.data.url;
            post.Score = item.data.score;
            post.Subreddit = item.data.subreddit;

            posts.Add(post);
        }


        return posts;
    }
}