using IPark.Domain;
using IPark.Service.Data;
using IPark.Service.Interfaces;
using Microsoft.Data.SqlClient;

namespace Ipark.Service.Repository
{
    public class VagaRepository : GenericRepository<Vaga>, IVagaRepository
    {
        private readonly SqlConnection _connection;
        protected ParkContext _context;

        public VagaRepository(ParkContext _context, SqlConnection _connection) : base(_context, _connection)
        {
            this._context = _context;
            this._connection = _connection;
        }
    }
}

