using IPark.Domain;
using IPark.Service.Data;
using IPark.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Ipark.Service.Repository
{
    public class ClienteLocatarioRepository : GenericRepository<ClienteLocatario>, IClienteLocatarioRepository
    {
        private readonly SqlConnection _connection;
        protected ParkContext _context;

       public ClienteLocatarioRepository(ParkContext _context, SqlConnection _connection) : base(_context, _connection)
        {
            this._context = _context;
            this._connection = _connection;
        }
    }
}

