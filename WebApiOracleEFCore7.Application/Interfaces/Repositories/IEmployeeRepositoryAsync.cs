using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiOracleEFCore7.Application.Features.Employees.Queries.GetEmployees;
using WebApiOracleEFCore7.Application.Parameters;
using WebApiOracleEFCore7.Domain.Entities;

namespace WebApiOracleEFCore7.Application.Interfaces.Repositories
{
    /// <summary>
    /// Interface for retrieving paged employee response asynchronously.
    /// </summary>
    /// <param name="requestParameters">The request parameters.</param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// </returns>
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeResponseAsync(GetEmployeesQuery requestParameters);
    }
}