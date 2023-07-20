using System.Collections.Generic;
using System.Linq;

namespace Rezaee.Utils
{
    public static class Strings
    {
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
