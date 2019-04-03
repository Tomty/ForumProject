using ForumProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumProject.Data
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();
        Task SetProfileImage(string id, Uri uri);
        Task IncrementRating(string id, Type type);
    }
}
