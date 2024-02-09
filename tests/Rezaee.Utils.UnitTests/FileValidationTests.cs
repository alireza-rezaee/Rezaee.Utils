using Rezaee.Utils.File;
using Rezaee.Utils.UnitTests.ClassData;
using UnitsNet;
using Xunit;

namespace Rezaee.Utils.UnitTests
{
    // see similar mime-types: https://mimetype.io/all-types
    public class FileValidationTests
    {
        [Theory]
        [ClassData(typeof(SmallImageFilesValidationClassData))]
        public void FileValidation_SmallImageFiles_AreValid(byte[] fileBytes, string filename)
        {
            var options = new FileValidationOptions
            {
                MinLength = 1,
                MaxLength = (int)Information.FromKibibytes(10).Bytes,
                Extensions = new string[] { ".bmp", ".gif", ".jpeg", ".jpg", ".png", ".tif", ".tiff" },
                MimeTypes = new string[] { "image/bmp", "image/gif", "image/jpeg", "image/png", "image/tiff" },
                GuessExtensions = true,
                GuessMimeTypes = true
            };

            FileValidationResult actual = FileValidation.TryValidateFile(fileBytes, options, filename);

            Assert.True(actual.IsValid);
        }

        [Theory]
        [ClassData(typeof(SmallCompressedFilesValidationClassData))]
        public void FileValidation_SmallCompressedFiles_AreValid(byte[] fileBytes, string filename)
        {
            var options = new FileValidationOptions
            {
                MinLength = 1,
                MaxLength = (int)Information.FromKibibytes(10).Bytes,
                Extensions = new string[] { ".7z", ".bz2", ".gz", ".jar", ".rar", ".tar", ".zip"},
                MimeTypes = new string[]
                {
                    "application/x-7z-compressed", "application/x-bzip2", "application/gzip",
                    "application/java-archive", "application/vnd.rar", "application/x-rar", "application/x-tar", "application/zip"
                },
                GuessExtensions = true,
                GuessMimeTypes = true
            };

            FileValidationResult actual = FileValidation.TryValidateFile(fileBytes, options, filename);

            Assert.True(actual.IsValid);
        }

        [Theory]
        [ClassData(typeof(SmalDocumentFilesValidationClassData))]
        public void FileValidation_SmallDocumentFiles_AreValid(byte[] fileBytes, string filename)
        {
            var options = new FileValidationOptions
            {
                MinLength = 1,
                MaxLength = (int)Information.FromKibibytes(40).Bytes,
                Extensions = new string[]
                {
                    ".pdf", ".doc", ".docx", ".dotx", ".doc", ".dot", ".wiz",
                    ".xls", ".xlsx", ".xlsm", ".xltm", ".xlsb", ".xlam", ".xla", ".xlb", ".xlc", ".xlm", ".xls", ".xlt", ".xlw", ".xltx",
                    ".pptx", ".pptm", ".pot", ".ppa", ".pps", ".ppt", ".pwz",
                },
                MimeTypes = new string[]
                {
                    "application/pdf",
                    "application/vnd.ms-excel",
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "application/vnd.ms-excel.addin.macroenabled.12",
                    "application/vnd.ms-excel.sheet.binary.macroenabled.12",
                    "application/vnd.ms-excel.sheet.macroenabled.12",
                    "application/vnd.ms-excel.template.macroenabled.12",
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.template",
                    "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                    "application/vnd.ms-powerpoint.presentation.macroenabled.12",
                    "application/vnd.ms-powerpoint",
                    "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                    "application/vnd.openxmlformats-officedocument.wordprocessingml.template",
                    "application/msword"
                },
                GuessExtensions = true,
                GuessMimeTypes = true
            };

            FileValidationResult actual = FileValidation.TryValidateFile(fileBytes, options, filename);

            Assert.True(actual.IsValid);
        }
    }
}
