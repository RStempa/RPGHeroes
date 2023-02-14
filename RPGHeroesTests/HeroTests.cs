using static System.Net.Mime.MediaTypeNames;
using RPGHeroes;
using RPGHeroes.Heroes;


namespace RPGHeroesTests
{
    public class HeroTests
    {

        #region Constructors
        [Fact]
        public void Constructor_InitializeMageWithName_ShouldSetCorrectName()
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
        public void Constructor_InitializeRangerWithName_ShouldSetCorrectName()
        {
            // Arrange
            var name = "Alberto";
            var ranger = new Ranger(name);
            string expected = name;
            // Act
            string actual = ranger.Name;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeRogueWithName_ShouldSetCorrectName()
        {
            // Arrange
            var name = "Alberto";
            var rogue = new Rogue(name);
            string expected = name;
            // Act
            string actual = rogue.Name;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeWarriorWithName_ShouldSetCorrectName()
        {
            // Arrange
            var name = "Alberto";
            var warrior = new Warrior(name);
            string expected = name;
            // Act
            string actual = warrior.Name;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_Initialize_ShouldSetCorrectLevel()
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

        [Fact]
        public void Constructor_InitializeMage_ShouldSetCorrectAttributes()
        {
            // Arrange
            Mage mage = new("Alberto");
            HeroAttributes expected = new(1, 1, 8);
            // Act
            HeroAttributes actual = mage.LevelAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeRanger_ShouldSetCorrectAttributes()
        {
            // Arrange
            Ranger ranger = new("Alberto");
            HeroAttributes expected = new(1, 7, 1);
            // Act
            HeroAttributes actual = ranger.LevelAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeRogue_ShouldSetCorrectAttributes()
        {
            // Arrange
            Rogue rogue = new("Alberto");
            HeroAttributes expected = new(2, 6, 1);
            // Act
            HeroAttributes actual = rogue.LevelAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeWarrior_ShouldSetCorrectAttributes()
        {
            // Arrange
            Warrior warrior = new("Alberto");
            HeroAttributes expected = new(5, 2, 1);
            // Act
            HeroAttributes actual = warrior.LevelAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region LevelUp

        [Fact]
        public void Method_LevelUpMage_ShouldSetCorrectAttributes()
        {
            // Arrange
            Mage mage = new("Alberto");
            HeroAttributes expected = new(2, 2, 13);
            // Act
            mage.LevelUp();
            HeroAttributes actual = mage.LevelAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Method_LevelUpRanger_ShouldSetCorrectAttributes()
        {
            // Arrange
            Ranger ranger = new("Alberto");
            HeroAttributes expected = new(2, 12, 2);
            // Act
            ranger.LevelUp();
            HeroAttributes actual = ranger.LevelAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Method_LevelUpRogue_ShouldSetCorrectAttributes()
        {
            // Arrange
            Rogue rogue = new("Alberto");
            HeroAttributes expected = new(3, 10, 2);
            // Act
            rogue.LevelUp();
            HeroAttributes actual = rogue.LevelAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Method_LevelUpWarrior_ShouldSetCorrectAttributes()
        {
            // Arrange
            Warrior warrior = new("Alberto");
            HeroAttributes expected = new(8, 4, 2);
            // Act
            warrior.LevelUp();
            HeroAttributes actual = warrior.LevelAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        // test all constructors hero
        // test all level up attributes
        //----------------------------------
        // test all levelattributes
        // test all add weapon
        // test all add armor
        // test all hero attributes after adding armor
        // test all damage outcomes
        // test all throws custom exceptions
        // test all display methods

    }
}