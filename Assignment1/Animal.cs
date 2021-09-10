using System;
using System.Collections.Generic;

namespace Assignment1
{
    public abstract class Animal : IEquatable<Animal>, IComparable<Animal>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        /// <summary>
        /// Two ducks are considered equal if they have the same name
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Animal other)
        {
            if (other == null)
            {
                return false;
            }
            else
            {
                return Name == other.Name;
            }
        }

        /// <summary>
        /// Overridden default equals to compare ducks by Id
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as Animal);
        }

        public static bool operator ==(Animal x, Animal y)
        {
            return x.Name == y.Name;
        }

        public static bool operator !=(Animal x, Animal y)
        {
            return x.Name != y.Name;
        }

        public int CompareTo(Animal other)
        {
            if (Id < other.Id)
            {
                return -1;
            }
            if (Id > other.Id)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// GetHashCode should always be overridden when Equals is overridden.
        /// https://docs.microsoft.com/en-us/visualstudio/code-quality/ca2218-override-gethashcode-on-overriding-equals
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return Id + ": " + Name + ", " + Age;
        }
    }
}