using LambdaForums.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LambdaForums
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByForum(int Id);

        
        Task Add(Post post);
        Task Delete(int Id);
        Task EditPostContent(int id,string newContent);
        
    }
}