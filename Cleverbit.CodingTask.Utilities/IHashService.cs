using System.Threading.Tasks;

namespace Cleverbit.CodingTask.Utilities
{
    public interface IHashService
    {
        Task<string> HashText(string plainText);
    }
}
