using IPark.Domain;
using IPark.Service.Data;
using IPark.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipark.Service.Repository
{
    public class ClienteLocatarioRepository : GenericRepository<ClienteLocatario>, IClienteLocatarioRepository
    {
        protected ParkContext _connection;

       public ClienteLocatarioRepository(ParkContext _connection):base(_connection) {
           this._connection = _connection;
       }
    }
}

