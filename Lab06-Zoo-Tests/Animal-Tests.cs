
using Xunit;
using Lab06_Zoo.Classes;

namespace Lab06_Zoo.Tests
{
    public class BabySealTests
    {
        [Fact]
        public void BabySeal_NumOfLegs_ReturnsCorrectNumOfLegs()
        {
            // Arrange
            BabySeal babySeal = new BabySeal();

            // Act
            int actualNumOfLegs = babySeal.NumOfLegs;

            // Assert
            Assert.Equal(0, actualNumOfLegs);
        }

        [Fact]
        public void BabySeal_Sound_ReturnsCorrectSound()
        {
            // Arrange
            BabySeal babySeal = new BabySeal();

            // Act
            string actualSound = babySeal.Sound;

            // Assert
            Assert.Equal("bark", actualSound);
        }

    }

    public class LionTests
    {
        [Fact]
        public void Lion_NumOfLegs_ReturnsCorrectNumOfLegs()
        {
            // Arrange
            Lion lion = new Lion();

            // Act
            int actualLegs = lion.NumOfLegs;

            // Assert
            Assert.Equal(4, actualLegs);
        }

        [Fact]
        public void Lion_Sound_ReturnsCorrectSound()
        {
            // Arrange
            Lion lion = new Lion();

            // Act
            string actualSound = lion.Sound;

            // Assert
            Assert.Equal("roar", actualSound);
        }
    }
    public class SnakeTests
    {
        [Fact]
        public void Snake_NumOfLegs_ReturnsCorrectNumOfLegs()
        {
            // Arrange
            Snake snake = new Snake();

            // Act
            int actualLegs = snake.NumOfLegs;

            // Assert
            Assert.Equal(0, actualLegs);
        }

        [Fact]
        public void Snake_Sound_ReturnsCorrectSound()
        {
            // Arrange
            Snake snake  = new Snake();

            // Act
            string actualSound = snake.Sound;

            // Assert
            Assert.Equal("hisssss", actualSound);
        }

    }
    public class GiraffeTests
    {
        [Fact]
        public void Giraffe_NumOfLegs_ReturnsCorrectNumOfLegs()
        {
            // Arrange
            Giraffe giraffe = new Giraffe();

            // Act
            int actualLegs = giraffe.NumOfLegs;

            // Assert
            Assert.Equal(4, actualLegs);
        }

        [Fact]
        public void Giraffe_Sound_ReturnsCorrectSound()
        {
            // Arrange
            Giraffe giraffe = new Giraffe();

            // Act
            string actualSound = giraffe.Sound;

            // Assert
            Assert.Equal("silence", actualSound);
        }

    }
    public class RavenTests
    {
        [Fact]
        public void Raven_NumOfLegs_ReturnsCorrectNumOfLegs()
        {
            // Arrange
           Raven raven = new Raven();

            // Act
            int actualLegs = raven.NumOfLegs;

            // Assert
            Assert.Equal(2, actualLegs);
        }

        [Fact]
        public void Raven_Sound_ReturnsCorrectSound()
        {
            // Arrange
            Raven raven = new Raven();

            // Act
            string actualSound = raven.Sound;

            // Assert
            Assert.Equal("cawww", actualSound);
        }

    }

}
