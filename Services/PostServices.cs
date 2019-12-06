using LambdaForums.Models;
using System;
using System.Linq;
using LambdaForums;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LambdaForums.Services
{
    public class PostServices:IPost
    {
        private readonly CommandContext _context;
        public PostServices(CommandContext context)
        {
            _context=context;
        }
       public Post GetById(int id)
       {
         return _context.Posts.Where(post=>post.Id==id)
               .Include(post=>post.User)
               .Include(post=>post.Replies).ThenInclude(reply=>reply.User)
               .Include(Post=>Post.Forum)
               .First();
       }
       public IEnumerable<Post> GetAll()
        {
           throw new NotImplementedException();
        }
       public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
           throw new NotImplementedException();
        }
        public Task Add(Post post)
        {
           throw new NotImplementedException();
        }
        public Task Delete(int Id)
        {
           throw new NotImplementedException();
        }
        public Task EditPostContent(int id,string newContent)
        {
           throw new NotImplementedException();
        }
        public IEnumerable<Post> GetPostsByForum(int Id)
        {
           return _context.Forums
                .Where(forum=>forum.Id==Id).First()
                    .Posts;
        }
    }
}