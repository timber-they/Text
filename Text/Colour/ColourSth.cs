using System.Drawing;
using System.Windows.Forms;

namespace Text.Colour
{
    public class ColourSth
    {
        public static void Colour_Word(string word, RichTextBox text)
        { 
            var pos = text.SelectionStart;
            var posstring = text.Find (word);
            if (posstring >= 0)
            {
                text.SelectionStart = posstring;
                text.SelectionLength = word.Length;
                text.SelectionColor = Color.Blue;
            }
            text.SelectionStart = pos;
            text.SelectionLength = 0;
            text.SelectionColor = Color.White;
        }

        public static void Colour_FromTo(intint area, RichTextBox text, Color colour)
        {
            var pos = text.SelectionStart;
            text.Select(area.Int1, area.Int2-area.Int1);
            text.SelectionColor = colour;
            text.Select(pos, 0);
            text.SelectionColor = text.ForeColor;
        }
    }
}