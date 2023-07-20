using System;
using System.Diagnostics.CodeAnalysis;

namespace Rezaee.Utils.Helpers
{
    internal static class ArgumentNullExceptionHelper
    {
        internal static void ThrowIfNull(string paramName)
        {
            if (paramName is null)
                throw new ArgumentNullException(paramName);
        }

        internal static void ThrowIfNull(string paramName, Exception innerException)
        {
            if (paramName is null)
                throw new ArgumentNullException(paramName, innerException);
        }

        internal static void ThrowIfNull(string paramName, string message)
        {
            if (paramName is null)
                throw new ArgumentNullException(paramName, message);
        }
    }
}
