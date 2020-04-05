using Dapper;
using IPark.Service.Data;
using IPark.Service.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Ipark.Service.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly SqlConnection _connection;
        private readonly ParkContext _context;

        public GenericRepository(ParkContext context, SqlConnection connection) {
            _context = context;
            _connection = connection;
        }

        public virtual void Delete(int id)
        {
            try
            {
                _context.Remove(_context.Find<T>(id));
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual T Get(int id)
        {
            try
            {
                return _context.Find<T>(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                return _connection.GetList<T>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual T Insert(T t)
        {
            try
            {
                _context.Add(t);
                _context.SaveChanges();
                return t;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void Update(T t)
        {
            try
            {
                _context.Update(t);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

