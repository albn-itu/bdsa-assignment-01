using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Duck : Animal
    {
        public void Quack() {
            Console.WriteLine("Quack");
        }

        public static ICollection<Duck> Ducks = new[] {
            new Duck { Id = 3, Name = "Huey Duck", Age = 10 },
            new Duck { Id = 8, Name = "Magica De Spell", Age = 302 },
            new Duck { Id = 4, Name = "Dewey Duck", Age = 10 },
            new Duck { Id = 5, Name = "Louie  Duck", Age = 10 },
            new Duck { Id = 6, Name = "Scrooge McDuck", Age = 60 },
            new Duck { Id = 7, Name = "Flintheart Glomgold", Age = 66 },
            new Duck { Id = 1, Name = "Donald Duck", Age = 32 },
            new Duck { Id = 2, Name = "Daisy Duck", Age = 30 },
            new Duck { Id = 9, Name = "John D. Rockerduck", Age = 55 }
        };
    }
}