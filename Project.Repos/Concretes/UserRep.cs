using Project.Dto;
using Project.Core;
using Project.Dal;
using Project.Entity.Concretes;
using Project.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repos.Concretes
{
    public class UserRep<T> : BaseRepository<Users>, IUserRep where T : class
    {
        ProjectContext _db;
      
        public UserRep(ProjectContext db) : base(db)
        {
            _db = db;
        }

    }
}
