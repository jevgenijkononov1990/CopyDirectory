

namespace CopyDirectory.Libs.Services.ValidationService
{
    public class ValidationService : IValidatinoService
    {
        public bool StringSimpleValidatino(string strToCheck)
        {
            if (string.IsNullOrWhiteSpace(strToCheck))
            {
                return false;
            }
            return true;
        }
    }
}
