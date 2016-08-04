using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Text.String_Functions
{
    public class GetCurrent
    {
        public static stringint GetCurrentWord (int pos, RichTextBox text)
        {
            var all = text.Text;
            var splitted = all.Split (PublicStuff.Splitters);
            return GetStringofArray (pos, splitted);
        }

        public static stringint GetStringofArray (int pos, IReadOnlyList<string> strings)
        {
            var cpos = 0;
            var apos = -1;
            while (cpos < pos && apos < strings.Count - 1)
            {
                apos++;
                cpos += strings[apos].Length + 1;
            }
            if(apos >= 0)
                return new stringint (strings[apos], apos);
            return null;
        }

        public static stringint GetCurrentCharacter(int pos, RichTextBox text)
        {
            if (pos > 0)
                return new stringint(text.Text.ToCharArray()[pos - 1].ToString(), pos - 1);
            else return null;
        }
    }
}