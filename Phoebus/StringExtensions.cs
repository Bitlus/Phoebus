using System;
using System.Threading;

namespace Phoebus
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if all characters in the given string are alphabetical
        /// </summary>
        /// <param name="s"></param>
        /// <returns>True if all characters in the given string are alphabetical otherwise false</returns>
        public static bool IsAlphabetical(this string s)
        {
            var chars = s.AsSpan();
            foreach (var c in chars)
            {
                if (Char.IsLetter(c)) continue;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if all characters in the given string are alphanumeric
        /// </summary>
        /// <param name="s"></param>
        /// <returns>True if all the characters in the string are alphanumeric otherwise false</returns>
        public static bool IsAlphanumeric(this string s)
        {
            var chars = s.AsSpan();
            foreach (var c in chars)
            {
                if (Char.IsLetterOrDigit(c)) continue;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if all characters in the given string are numeric
        /// </summary>
        /// <param name="s"></param>
        /// <returns>True if all the characters in the string are numeric otherwise false</returns>
        public static bool IsNumeric(this string s)
        {
            var chars = s.AsSpan();
            foreach (var c in chars)
            {
                if (Char.IsDigit(c)) continue;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks that all the characters in the given string are in the given character set
        /// </summary>
        /// <param name="s"></param>
        /// <param name="characterSet">A string representing the character set</param>
        /// <returns>True if all the characters in the string are in the character set</returns>
        public static bool IsInCharacterSet(this string s, string characterSet)
        {
            var chars = s.AsSpan();
            foreach (var c in chars)
            {
                if (characterSet.Contains(c)) continue;
                return false;
            }

            return true;
        }
    }
}
