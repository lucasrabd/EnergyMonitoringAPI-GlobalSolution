using System.Collections.Generic;
using System.Threading.Tasks;
using EnergyMonitoringAPI.Models;
using EnergyMonitoringAPI.Data;
using Dapper; // Biblioteca para interações com SQL simplificadas
using System.Linq;

namespace EnergyMonitoringAPI.Repositories
{
    public class EnergyRepository : IEnergyRepository
    {
        private readonly OracleDbContext _context;

        public EnergyRepository(OracleDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EnergyProduction>> GetAllAsync()
        {
            using (var connection = _context.CreateConnection())
            {
                string sql = "SELECT * FROM EnergyProductions";
                var result = await connection.QueryAsync<EnergyProduction>(sql);
                return result.ToList();
            }
        }

        public async Task<EnergyProduction> GetByIdAsync(string id)
        {
            using (var connection = _context.CreateConnection())
            {
                string sql = "SELECT * FROM EnergyProductions WHERE Id = :Id";
                var result = await connection.QueryFirstOrDefaultAsync<EnergyProduction>(sql, new { Id = id });
                return result;
            }
        }

        public async Task AddAsync(EnergyProduction production)
        {
            using (var connection = _context.CreateConnection())
            {
                string sql = @"
                    INSERT INTO EnergyProductions (Id, Source, Timestamp, Production, Temperature, WindSpeed, SolarRadiation)
                    VALUES (:Id, :Source, :Timestamp, :Production, :Temperature, :WindSpeed, :SolarRadiation)";
                await connection.ExecuteAsync(sql, production);
            }
        }

        public async Task UpdateAsync(EnergyProduction production)
        {
            using (var connection = _context.CreateConnection())
            {
                string sql = @"
                    UPDATE EnergyProductions 
                    SET Source = :Source, 
                        Timestamp = :Timestamp, 
                        Production = :Production,
                        Temperature = :Temperature, 
                        WindSpeed = :WindSpeed, 
                        SolarRadiation = :SolarRadiation
                    WHERE Id = :Id";
                await connection.ExecuteAsync(sql, production);
            }
        }

        public async Task DeleteAsync(string id)
        {
            using (var connection = _context.CreateConnection())
            {
                string sql = "DELETE FROM EnergyProductions WHERE Id = :Id";
                await connection.ExecuteAsync(sql, new { Id = id });
            }
        }
    }
}
