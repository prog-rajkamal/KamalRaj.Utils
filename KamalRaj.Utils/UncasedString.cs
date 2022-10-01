using System;

namespace KamalRaj.Utils
{
    public class UncasedString: IComparable<UncasedString>,IEquatable<UncasedString>

    {
        private string value;

        public UncasedString(string v)
        {
            this.value = v;
        }

        public int CompareTo(UncasedString other)
        {
            if (this.Equals(other))
                return 0;

            return value.CompareTo(other.value);
        }

        public bool Equals(UncasedString other)
        {
            return value.Equals(other.value, StringComparison.InvariantCultureIgnoreCase);
        }

        public override string ToString()
        {
            return value;
        }

        public static bool operator ==(UncasedString a, UncasedString b) => a.Equals(b);
        public static bool operator !=(UncasedString a, UncasedString b) => !a.Equals(b);
    }
}
