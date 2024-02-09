using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Rezaee.Utils
{
    public static class Globalization
    {
        public static string TranslateDigits(this int num, CultureInfo to)
            => num.ToString().TranslateDigits(to, from: new CultureInfo("en-US"));

        public static string TranslateDigits(this string content, CultureInfo to, CultureInfo from)
        {
            Assertions.ThrowIfNull(content, nameof(content));
            Assertions.ThrowIfNull(to, nameof(to));
            Assertions.ThrowIfNull(from, nameof(from));

            if ((content?.Trim() == string.Empty) || (to == from))
                return content;

            IEnumerable<string> toDigits = to.NumberFormat.NativeDigits;
            IEnumerable<string> fromDigits = from.NumberFormat.NativeDigits;

            if (toDigits == fromDigits)
                return content;

            Dictionary<string, string> transferDict = Enumerable.Range(0, 10)
                .Select(i => new KeyValuePair<string, string>(
                    key: fromDigits.ElementAt(i),
                    value: toDigits.ElementAt(i)))
                .ToDictionary(x => x.Key, x => x.Value);

            return content.TransferUnicodes(transferDict);
        }

        public static string TransferUnicodes(this string content, Dictionary<string, string> dict)
        {
            if (string.IsNullOrEmpty(content))
                return content;

            IEnumerable<string> toTranslates = content.Distinct()
                .Select(@char => @char.ToString())
                .Where(@char => dict.Keys.Contains(@char));

            foreach (string toTranslate in toTranslates)
                content = content.Replace(toTranslate, dict[toTranslate]);

            return content;
        }
    }
}
