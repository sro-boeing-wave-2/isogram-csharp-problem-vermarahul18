using System;
using Xunit;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void String_empty()
        {
            bool actual = IsIsogram.IsIso("");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void isogram()
        {
            bool actual = IsIsogram.IsIso("isogram");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void eleven()
        {
            bool actual = IsIsogram.IsIso("eleven");
            bool expected = false;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void subdermatoglyphic()
        {
            bool actual = IsIsogram.IsIso("subdermatoglyphic");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Alphabet()
        {
            bool actual = IsIsogram.IsIso("Alphabet");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void thumbscrewjapingly()
        {
            bool actual = IsIsogram.IsIso("thumbscrew-japingly");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void sixyearold()
        {
            bool actual = IsIsogram.IsIso("six-year-old");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void rahul()
        {
            bool actual = IsIsogram.IsIso("r ah ul");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
    }
}
