using NUnit.Framework;
using System;

namespace ПиТМП
{
    [TestFixture]
    public class InventoryItemTests
    {
        [Test]
        public void Constructor_ShouldInitializeWithZeroQuantity()
        {
            var item = new InventoryItem("Test Item");
            Assert.That(item.GetQuantity(), Is.EqualTo(0));
        }

        [Test]
        public void AddStock_ShouldIncreaseQuantity()
        {
            var item = new InventoryItem("Test Item");
            item.AddStock(10);
            Assert.That(item.GetQuantity(), Is.EqualTo(10));
        }

        [Test]
        public void AddStock_ShouldThrowException_WhenAmountIsZeroOrNegative()
        {
            var item = new InventoryItem("Test Item");
            Assert.That(() => item.AddStock(0), Throws.ArgumentException);
            Assert.That(() => item.AddStock(-5), Throws.ArgumentException);
        }

        [Test]
        public void RemoveStock_ShouldDecreaseQuantity()
        {
            var item = new InventoryItem("Test Item");
            item.AddStock(10);
            item.RemoveStock(5);
            Assert.That(item.GetQuantity(), Is.EqualTo(5));
        }

        [Test]
        public void RemoveStock_ShouldThrowException_WhenAmountExceedsQuantity()
        {
            var item = new InventoryItem("Test Item");
            item.AddStock(5);
            Assert.That(() => item.RemoveStock(10), Throws.InvalidOperationException);
        }

        [Test]
        public void RemoveStock_ShouldThrowException_WhenAmountIsZeroOrNegative()
        {
            var item = new InventoryItem("Test Item");
            Assert.That(() => item.RemoveStock(0), Throws.ArgumentException);
            Assert.That(() => item.RemoveStock(-3), Throws.ArgumentException);
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenNameIsEmpty()
        {
            Assert.That(() => new InventoryItem(""), Throws.ArgumentException);
        }
    }
}
