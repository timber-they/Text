using System.Drawing;
using System.Linq;
using Text.Types;

namespace Text.String_Functions
{
    public class EvaluateIfColouredandgetColour
    {
        public static bool IsColoured(string word)
        {
            if (word != null)
                return IsInList(word) || StartsWithCapital(word);
                return false;
        }

        public static bool StartsWithCapital(string word)
        {
            return char.IsUpper(word.ToCharArray()[0]);
        }

        public static bool IsInList(string word)
        {
            return PublicStuff.HighlightedWordsList.Contains(word.ToUpper());
        }

        public static boolcolor IsColouredandColor(string word)
        {
            if (word.Length <= 0) return new boolcolor(false, Color.Black);
            if(IsInList(word))
                return new boolcolor(true, GetColourToWordFromList(word));
            if (StartsWithCapital(word)) return new boolcolor(true, PublicStuff.UppercaseColor);
            return new boolcolor(false, Color.White);
        }

        public static Color GetColourToWordFromList(string word)
        {
            return PublicStuff.HighlightedWordsColors[PublicStuff.HighlightedWordsList.IndexOf(word.ToUpper())];
        }
    }
}