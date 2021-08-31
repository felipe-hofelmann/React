﻿using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<T> where T:Base
    {
        public void Create(T model) 
        {
            using (var context = new ProductContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public List<T> Read()
        {
            using (var context = new ProductContext())
            {
                return context.Set<T>().ToList();
            }
        }
        public T Read(int id)
        {
            using (var context = new ProductContext())
            {
                return context.Set<T>().Find(id);
            }
        }
        public void Update(T model)
        {
            using (var context = new ProductContext())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new ProductContext())
            {
                context.Entry<T>(this.Read(id)).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
