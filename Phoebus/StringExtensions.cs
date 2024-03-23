using System;

namespace Phoebus
{
    public static class StringExtensions
    {
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
