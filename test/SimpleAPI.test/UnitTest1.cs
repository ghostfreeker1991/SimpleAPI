using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnvalue = controller.Get(1);
            Assert.Equal("Matt Teves", returnvalue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
