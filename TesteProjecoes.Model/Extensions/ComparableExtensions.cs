using System;

namespace TesteProjecoes.Model.Extensions
{
    public static class ComparableExtensions
    {
        public static bool IsBetween(this IComparable value, IComparable inicio, IComparable fim)
        {
            return value.CompareTo(inicio) >= 0 && value.CompareTo(fim) <= 0;
        }
    }
}
