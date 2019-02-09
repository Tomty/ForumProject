using System.Collections.Generic;
using System.Linq;
using ForumProject.Data;
using ForumProject.Data.Models;
using ForumProject.Models.Post;
using ForumProject.Models.Reply;
using Microsoft.AspNetCore.Mvc;

namespace ForumProject.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;

        public PostController(IPost postService)
        {
            _postService = postService;   
        }

        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);

            var replies = BuildPostReplies(post.PostReply);

            var model = new PostIndexModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorImageUrl = post.User.ProfileImageUrl,
                AuthorRating = post.User.Rating,
                Created = post.Created,
                PostContent = post.Content,
                Replies = replies
            };

            return View(model);
        }

        private IEnumerable<PostReplyModel> BuildPostReplies(IEnumerable<PostReply> postReply)
        {
            return postReply.Select(reply => new PostReplyModel
            {
                Id = reply.Id,
                AuthorName = reply.User.UserName,
                AuthorId = reply.User.Id,
                AuthorImageUrl = reply.User.ProfileImageUrl,
                AuthorRating = reply.User.Rating,
                Created = reply.Created,
                ReplyContent = reply.Content
            });
        }
    }
}