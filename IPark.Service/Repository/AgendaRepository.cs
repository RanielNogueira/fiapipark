using IPark.Domain;
using IPark.Service.Data;
using IPark.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Ipark.Service.Repository
{
    public class AgendaRepository : GenericRepository<Agenda>,IAgendaRepository
    {
        private SqlConnection _connection;
        protected ParkContext _context;

        public AgendaRepository(ParkContext _context, SqlConnection _connection) : base(_context, _connection)
        {
            this._context = _context;
            this._connection = _connection;
        }
    }
}

