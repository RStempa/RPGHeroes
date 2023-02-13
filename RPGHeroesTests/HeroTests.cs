using static System.Net.Mime.MediaTypeNames;
using RPGHeroes.Heroes;


namespace RPGHeroesTests
{
    public class HeroTests
    {

        #region Creation
        [Fact]
        public void Constructor_InitializeWithName_ShouldSetCorrectName()
        {
            // Arrange
            var name = "Alberto";
            var mage = new Mage(name);
            string expected = name;
            // Act
            string actual = mage.Name;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeWithName_ShouldSetCorrectLevel()
        {
            // Arrange
            var name = "Alberto";
            var mage = new Mage(name);
            int expected = 1;
            // Act
            int actual = mage.Level;
            // Assert
            Assert.Equal(expected, actual);
        }

        // test all creation items
        // test all levelattributes
        // test all level up attributes
        // test all add weapon
        // test all add armor
        // test all hero attributes after adding armor
        // test all damage outcomes
        // test all throws custom exceptions
        // test all display methods
        #endregion
    }
}