namespace Rezaee.Utils.File
{
    public class FileValidationResult
    {
        public bool? IsValidExtension { get; set; }
        public bool? IsValidGuessExtension { get; set; }
        public bool? IsValidGuessMimeType { get; set; }
        public bool? IsValidMimeType { get; set; }
        public bool? IsValidMaxLength { get; set; }
        public bool? IsValidMinLength { get; set; }

        public bool IsValid
            => !(IsValidExtension == false
            || IsValidGuessExtension == false
            || IsValidGuessMimeType == false
            || IsValidMimeType == false
            || IsValidMaxLength == false
            || IsValidMinLength == false);
    }
}
