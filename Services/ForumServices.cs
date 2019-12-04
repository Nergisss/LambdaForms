using LambdaForums.Models;
using System;
using System.Linq;
using LambdaForums;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LambdaForums.Services
{
    public class ForumServices:IForumServices
    {
        
       private readonly CommandContext _context;
       public ForumServices(CommandContext context)
       {
          _context=context;
       }

        public Forum GetById(int id)
        {
            throw new NotImplementedException();
        }
       public IEnumerable<Forum> GetAll()
        {
           return _context.Forums
                     .Include(forum => forum.Posts); 
        }
       public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
           throw new NotImplementedException(); 
        }
       public Task Create(Forum forum)
        {
           throw new NotImplementedException(); 
        }
       public Task Delete(int forumId)
        {
           throw new NotImplementedException(); 
        }
       public Task UpdateForumTitle(int forumId,string newTitle)
        {
           throw new NotImplementedException(); 
        }
       public Task UpdateForumDescription(int forumId,string newDescription)
        {
           throw new NotImplementedException(); 
        }

    }
}