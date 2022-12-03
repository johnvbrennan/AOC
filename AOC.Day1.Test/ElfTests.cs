using AOC.Day1;

namespace AOC.Day1.Test
{
    public class ElfTests
    {
        [Fact]
        public void TotalCalories_ElfInitialisedWithMultipleCalories_ReturnsSumOfCalories()
        {
            const int expectedTotal = 6;
            const int expectedPosition = 1;

            // Arrange
            var elf = new Elf(1, new List<int> { 1, 2, 3});

            // Assert
            Assert.Equal(expectedPosition, elf.Position);
            Assert.Equal(expectedTotal, elf.TotalCalories);
        }

        [Fact]
        public void TotalCalories_ElfInitialisedWithEmptyListOfCalories_ReturnsSumOfCalories()
        {
            const int expectedTotal = 0;
            const int expectedPosition = 1;
            
            // Arrange
            var elf = new Elf(1, new List<int>());

            // Assert
            Assert.Equal(expectedPosition, elf.Position);
            Assert.Equal(expectedTotal, elf.TotalCalories);
        }
    }
}