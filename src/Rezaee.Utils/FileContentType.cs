using System.IO;
using HeyRed.Mime;
using MimeTypes;

namespace Rezaee.Utils
{
    public static class FileContentType
    {
        public static string GetExtension(string mimeType)
            => MimeTypeMap.GetExtension(mimeType);


        public static string GetMimeType(string filename)
        {
            string extension = Path.GetExtension(filename);
            return MimeTypeMap.GetMimeType(extension);
        }


        public static FileType GuessFileType(byte[] fileBytes)
            => MimeGuesser.GuessFileType(fileBytes);

        public static FileType GuessFileType(FileInfo fileInfo)
            => MimeGuesser.GuessFileType(fileInfo);

        public static FileType GuessFileType(Stream stream)
            => MimeGuesser.GuessFileType(stream);

        public static FileType GuessFileType(string filepath)
            => MimeGuesser.GuessFileType(filepath);


        public static string GuessExtension(byte[] fileBytes)
            => MimeGuesser.GuessExtension(fileBytes);

        public static string GuessExtension(FileInfo fileInfo)
            => MimeGuesser.GuessExtension(fileInfo);

        public static string GuessExtension(Stream stream)
            => MimeGuesser.GuessExtension(stream);

        public static string GuessExtension(string filepath)
            => MimeGuesser.GuessExtension(filepath);


        public static string GuessMimeType(byte[] fileBytes)
            => MimeGuesser.GuessMimeType(fileBytes);

        public static string GuessMimeType(FileInfo fileInfo)
            => MimeGuesser.GuessMimeType(fileInfo);

        public static string GuessMimeType(Stream stream)
            => MimeGuesser.GuessMimeType(stream);

        public static string GuessMimeType(string filepath)
            => MimeGuesser.GuessMimeType(filepath);
    }
}
