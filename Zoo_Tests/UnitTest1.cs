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
        [Fact]
        public void CanParrotEat()
        {
            Parrot parrot = new Parrot();
            Assert.True(parrot.Eat());
        }
        [Fact]
        public void CanParrotSpeak()
        {
            Parrot parrot = new Parrot();
            Assert.True(parrot.Speak());
        }
        [Fact]
        public void CanLionEat()
        {
            Lion lion = new Lion();
            Assert.True(lion.Eat());
        }
        [Fact]
        public void CanLionSpeak()
        {
            Lion lion = new Lion();
            Assert.True(lion.Speak());
        }
    }
}
