using Oracle.ManagedDataAccess.Client;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EnergyMonitoringAPI.Data
{
    public class OracleDbContext
    {
        private readonly string _connectionString;

        public OracleDbContext(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDb"); // Nome da string de conexão para o Oracle
        }

        // Método para criar e retornar uma conexão com o banco de dados Oracle
        public IDbConnection CreateConnection()
        {
            return new OracleConnection(_connectionString);
        }
    }
}
