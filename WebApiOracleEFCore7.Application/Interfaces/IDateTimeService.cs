using System;

namespace WebApiOracleEFCore7.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}