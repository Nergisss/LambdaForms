using System;
using System.Collections.Generic;
using System.Text;
using LambdaForums.Models;
using LambdaForums.Models.Posts;

namespace LambdaForums.Models.Forums
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum{get;set;}
        public IEnumerable<PostListingModel> Posts {get;set;}
    }
}