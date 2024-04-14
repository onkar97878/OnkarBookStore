﻿
using OnkarBooks.DataAccess.Repository.iRepository;
using OnkarBooks.DataAccess.Repository.IRepository;
using OnkarBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnkarBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {

            _db = db;

            Category = new CategoryRepository(_db);

            

            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
       

        public ISP_Call SP_Call { get; private set; }

        public object save => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}