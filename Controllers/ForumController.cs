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
    public class ForumController:Controller
    {
        private readonly IForumServices _forumServices;
        private readonly IPost _postServices;
        public ForumController(IForumServices forumServices,IPost postServices)
        {
            _forumServices=forumServices;
            _postServices=postServices;
        }
        public IActionResult Index()
        {
            var forums=_forumServices.GetAll()
                        .Select(forum=>new ForumListingModel{
                        Id=forum.Id,
                        Name=forum.Title,
                        Description=forum.Description});

            var model=new ForumIndexModel
            {
                ForumList= forums
            };

                return View(model);
        }

        public IActionResult Topic(int Id)
        {
            var forum = _forumServices.GetById(Id);
            var posts = forum.Posts;
            var postListings = posts.Select(post => new PostListingModel
            {
                Id=post.Id,
                AuthorId=post.User.Id,
                AuthorRating=post.User.Rating,
                Title=post.Title,
                DatePosted=post.Created.ToString(),
                RepliesCount=post.Replies.Count(),
                Forum=BuildForumListing(post)

            });
            var model=new ForumTopicModel
            {
                Posts=postListings,
                Forum=BuildForumListing(forum)
            };
            return View(model);
        }
        private ForumListingModel BuildForumListing(Post post)
        {
            var forum=post.Forum;
           return BuildForumListing(forum);
        }
        private ForumListingModel BuildForumListing(Forum forum)
        {
            
            return new ForumListingModel
            {
                Id=forum.Id,
                Name=forum.Title,
                Description=forum.Description,
                ImageUrl=forum.ImageUrl

            };
        }
    
    }
}