
namespace Phoebus
{
    /// <summary>
    /// A static helper class with some useful character sets predefined
    /// </summary>
    public static class PhoebusCharSets
    {
        public const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        public const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string Numbers = "0123456789";
        public const string SpecialCharacters = "~!@#$%^&*()_+`-=[]\\{}|;':\",./<>?";
        public const string Alphabetical = LowerCase + UpperCase;
        public const string Alphanumeric = Alphabetical + Numbers;
    }
}


