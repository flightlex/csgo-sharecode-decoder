using System.Drawing;

namespace csgo_sharecode.CSGOSharecode.Structs
{
    public class ARGBColor
    {
        public ARGBColor() { }
        public ARGBColor(byte alpha, byte red, byte green, byte blue)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public byte Alpha { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        // static methods
        public static string ARGBToHEX(ARGBColor color) => Color.FromArgb(color.Alpha, color.Red, color.Green, color.Blue).ToArgb().ToString("X8");
        public static ARGBColor HEXToARGB(string hex)
        {
            var color = ColorTranslator.FromHtml(hex);
            return new ARGBColor
            {
                Alpha = color.A,
                Red = color.R,
                Green = color.G,
                Blue = color.B
            };
        }

        // instance method
        public string ARGBToHEX() => ARGBToHEX(this);
    }
}
