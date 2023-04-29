using System.Collections.Generic;
using WebApiOracleEFCore7.Domain.Entities;

namespace WebApiOracleEFCore7.Application.Interfaces
{
    public interface IMockService
    {
        List<Position> GetPositions(int rowCount);

        List<Employee> GetEmployees(int rowCount);

        List<Position> SeedPositions(int rowCount);
    }
}