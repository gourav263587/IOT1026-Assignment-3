using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentTest
{
    [TestClass]
    public class PackTests
    {
        [TestMethod]
        public void AddItemToPack_Success()
        {
            // Arrange
            Pack pack = new Pack(10, 20, 30);
            InventoryItem item = new InventoryItem("Arrow", 0.1, 0.05);

            // Act
            bool result = pack.Add(item);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddItemToPack_ExceedMaxCount_Failure()
        {
            // Arrange
            Pack pack = new Pack(1, 20, 30);
            InventoryItem item1 = new InventoryItem("Arrow", 0.1, 0.05);
            InventoryItem item2 = new InventoryItem("Bow", 1, 4);

            // Act
            pack.Add(item1);
            bool result = pack.Add(item2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddItemToPack_ExceedMaxVolume_Failure()
        {
            // Arrange
            Pack pack = new Pack(10, 1, 1);
            InventoryItem item = new InventoryItem("Rope", 1, 1);

            // Act
            bool result = pack.Add(item);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddItemToPack_ExceedMaxWeight_Failure()
        {
            // Arrange
            Pack pack = new Pack(10, 20, 1);
            InventoryItem item = new InventoryItem("Sword", 5, 3);

            // Act
            bool result = pack.Add(item);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
