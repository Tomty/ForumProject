using ForumProject.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Home
{
    public class HomeIndexModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<PostListingModel> LatestPosts { get; set; }
    }
}
