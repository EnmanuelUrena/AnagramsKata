using System;
using Xunit;
using Anagrams;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(AnagramCls.CheckAnagrams("moro","romo"));
        }
    }
}
