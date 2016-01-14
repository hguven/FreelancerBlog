﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebFor.Repositories
{
    public interface IRepository<T, in TKey> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        T FindById(TKey id);
        IEnumerable<T> GetAll();

        //void Update(T entity); redundant, Unit Of Work will handle it
        //void Save(); redundant, redundant, Unit Of Work will handle it
        //IQueryable<T> Find(Expression<Func<T, bool>> predicate); too generic, hard to implement for other providers
    }
}