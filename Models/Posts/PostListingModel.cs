using System;
using System.Collections.Generic;
using System.Text;
using LambdaForums.Models;
using LambdaForums.Models.Forums;

namespace LambdaForums.Models.Posts
{
    public class PostListingModel
    {
        public int Id{get;set;}
        public string Title{get;set;}
        public string AuthorName{get;set;}
        public int AuthorRating{get;set;}
        public string AuthorId{get;set;}
        public string DatePosted{get;set;}

        public ForumListingModel Forum{get;set;}

       /* public int ForumId{get;set;}
        public string ForumImageUrl {get;set;} 
        public string ForumName {get;set;} */
        public int RepliesCount{get;set;}

    }
}