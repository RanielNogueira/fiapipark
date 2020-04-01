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
    public class VagaRepository : GenericRepository<Vaga>, IVagaRepository
    {
        protected ParkContext _connection;

       public VagaRepository(ParkContext _connection):base(_connection) {
           this._connection = _connection;
       }
    }
}

