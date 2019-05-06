using System.Threading.Tasks;

namespace Swapi.Data.Contracts
{
    public interface IHttpHelper
    {
        Task<string> GetJsonResponse(string entity, int id);
    }
}
