using IPark.Domain;
using IPark.Service.Data;
using IPark.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace Ipark.Service.Repository
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly SqlConnection _connection;
        protected ParkContext _context;

       public ClienteRepository(ParkContext _context, SqlConnection _connection) : base(_context, _connection)
        {
            this._context = _context;
            this._connection = _connection;
        }

        public override IEnumerable<Cliente> GetAll()
        {
            return _context.Cliente.ToList();
        }
    }
}

