using static System.Net.Mime.MediaTypeNames;
using RPGHeroes;
using RPGHeroes.Heroes;
using RPGHeroes.Items;
using RPGHeroes.Exceptions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

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
        public void Method_LevelUpMage_ShouldSetCorrectLevel()
        {
            // Arrange
            // Arrange
            Mage mage = new("Alberto");
            int expected = 2;
            // Act
            mage.LevelUp();
            int actual = mage.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Method_LevelUpRanger_ShouldSetCorrectLevel()
        {
            // Arrange
            Ranger ranger = new("Alberto");
            int expected = 2;
            // Act
            ranger.LevelUp();
            int actual = ranger.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Method_LevelUpRogue_ShouldSetCorrectLevel()
        {
            // Arrange
            Rogue rogue = new("Alberto");
            int expected = 2;
            // Act
            rogue.LevelUp();
            int actual = rogue.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Method_LevelUpWarrior_ShouldSetCorrectLevel()
        {
            // Arrange
            Warrior warrior = new("Alberto");
            int expected = 2;
            // Act
            warrior.LevelUp();
            int actual = warrior.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

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

        #region ItemTests

        [Fact]
        public void Constructor_InitializWeapon_ShouldSetCorrectName()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Wand, 2);
            string expected = "Common Wand";
            // Act
            string actual = weapon.Name;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializWeapon_ShouldSetCorrectLevel()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Wand, 2);
            int expected = 1;
            // Act
            int actual = weapon.RequieredLevel;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializWeapon_ShouldSetCorrectType()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Wand, 2);
            WeaponType expected = WeaponType.Wand;
            // Act
            WeaponType actual = weapon.Type;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializWeapon_ShouldSetCorrectDamage()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Wand, 2);
            int expected = 2;
            // Act
            int actual = weapon.WeaponDamage;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializWeapon_ShouldSetCorrectSlot()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Wand, 2);
            Slot expected = Slot.Weapon;
            // Act
            Slot actual = weapon.Slot;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeArmor_ShouldSetCorrectName()
        {
            // Arrange
            Armor armor = new("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            string expected = "Common cloth";
            // Act
            string actual = armor.Name;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeArmor_ShouldSetCorrectLevel()
        {
            // Arrange
            Armor armor = new("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            int expected = 1;
            // Act
            int actual = armor.RequieredLevel;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeArmor_ShouldSetCorrectSlot()
        {
            // Arrange
            Armor armor = new("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            Slot expected = Slot.Body;
            // Act
            Slot actual = armor.Slot;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeArmor_ShouldSetCorrectType()
        {
            // Arrange
            Armor armor = new("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            ArmorType expected = ArmorType.Cloth;
            // Act
            ArmorType actual = armor.Type;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeArmor_ShouldSetCorrectAttributes()
        {
            // Arrange
            Armor armor = new("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            HeroAttributes expected = new(0,0,1);
            // Act
            HeroAttributes actual = armor.ArmorAttributes;
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Exceptions

        [Fact]
        public void Exception_EquipWeaponWrongType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Wand, 2);
            Warrior warrior = new("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipWeapon(weapon));
        }

        [Fact]
        public void Exception_EquipWeaponWrongLevel_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 2, WeaponType.Wand, 2);
            Warrior warrior = new("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipWeapon(weapon));
        }

        [Fact]
        public void Exception_EquipArmorWrongType_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            Warrior warrior = new("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipArmor(armor));
        }

        [Fact]
        public void Exception_EquipArmorWrongLevel_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Armor armor = new Armor("Common plate", 2, Slot.Body, ArmorType.Plate, 0, 0, 1);
            Warrior warrior = new("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipArmor(armor));
        }
        #endregion

        #region TotalAttributes

        [Fact]
        public void TotalAttributes_WithNoArmor_ShouldReturnCorrectSum()
        {
            // Arrange
            Mage albert = new Mage("Albert");
            HeroAttributes expected = new(1,1,8);
            // Act
            HeroAttributes actual = albert.CalculateTotalAttributes();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalAttributes_WithOnePieceOfArmor_ShouldReturnCorrectSum()
        {
            // Arrange
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 1, 2, 3);
            Mage albert = new Mage("Albert");
            HeroAttributes expected = new(2, 3, 11);
            // Act
            albert.EquipArmor(armor);
            HeroAttributes actual = albert.CalculateTotalAttributes();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalAttributes_WithTwoPiecesOfArmor_ShouldReturnCorrectSum()
        {
            // Arrange
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 1, 2, 3);
            Armor armor2 = new Armor("Common cloth", 1, Slot.Legs, ArmorType.Cloth, 1, 2, 3);
            Mage albert = new Mage("Albert");
            HeroAttributes expected = new(3, 5, 14);
            // Act
            albert.EquipArmor(armor);
            albert.EquipArmor(armor2);
            HeroAttributes actual = albert.CalculateTotalAttributes();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalAttributes_WithReplacedPieceOfArmor_ShouldReturnCorrectSum()
        {
            // Arrange
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 1, 2, 3);
            Armor armor2 = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 2, 3, 4);
            Mage albert = new Mage("Albert");
            HeroAttributes expected = new(3, 4, 12);
            // Act
            albert.EquipArmor(armor);
            albert.EquipArmor(armor2);
            HeroAttributes actual = albert.CalculateTotalAttributes();
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