using System.Globalization;
using Xunit;

namespace Rezaee.Utils.UnitTests
{
    public class NumbersTests
    {
        [Theory]
        [InlineData(1234567890, "۱۲۳۴۵۶۷۸۹۰")]
        public void TranslateDigits_IntegerToPersian_ReturnsPersianized(int input, string expected)
        {
            CultureInfo persian = new CultureInfo("fa-IR");

            string actual = input.TranslateDigits(to: persian);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("١٢٣٤٥٦٧٨٩٠", "1234567890")]
        public void TranslateDigits_ArabicToEnglish_ReturnsEnglishized(string input, string expected)
        {
            CultureInfo english = new CultureInfo("en-US");
            CultureInfo arabic = new CultureInfo("ar-sa");

            string actual = input.TranslateDigits(to: english, from: arabic);

            Assert.Equal(expected, actual);
        }
    }
}
