using System.Collections.Generic;
using System.Threading.Tasks;

namespace SubmerchantAPI.Middlewares
{
    public interface ITokenManager
    {
        Task<bool> IsCurrentActiveToken();
        Task DeactivateCurrentAsync();
        Task<bool> IsActiveAsync(string token);
        Task DeactivateAsync(string token);
    }
}
