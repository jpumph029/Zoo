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
        [Fact]
        public void CanTigerEat()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.Eat());
        }
        [Fact]
        public void CanTigerSpeak()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.Speak());
        }
        [Fact]
        public void CanWhaleNotPlay()
        {
            Whale whale = new Whale();
            Assert.False(whale.Play());
        }
        [Fact]
        public void CanWhaleSpeak()
        {
            Whale whale = new Whale();
            Assert.True(whale.Speak());
        }
        [Fact]
        public void CanSeaLionEat()
        {
            SeaLion sealion = new SeaLion();
            Assert.True(sealion.Eat());
        }
        [Fact]
        public void CanSeaLionSpeak()
        {
            SeaLion sealion = new SeaLion();
            Assert.True(sealion.Speak());
        }
        [Fact]
        public void DoWhaleUseIswim()
        {
            Whale whale = new Whale();
            Assert.True(whale.Swim());
        }
        [Fact]
        public void CanWhaleStopSwimming()
        {
            Whale whale = new Whale();
            Assert.True(whale.Stop());
        }
        [Fact]
        public void WhaleIsAnimal()
        {
            Whale whale = new Whale();
            Assert.IsType<Whale>(whale);
        }
        [Fact]
        public void CanSeaLionUseIswim()
        {
            SeaLion sealion = new SeaLion();
            Assert.True(sealion.Swim());
        }
        [Fact]
        public void CanSeaLionStopSwimming()
        {
            SeaLion sealion = new SeaLion();
            Assert.True(sealion.Stop());
        }
        [Fact]
        public void SeaLionISAnimal()
        {
            SeaLion sealion = new SeaLion();
            Assert.IsType<SeaLion>(sealion);
        }
    }
}
