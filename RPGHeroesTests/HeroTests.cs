using static System.Net.Mime.MediaTypeNames;
using RPGHeroes;
using RPGHeroes.Heroes;
using RPGHeroes.Items;
using RPGHeroes.Exceptions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Text;
using System.Threading;

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
            Hero mage = new Mage(name);
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
            Hero ranger = new Ranger(name);
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
            Hero rogue = new Rogue(name);
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
            Hero warrior = new Warrior(name);
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
            Hero mage = new Mage(name);
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
            Hero mage = new Mage("Alberto");
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
            Hero ranger = new Ranger("Alberto");
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
            Hero rogue = new Rogue("Alberto");
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
            Hero warrior = new Warrior("Alberto");
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
            Hero mage = new Mage("Alberto");
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
            Hero ranger = new Ranger("Alberto");
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
            Hero rogue = new Rogue("Alberto");
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
            Hero warrior = new Warrior("Alberto");
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
            Hero mage = new Mage("Alberto");
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
            Hero ranger = new Ranger("Alberto");
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
            Hero rogue = new Rogue("Alberto");
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
            Hero warrior = new Warrior("Alberto");
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
        public void Exception_EquipWeaponWarriorWrongType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Wand, 2);
            Hero warrior = new Warrior("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipWeapon(weapon));
        }

        [Fact]
        public void Exception_EquipWeaponMageWrongType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Axe, 2);
            Hero mage = new Mage("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidWeaponException>(() => mage.EquipWeapon(weapon));
        }

        [Fact]
        public void Exception_EquipWeaponRangerWrongType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Axe, 2);
            Hero ranger = new Ranger("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidWeaponException>(() => ranger.EquipWeapon(weapon));
        }

        [Fact]
        public void Exception_EquipWeaponRogueWrongType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 1, WeaponType.Wand, 2);
            Hero warrior = new Warrior("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipWeapon(weapon));
        }

        [Fact]
        public void Exception_EquipWeaponWrongLevel_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Weapon weapon = new("Common Wand", 2, WeaponType.Wand, 2);
            Hero warrior = new Warrior("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipWeapon(weapon));
        }

        [Fact]
        public void Exception_EquipArmorWarriorWrongType_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            Hero warrior = new Warrior("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipArmor(armor));
        }

        [Fact]
        public void Exception_EquipArmorMageWrongType_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Leather, 0, 0, 1);
            Hero mage = new Mage("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidArmorException>(() => mage.EquipArmor(armor));
        }

        [Fact]
        public void Exception_EquipArmorRogueiorWrongType_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            Hero rogue = new Rogue("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidArmorException>(() => rogue.EquipArmor(armor));
        }

        [Fact]
        public void Exception_EquipArmorRangerWrongType_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            Hero ranger = new Ranger("Alberto");
            // Act
            //Assert
            Assert.Throws<InvalidArmorException>(() => ranger.EquipArmor(armor));
        }

        [Fact]
        public void Exception_EquipArmorWrongLevel_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Armor armor = new Armor("Common plate", 2, Slot.Body, ArmorType.Plate, 0, 0, 1);
            Hero warrior = new Warrior("Alberto");
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
            Hero albert = new Mage("Albert");
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
            Hero albert = new Mage("Albert");
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
            Hero albert = new Mage("Albert");
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
            Hero albert = new Mage("Albert");
            HeroAttributes expected = new(3, 4, 12);
            // Act
            albert.EquipArmor(armor);
            albert.EquipArmor(armor2);
            HeroAttributes actual = albert.CalculateTotalAttributes();
            //Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Damage

        [Fact]
        public void CalculateDamage_MageWithNoWeaon_ShouldReturnOne()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            double expected = 1;
            // Act
            double actual = albert.CalculateDamange();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDamage_MageWithWeaon_ShouldReturnCorrectSum()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            Weapon weapon = new Weapon("Common Wand", 1, WeaponType.Wand, 1);
            double expected = 1.0 * (1.0 + (8.0/100.0));
            // Act
            albert.EquipWeapon(weapon);
            double actual = albert.CalculateDamange();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDamage_MageWithNewWeaon_ShouldReturnCorrectSum()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            Weapon weapon = new Weapon("Common Wand", 1, WeaponType.Wand, 1);
            Weapon weapon2 = new Weapon("Common Staff", 1, WeaponType.Staff, 2);
            double expected = 2.0 * (1.0 + (8.0 / 100.0));
            // Act
            albert.EquipWeapon(weapon);
            albert.EquipWeapon(weapon2);
            double actual = albert.CalculateDamange();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDamage_MageWithWeaponAndArmor_ShouldReturnCorrectSum()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            Weapon weapon = new Weapon("Common Wand", 1, WeaponType.Wand, 1);
            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 1, 2, 3);
            double expected = 1.0 * (1.0 + (11.0 / 100.0));
            // Act
            albert.EquipWeapon(weapon);
            albert.EquipArmor(armor);
            double actual = albert.CalculateDamange();
            //Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Display

        [Fact]
        public void Display_MageWithNoWeaponNoArmor_ShouldDisplayCorrectStats()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + "Albert");
            sb.AppendLine("Class: " + "Mage");
            sb.AppendLine("Level: " + 1);
            sb.AppendLine("Strength: " + 1);
            sb.AppendLine("Dexterity: " + 1);
            sb.AppendLine("Intelligence: " + 8);
            sb.AppendLine("Damage: " + 1);
            string expected = sb.ToString();
            // Act
            string actual = albert.Display();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Display_MageWithNoWeaponNoArmorLevelUp_ShouldDisplayCorrectStats()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + "Albert");
            sb.AppendLine("Class: " + "Mage");
            sb.AppendLine("Level: " + 2);
            sb.AppendLine("Strength: " + 2);
            sb.AppendLine("Dexterity: " + 2);
            sb.AppendLine("Intelligence: " + 13);
            sb.AppendLine("Damage: " + 1);
            string expected = sb.ToString();
            // Act
            albert.LevelUp();
            string actual = albert.Display();
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Display_MageWithWeaponNoArmor_ShouldDisplayCorrectStats()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            Weapon weapon = new Weapon("Common Wand", 1, WeaponType.Wand, 1);
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + "Albert");
            sb.AppendLine("Class: " + "Mage");
            sb.AppendLine("Level: " + 1);
            sb.AppendLine("Strength: " + 1);
            sb.AppendLine("Dexterity: " + 1);
            sb.AppendLine("Intelligence: " + 8);
            sb.AppendLine("Damage: " + 1.08);
            string expected = sb.ToString();
            // Act
            albert.EquipWeapon(weapon);
            string actual = albert.Display();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Display_MageWithNoWeaponAndArmor_ShouldDisplayCorrectStats()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            Armor armor = new("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
           
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + "Albert");
            sb.AppendLine("Class: " + "Mage");
            sb.AppendLine("Level: " + 1);
            sb.AppendLine("Strength: " + 1);
            sb.AppendLine("Dexterity: " + 1);
            sb.AppendLine("Intelligence: " + 9);
            sb.AppendLine("Damage: " + 1);
            string expected = sb.ToString();
            // Act
            albert.EquipArmor(armor);          
            string actual = albert.Display();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Display_MageWithWeaponAndArmor_ShouldDisplayCorrectStats()
        {
            // Arrange
            Hero albert = new Mage("Albert");
            Armor armor = new("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            Weapon weapon = new Weapon("Common Wand", 1, WeaponType.Wand, 1);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + "Albert");
            sb.AppendLine("Class: " + "Mage");
            sb.AppendLine("Level: " + 1);
            sb.AppendLine("Strength: " + 1);
            sb.AppendLine("Dexterity: " + 1);
            sb.AppendLine("Intelligence: " + 9);
            sb.AppendLine("Damage: " + 1.09);
            string expected = sb.ToString();
            // Act
            albert.EquipArmor(armor);
            albert.EquipWeapon(weapon);
            string actual = albert.Display();
            //Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region HeroAttributes

        [Fact]
        public void ToString_HeroAttributesDisplayState_ShouldReturnCorrectValues()
        {
            // Arrange
            HeroAttributes attributes = new HeroAttributes(1,1,8);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Strength: " + 1);
            sb.AppendLine("Dexterity: " + 1);
            sb.AppendLine("Intelligence: " + 8);
            string expected = sb.ToString();
            // Act
            string actual = attributes.ToString();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddAttributes_AddingTwoHeroAttributes_ShouldReturnNewWithAddedFieldValues()
        {
            // Arrange
            HeroAttributes attributes = new HeroAttributes(1, 1, 8);
            HeroAttributes attributes2 = new HeroAttributes(1, 1, 8);
            HeroAttributes expected = new HeroAttributes(2, 2, 16);
            // Act
            HeroAttributes actual = HeroAttributes.AddAttributes(attributes, attributes2);
            //Assert
            Assert.Equal(expected, actual);
        }

        #endregion

    }
}