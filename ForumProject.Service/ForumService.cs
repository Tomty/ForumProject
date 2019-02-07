using ForumProject.Data;
using ForumProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Service
{
    public class ForumService : IForum
    {
        ApplicationDbContext _context;

        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
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

        public Forum GetById(int id)
        {
            var forum = _context.Forums
                .Where(f => f.Id == id)
                .Include(f => f.Posts)
                    .ThenInclude(f => f.User)
                .Include(f => f.Posts)
                    .ThenInclude(p => p.PostReply)
                        .ThenInclude(r => r.User)
                .FirstOrDefault();

            return forum;
        }

        public Task UpdateDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
