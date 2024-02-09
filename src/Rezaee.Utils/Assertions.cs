using System;
using System.Collections.Generic;
using System.Linq;

namespace Rezaee.Utils
{
    // see: https://codereview.stackexchange.com/a/284505
    public static class Assertions
    {
        public static void ThrowIf(this bool condition, Exception ex)
        {
            if (condition) throw ex;
        }

        public static void ThrowIfNull<T>(T argument, string paramName = null, string message = "Parameter cannot be null.") where T : class
              => (argument == null).ThrowIf(new ArgumentNullException(paramName, message));

        public static void ThrowIfNullOrEmpty(string argument, string paramName = null, string message = "String cannot be empty.")
        {
            ThrowIfNull(argument, paramName, message);
            string.IsNullOrEmpty(argument).ThrowIf(new ArgumentException(message, paramName));
        }

        public static void ThrowIfNullOrEmpty<T>(ICollection<T> argument, string paramName = null, string message = "Collection must have elements.")
            => (argument == null || !argument.Any()).ThrowIf(new ArgumentException(message, paramName));

        public static void ThrowIfNullOrEmpty<T>(T[] argument, string paramName = null, string message = "Array must have elements.")
            => (argument == null || argument.Length == 0).ThrowIf(new ArgumentException(message, paramName));

        public static void ThrowIfNullOrWhiteSpace(string argument, string paramName = null, string message = "String cannot be empty or whitespace.")
            => string.IsNullOrWhiteSpace(argument).ThrowIf(new ArgumentException(message, paramName));

        public static void ThrowIfOutOfRange<T>(T argument, T minValue, T maxValue, string paramName = null, string message = "Value must be within the specified range.") where T : IComparable<T>
            => (argument.CompareTo(minValue) < 0 || argument.CompareTo(maxValue) > 0).ThrowIf(new ArgumentOutOfRangeException(paramName, message));

        public static void ThrowIfLessThan<T>(T argument, T threshold, string paramName = null, string message = "Value must be greater than or equal to the threshold.") where T : IComparable<T>
            => (argument.CompareTo(threshold) < 0).ThrowIf(new ArgumentOutOfRangeException(paramName, message));

        public static void ThrowIfLessThanOrEqualTo<T>(T argument, T threshold, string paramName = null, string message = "Value must be greater than the threshold.") where T : IComparable<T>
            => (argument.CompareTo(threshold) <= 0).ThrowIf(new ArgumentOutOfRangeException(paramName, message));

        public static void ThrowIfGreaterThan<T>(T argument, T threshold, string paramName = null, string message = "Value must be less than the threshold.") where T : IComparable<T>
            => (argument.CompareTo(threshold) > 0).ThrowIf(new ArgumentOutOfRangeException(paramName, message));

        public static void ThrowIfGreaterThanOrEqualTo<T>(T argument, T threshold, string paramName = null, string message = "Value must be less than or equal to the threshold.") where T : IComparable<T>
            => (argument.CompareTo(threshold) >= 0).ThrowIf(new ArgumentOutOfRangeException(paramName, message));

        public static void ThrowIfEqual<T>(T argument, T target, string paramName = null, string message = "Parameter cannot be equal to its default value.")
            => EqualityComparer<T>.Default.Equals(argument, target).ThrowIf(new ArgumentException(message, paramName));
    }
}
