using System;
using System.Collections.Generic;
using System.Linq;

namespace CPT {
    public static class Utils {   
        #nullable enable
        public static string? PickRandomWord(int wordLength) {
            return Words.words.Where(w => w.Length == wordLength).Random();
        }
        
        private static T? Random<T>(this IEnumerable<T?> enumerable) {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }
        
            var r = new Random();
            var list = enumerable as IList<T?> ?? enumerable.ToList(); 
            return list.Count == 0 ? default(T) : list[r.Next(0, list.Count)];
        }
    }
}