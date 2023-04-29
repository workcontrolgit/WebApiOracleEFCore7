using System.Threading.Tasks;
using WebApiOracleEFCore7.Application.DTOs.Email;

namespace WebApiOracleEFCore7.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}