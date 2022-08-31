using Alsi.API.Entities;

namespace Alsi.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(GameUser user);
    }
}
