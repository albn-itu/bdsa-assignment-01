using Xunit;
using System;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_given_lists_return_content() {
            // Arrange
            var list = new[]{
                new[] {1,2,3,4},
                new[] {5,6,7,8},
                new[] {9,10}
            };

            // Act
            var output = Iterators.Flatten<int>(list);

            // Assert
            Assert.Equal(new[] {1,2,3,4,5,6,7,8,9,10}, output);
        }

        [Fact]
        public void Filter_given_1_2_3_4_5_return_2_and_4() {
            // Arrange
            var list = new[]{1,2,3,4,5};
            Predicate<int> predicate = (int i) => i % 2 == 0;

            // Act
            var output = Iterators.Filter<int>(list, predicate);

            // Asset
            Assert.Equal(new[] {2,4}, output);
        }
    }
}
