using ForumProject.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumProject.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int id);
        Task UpdateTitle(int forumId, string newTitle);
        Task UpdateDescription(int forumId, string newDescription);

    }
}
