using System;
using WebApiOracleEFCore7.Application.Interfaces;

namespace WebApiOracleEFCore7.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}