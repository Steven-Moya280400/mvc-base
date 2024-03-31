using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.DAL.Core
{
    public abstract class BaseRepositorio
    {
        private readonly IConfiguration _configuration;

        protected BaseRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected IDbConnection CrearConexionConBD()
        {
            return new SqlConnection(_configuration.GetConnectionString("Connenction"));
        }
    }
}
}
