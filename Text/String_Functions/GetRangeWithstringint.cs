using System.Collections.Generic;

namespace Text.String_Functions
{
    public class GetRangeWithstringint
    {
        public static intint GetRangeWithstringintSpaces(stringint that, IReadOnlyList<string> strings)
        {
            var start = 0;
            for (var i = 0; i < that.Theint; i++)
            {
                start += strings[i].Length+1;
            }
            return new intint(start, start+strings[that.Theint].Length);
        }

        public static intint GetRangeWithstringintwithoutSpaces (stringint that, IReadOnlyList<string> strings)
        {
            var start = 0;
            for (var i = 0; i < that.Theint; i++)
            {
                start += strings[i].Length;
            }
            return new intint (start, start + strings[that.Theint].Length);
        }
    }
}