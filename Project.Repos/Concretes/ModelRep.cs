﻿using Project.Core;
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
    public class ModelRep<T> : BaseRepository<Model>, IModelRep where T : class
    {
        public ModelRep(ProjectContext db) : base(db)
        {
        }
    }
}
