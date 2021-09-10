using Xunit;

namespace Assignment1.Tests {
    public class GenericsTests {
        [Fact]
        public void GreaterCount_given_3_ducks_return_2() {
            // Arrange
            var x = new Duck { Id = 1, Name = "Huey Duck", Age = 10 };
            var ducks = new[] {
                x,
                new Duck { Id = 2, Name = "Magica De Spell", Age = 302 },
                new Duck { Id = 3, Name = "Dewey Duck", Age = 10 }
            };

            // Act
            var output = Generics.GreaterCount<Duck, Animal>(ducks, x);

            // Assert
            // Animals compare by id
            Assert.Equal(2, output);
        }

        [Fact]
        public void GreaterCount_given_3_small_ducks_and_one_large_return_0() {
            // Arrange
            var x = new Duck { Id = 4, Name = "Huey Duck", Age = 10 };
            var ducks = new[] {
                x,
                new Duck { Id = 3, Name = "Magica De Spell", Age = 302 },
                new Duck { Id = 2, Name = "Dewey Duck", Age = 10 }
            };

            // Act
            var output = Generics.GreaterCount<Duck, Animal>(ducks, x);

            // Assert
            // Animals compare by id
            Assert.Equal(0, output);
        }
    }
}