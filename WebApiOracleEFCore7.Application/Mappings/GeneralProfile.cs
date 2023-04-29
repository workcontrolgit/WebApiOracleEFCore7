using AutoMapper;
using WebApiOracleEFCore7.Application.Features.Employees.Queries.GetEmployees;
using WebApiOracleEFCore7.Application.Features.Positions.Commands.CreatePosition;
using WebApiOracleEFCore7.Application.Features.Positions.Queries.GetPositions;
using WebApiOracleEFCore7.Domain.Entities;

namespace WebApiOracleEFCore7.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}