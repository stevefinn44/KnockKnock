using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace KnockKnockLibrary
{
    public class ReverseHelper
    {
        private readonly char[] _seperator = new char[] {' '};
        public string Reverse(string input)
        {

            var result = new List<string>();

            var array = input.Split(_seperator).ToList();

            foreach (var word in array)
            {
                result.Add(word.Reverse());
            }

            return string.Join(" ", result);
        }
    }

    public static class Reverser
    {
        public static string Reverse(this string s)
        {
            return string.Join("", s.GetChars().Reverse().ToArray());
        }

        public static IEnumerable<string> GetChars(this string s)
        {
            var enumerator = StringInfo.GetTextElementEnumerator(s);
            while (enumerator.MoveNext())
                yield return (string)enumerator.Current;

        }
    }
}
