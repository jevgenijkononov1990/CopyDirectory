using CopyDirectory.Libs.Models;

namespace CopyDirectory.Libs.Services
{
    public interface ICopyService
    {
        (bool success, string error) CopyDirectory(string source, string target);
        (bool success, string error) CopyOnlyFile(string source, string target);
        (bool success, string error) Copy(CopySettings copySettings);
        (bool success, string error) Copy(string source, string target, CopyItem Item);
    }
}
