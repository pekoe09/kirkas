﻿using kirkas.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace kirkas.Core.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
    }
}
