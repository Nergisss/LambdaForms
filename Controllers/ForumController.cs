using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LambdaForums.Models.Posts;
using LambdaForums.Services;
using LambdaForums.Models;

namespace LambdaForums.Controllers
{
    public class ForumController:Controller
    {
        private readonly IForumServices _forumServices;
        private readonly IPost _postServices;
        public ForumController(IForumServices forumServices)
        {
            _forumServices=forumServices;
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
            var forum=_forumServices.GetById(Id);
            //var posts=_postServices.GetFilteredPosts(ıd);
            //var postListings=
            return View();
        }
    
    }
}