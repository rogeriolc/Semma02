
namespace Semma02.Administration
{
    public interface IDirectoryService
    {
        DirectoryEntry Validate(string username, string password);
    }
}