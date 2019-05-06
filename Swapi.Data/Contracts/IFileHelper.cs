using System.Threading.Tasks;

namespace Swapi.Data.Contracts
{
    public interface IFileHelper
    {
        Task<bool> SaveFile(string path, string name, string content);
    }
}
