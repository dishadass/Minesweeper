namespace MineSweeper
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MIneSweeper; // Update this namespace to match your project's namespace

[TestClass]
public class FieldTests
{
    [TestMethod]
    public void FieldInitializationTest()
    {
        // Arrange
        int row = 5;
        int col = 5;
        int mines = 10;

        // Act
        Field field = new Field(row, col, mines);

        // Assert
        Assert.IsNotNull(field);
        Assert.IsFalse(field.Started);
        Assert.AreEqual(row, field.Row);
        {
            Assert.AreEqual(col, field.Col);
            Assert.AreEqual(mines, field.Mines);
            Assert.IsNotNull(field.Mine_Map);
            Assert.IsNotNull(field.Discovered);
            Assert.IsNotNull(field.Flagged);
            CollectionAssert.AllItemsAreNotNull(field.Mine_Map);
            CollectionAssert.AllItemsAreUnique(field.Discovered);
            CollectionAssert.AllItemsAreUnique(field.Flagged);
        }
    }
}
