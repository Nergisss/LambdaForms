using System;
using System.Collections.Generic;
using System.Text;
using LambdaForums.Models.Forums;
namespace LambdaForums.Models
{
    public class Forum
    {
        public int Id{get;set;}
        public string Title{get;set;}
        public string Description{get;set;}
        public DateTime Created{get;set;}
        public string ImageUrl{get;set;}

        public virtual IEnumerable<Post> Posts{get;set;}
    }
}