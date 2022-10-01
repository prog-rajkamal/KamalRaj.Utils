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
        
        // converts string to UncasedString explicitly
        public static explicit operator UncasedString(string b) => new UncasedString(b);

        // converts UncasedString to string without requiring explicit conversion
        public static implicit operator string(UncasedString b) => b.value;

        public override int GetHashCode()
        {
            return this.value.ToLowerInvariant().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this.Equals(obj.ToString()))
                return true;
            return false;
        }

    }
}
