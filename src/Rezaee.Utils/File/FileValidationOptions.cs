namespace Rezaee.Utils.File
{
    public class FileValidationOptions
    {
        public string[] Extensions { get; set; }
        public bool GuessExtensions { get; set; }
        public bool GuessMimeTypes { get; set; }
        public string[] MimeTypes { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
    }
}
