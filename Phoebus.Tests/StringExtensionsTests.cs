using Phoebus;

namespace Phoebus.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void StringIsAlpha()
        {
            var test = "test";
            Assert.True(test.IsAlphabetical());
        }

        [Fact]
        public void StringIsNotAlpha()
        {
            var test = "test123%%";
            Assert.False(test.IsAlphabetical());
        }

        [Fact]
        public void StringHasSpaces()
        {
            var test = "I have spaces";
            Assert.False(test.IsAlphabetical());
        }

        [Fact]
        public void StringIsAlphaNumeric()
        {
            var test = "test123";
            Assert.True(test.IsAlphanumeric());
        }

        [Fact]
        public void StringIsNotAlphaNumeric()
        {
            var test = "test123%%";
            Assert.False(test.IsAlphanumeric());
        }

        [Fact]
        public void StringIsNumeric()
        {
            var test = "123";
            Assert.True(test.IsNumeric());
        }

        [Fact]
        public void StringIsNotNumeric()
        {
            var test = "123%%";
            Assert.False(test.IsNumeric());
        }

        [Fact]
        public void StringIsInCharacterSet()
        {
            var test = "test";
            var characterSet = "tes";
            Assert.True(test.IsInCharacterSet(characterSet));
        }

        [Fact]
        public void StringIsNotInCharacterSet()
        {
            var test = "test";
            var characterSet = "abc";
            Assert.False(test.IsInCharacterSet(characterSet));
        }
    }
}
