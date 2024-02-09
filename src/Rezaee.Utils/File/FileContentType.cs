using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HeyRed.Mime;

namespace Rezaee.Utils.File
{
    public static class FileContentType
    {
        public static IEnumerable<string> GetExtensions(string mimeType)
            => MimeTypes.GetMimeTypeExtensions(mimeType);

        public static string GetMimeType(string filename)
            => MimeTypes.GetMimeType(filename);

        #region GuessFileType (based on magiclib)
        public static FileType GuessFileType(byte[] fileBytes)
            => MimeGuesser.GuessFileType(fileBytes);

        public static FileType GuessFileType(FileInfo file)
            => MimeGuesser.GuessFileType(file);

        public static FileType GuessFileType(Stream stream)
            => MimeGuesser.GuessFileType(stream);

        public static FileType GuessFileType(string filepath)
            => MimeGuesser.GuessFileType(filepath);
        #endregion

        #region GuessExtension (based on magiclib)
        public static IEnumerable<string> GuessExtension(byte[] fileBytes)
        {
            using (var magic = new Magic(MagicOpenFlags.MAGIC_EXTENSION))
            {
                string result = magic.Read(fileBytes, fileBytes.Length);
                var a = string.IsNullOrEmpty(result)
                    ? Array.Empty<string>()
                    : result.Split('/').Select(i => i.StartsWith(".") ? i : $".{i}");
                return a;
            }
        }

        public static IEnumerable<string> GuessExtension(FileInfo file)
            => GuessExtension(file.FullName);

        public static IEnumerable<string> GuessExtension(Stream stream)
        {
            using (var magic = new Magic(MagicOpenFlags.MAGIC_EXTENSION))
            {
                int streamLength = stream.Length < int.MaxValue ? (int)stream.Length : int.MaxValue;
                string result = magic.Read(stream, streamLength);
                return string.IsNullOrEmpty(result)
                    ? Array.Empty<string>()
                    : result.Split('/').Select(ext => ext.StartsWith(".") ? ext : $".{ext}");
            }
        }

        public static IEnumerable<string> GuessExtension(string filepath)
        {
            using (var magic = new Magic(MagicOpenFlags.MAGIC_EXTENSION))
            {
                string result = magic.Read(filepath);
                return string.IsNullOrEmpty(result)
                    ? Array.Empty<string>()
                    : result.Split('/').Select(i => i.StartsWith(".") ? i : $".{i}");
            }
        }
        #endregion

        #region GuessMimeType (based on magiclib)
        public static string GuessMimeType(byte[] fileBytes)
            => MimeGuesser.GuessMimeType(fileBytes);

        public static string GuessMimeType(FileInfo file)
            => MimeGuesser.GuessMimeType(file);

        public static string GuessMimeType(Stream stream)
            => MimeGuesser.GuessMimeType(stream);

        public static string GuessMimeType(string filepath)
            => MimeGuesser.GuessMimeType(filepath);
        #endregion
    }
}
