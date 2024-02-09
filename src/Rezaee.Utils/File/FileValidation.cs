using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rezaee.Utils.File
{
    public static class FileValidation
    {
        public static FileValidationResult TryValidateFile(byte[] fileBytes, FileValidationOptions options, string filename = null, bool fastFail = true)
        {
            Assertions.ThrowIfNull(fileBytes, nameof(fileBytes));
            Assertions.ThrowIfNull(options, nameof(options));

            var result = new FileValidationResult();

            if (options.MinLength != null)
            {
                result.IsValidMinLength = fileBytes.Length >= options.MinLength;
                if (result.IsValidMinLength == false && fastFail)
                    return result;
            }

            if (options.MaxLength != null)
            {
                result.IsValidMaxLength = fileBytes.Length <= options.MaxLength;
                if (result.IsValidMaxLength == false && fastFail)
                    return result;
            }


            if (options.Extensions?.Any() ?? false)
            {
                if (!string.IsNullOrEmpty(filename))
                {
                    string extension = Path.GetExtension(filename);
                    result.IsValidExtension = options.Extensions.Contains(extension);
                }
                else
                    result.IsValidExtension = false;

                if (result.IsValidExtension == false && fastFail)
                    return result;

                if (options.GuessExtensions)
                {
                    if (fileBytes.Length > 0)
                    {
                        IEnumerable<string> guessExtensiones = FileContentType.GuessExtension(fileBytes);
                        result.IsValidGuessExtension = options.Extensions.Any(i => guessExtensiones.Contains(i));
                    }
                    else
                        result.IsValidGuessExtension = false;

                    if (result.IsValidGuessExtension == false && fastFail)
                        return result;
                }
            }

            if (options.MimeTypes?.Any() ?? false)
            {
                if (!string.IsNullOrEmpty(filename))
                {
                    string mimeType = FileContentType.GetMimeType(filename);
                    result.IsValidMimeType = options.MimeTypes.Contains(mimeType);
                }
                else
                    result.IsValidMimeType = false;

                if (result.IsValidMimeType == false && fastFail)
                    return result;

                if (options.GuessMimeTypes)
                {
                    if (fileBytes.Length > 0)
                    {
                        string guessMimeType = FileContentType.GuessMimeType(fileBytes);
                        result.IsValidGuessMimeType = options.MimeTypes.Contains(guessMimeType);
                    }
                    else
                        result.IsValidGuessMimeType = false;

                    if (result.IsValidGuessExtension == false && fastFail)
                        return result;
                }
            }

            return result;
        }
    }
}
