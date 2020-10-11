using System.Collections.Generic;
using System.Linq;

namespace AcamTi.CtrlBang.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsSameAs<T>(this IEnumerable<T> source, IEnumerable<T> target)
        {
            IEnumerable<T> sourceEnumerable = source as T[] ?? source.ToArray();
            IEnumerable<T> targetEnumerable = target as T[] ?? target.ToArray();

            return
                sourceEnumerable.Count() == targetEnumerable.Count() &&
                sourceEnumerable.All(
                    sourceItem => targetEnumerable.Any(
                        c => c.Equals(sourceItem)
                    )
                );
        }
    }
}
