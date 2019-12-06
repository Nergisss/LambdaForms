using System;
using System.Collections.Generic;
using System.Text;
using LambdaForums.Models;

namespace LambdaForums.Models.Forums
{
    public class ForumIndexModel
    {
        public IEnumerable<ForumListingModel> ForumList{get;set;}
    }
}