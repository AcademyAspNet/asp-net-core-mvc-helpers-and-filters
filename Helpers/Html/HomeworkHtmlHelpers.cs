using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreMvcHelpers.Helpers.Html
{
    public class Color
    {
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }
        public byte A { get; private set; }

        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            this.R = red;
            this.G = green;
            this.B = blue;
            this.A = alpha;
        }

        public static Color Red = new Color(255, 0, 0);
        public static Color Green = new Color(0, 255, 0);
        public static Color Blue = new Color(0, 0, 255);
    }

    public static class HomeworkHtmlHelpers
    {
        public static IHtmlContent ColoredText(this IHtmlHelper htmlHelper, string text, Color color)
        {
            TagBuilder span = new TagBuilder("span");
            span.InnerHtml.Append(text);

            string cssColor = $"rgba({color.R}, {color.G}, {color.B}, {color.A})";
            span.Attributes.Add("style", $"color: {cssColor};");

            return span;
        }
    }
}
