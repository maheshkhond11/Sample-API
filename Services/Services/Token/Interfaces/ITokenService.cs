
using Models.DBContext;

namespace ExtraEdgeAssignmentAPIs.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
