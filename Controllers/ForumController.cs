using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LambdaForums.Models;
using LambdaForums.Services;

namespace LambdaForums.Controllers
{
    public class ForumController:Controller
    {
        private readonly IForumServices _forumServices;
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
    }
}