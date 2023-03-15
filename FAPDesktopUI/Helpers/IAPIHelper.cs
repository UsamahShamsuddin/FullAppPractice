using FAPDesktopUI.Models;
using System.Threading.Tasks;

namespace FAPDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}