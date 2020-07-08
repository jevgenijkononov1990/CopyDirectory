using CopyDirectory.Libs.Models;

namespace CopyDirectory.Libs.Services
{
    public interface ICopyService
    {
        (bool success, string error) CopyDirectory(string source, string target);
        (bool succes, string error) CopyOnlyFile(string source, string target);
        (bool succes, string error) Copy(CopySettings copySettings);
        (bool succes, string error) Copy(string source, string target, CopyItem Item);
    }
}
