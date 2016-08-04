using System.Linq;
using System.Windows.Forms;
using Text.String_Functions;
using Text.Types;

namespace Text.Colour
{
    public class ColourMain
    {
        public static void OnTextChange(RichTextBox tbox)
        {
            var word = GetCurrent.GetCurrentWord (tbox.SelectionStart, tbox);
            WordActions(word, tbox);
            var cchar = GetCurrent.GetCurrentCharacter(tbox.SelectionStart, tbox);
            CharActions(cchar, tbox);
        }

        private static void CharActions(stringint cchar, RichTextBox tbox)
        {
            if (cchar?.Thestring == null || cchar.Thestring.Length <= 0) return;
            if(PublicStuff.Splitters.Contains(cchar.Thestring[0]))
                ColourSth.Colour_FromTo(
                    new intint(cchar.Theint, tbox.SelectionStart), 
                    tbox,
                    PublicStuff.SplitterColor);
        }

        public static void WordActions(stringint word, RichTextBox tbox)
        {
            if (word == null) return;
            var boolcolor = EvaluateIfColouredandgetColour.IsColouredandColor (word.Thestring);
            if (boolcolor.Thebool)
                ColourSth.Colour_FromTo (
                    GetRangeWithstringint.GetRangeWithstringintSpaces (
                        word,
                        tbox.Text.Split (PublicStuff.Splitters)), 
                    tbox, 
                    boolcolor.Thecolor);
            else
                ColourSth.Colour_FromTo (
                    GetRangeWithstringint.GetRangeWithstringintSpaces (
                        word,
                        tbox.Text.Split (PublicStuff.Splitters)),
                    tbox,
                    boolcolor.Thecolor);

        }
    }
}