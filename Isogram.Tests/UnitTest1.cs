using System;
using Xunit;
using Isogram;


namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void String_empty()
        {
            bool actual = Class1.IsIsogram("");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void isogram()
        {
            bool actual = Class1.IsIsogram("isogram");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void eleven()
        {
            bool actual = Class1.IsIsogram("eleven");
            bool expected = false;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void subdermatoglyphic()
        {
            bool actual = Class1.IsIsogram("subdermatoglyphic");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Alphabet()
        {
            bool actual = Class1.IsIsogram("Alphabet");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void thumbscrewjapingly()
        {
            bool actual = Class1.IsIsogram("thumbscrew-japingly");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void sixyearold()
        {
            bool actual = Class1.IsIsogram("six-year-old");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void rahul()
        {
            bool actual = Class1.IsIsogram("r ah ul");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
    }
}
