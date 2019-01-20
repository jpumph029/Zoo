using System;
using Xunit;
using Zoo.Classes;

namespace Zoo_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanChickenNotEat()
        {
            Chicken chicken = new Chicken();
            Assert.False(chicken.Eat());
        }
        [Fact]
        public void CanChickenSpeak()
        {
            Chicken chicken = new Chicken();
            Assert.True(chicken.Speak());
        }
    }
}
