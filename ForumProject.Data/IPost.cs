﻿using ForumProject.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumProject.Data
{
    public interface IPost
    {
        Post GetById();
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);

        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        Task AddREply(PostReply reply);

    }
}
