using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LambdaForums.Models.Posts;
using LambdaForums.Services;
using LambdaForums.Models;
using LambdaForums.Models.Forums;

namespace LambdaForums.Controllers
{
    public class PostController:Controller
    {
        private readonly IPost _postService;
        public PostController(IPost postService)
        {
            _postService=postService;
        }
        public IActionResult Index(int id)
        {
            var post=_postService.GetById(id);
            var replies=BuildPostReplies(post.Replies);
            var model=new PostIndexModel
            {   
                Id=post.Id,
                Title=post.Title,
                AuthorId=post.User.Id,
                AuthorName=post.User.UserName,
                AuthorImageUrl=post.User.ProfileImageUrl,
                AuthorRating=post.User.Rating,
                Created=post.Created,
                PostContent=post.Content,
                Replies=replies
            };
            return View(model);
        }
        private IEnumerable<PostReplyModel> BuildPostReplies(IEnumerable<PostReply> replies)
        {
            return replies.Select(reply=>new PostReplyModel
            {
                Id=reply.Id,
                AuthorName=reply.User.UserName,
                AuthorId=reply.User.Id,
                AuthorImageUrl=reply.User.ProfileImageUrl,
                AuthorRating=reply.User.Rating,
                Created=reply.Created,
                ReplyContent=reply.Content

            });
        }
    }
}