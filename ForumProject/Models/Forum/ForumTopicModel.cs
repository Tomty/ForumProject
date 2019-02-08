﻿using ForumProject.Models.Forum;
using ForumProject.Models.Post;
using System.Collections.Generic;

namespace ForumProject.Models.Forum
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum{ get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
    }
}