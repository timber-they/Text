using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace Text
{
    public class PublicStuff
    {
        public static List<string> HighlightedWordsList = new List<string>
        {
            "HALLO", "HI",
            "ICH", "MIR", "MICH", "MEIN", "MEINE", "MEINES", "MEINER", "MEINEM", "MEINEN", "MEINS", "WIR", "UNS", "UNSERE", "UNSERES", "UNSER", "UNSEREM", "UNSERER", "UNSEREN",
            "DU", "DIR", "DICH", "DEIN", "DEINE", "DEINES", "DEINER", "DEINEM", "DEINEN", "DEINS", "EUCH", "EURE", "EURES", "EUER", "EUREM", "EURER", "EUREN",
            "ER", "IHN", "IHM", "SEIN", "SEINE", "SEINES", "SEINER", "SEINEM", "SEINEN", "SEINS", "IHNEN", "IHRE", "IHRES", "IHRER", "IHREM", "IHRER", "IHREN",
            "ES", "IHR", "SIE",
            "DER", "DIE", "DAS", "DIESER", "DIESE", "DIESES", "JENER", "JENE", "JENES", "WELCHER", "WELCHE", "WELCHES",
            "DASS",
            "UND"
        };

        public static List<Color> HighlightedWordsColors = new List<Color>
        {
            Color.Cyan, Color.Cyan,
            Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue, Color.RoyalBlue,
            Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow,
            Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown, Color.Brown,
            Color.DarkOliveGreen, Color.DeepPink, Color.DeepPink,
            Color.Brown, Color.DeepPink, Color.DarkOliveGreen, Color.Brown, Color.DeepPink, Color.DarkOliveGreen, Color.Brown, Color.DeepPink, Color.DarkOliveGreen, Color.Brown, Color.DeepPink, Color.DarkOliveGreen,
            Color.BlueViolet,
            Color.OrangeRed
        };

        public static Color UppercaseColor = Color.Red;
        public static Color SplitterColor = Color.LimeGreen;
        public static Color StandardColor = Color.White;

        public static char[] Splitters = {' ', ',', '.', ';', ':', '!', '?', '/', '\\', '&', '\"', '-', '_', '%', '(', ')', '{', '}', '[', ']', '=', '#', '*', '^', '>', '<', '\n'};
    }
}