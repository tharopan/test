﻿using ABCRestaurant.Data.DBConn;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCRestaurant.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private RestaurantDBContext _dBConn;
        internal DbSet<T> dbSet;

        public Repository(RestaurantDBContext dBContext)
        {
            this._dBConn = dBContext;
            this.dbSet = dBContext.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public T FindById(int Id)
        {
            return dbSet.Find(Id);
        }

        public IEnumerable<T> List()
        {
            return dbSet.ToList();
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            _dBConn.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _dBConn.SaveChanges();
        }
    }
}
