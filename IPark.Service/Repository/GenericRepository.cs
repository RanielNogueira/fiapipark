using IPark.Service.Data;
using IPark.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Ipark.Service.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ParkContext _connection;

        public GenericRepository(ParkContext connection) {
            this._connection = connection;
        }

        public virtual void Delete(int id)
        {
            try
            {
                _connection.Remove(_connection.Find<T>(id));
                _connection.SaveChanges();
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
                return _connection.Find<T>(id);
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
                return _connection.Query<T>();
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
                _connection.Add(t);
                _connection.SaveChanges();
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
                _connection.Update(t);
                _connection.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

