namespace DotBuilder.Attributes
{
    public class FontColor : Attribute, INodeAttribute, IEdgeAttribute, IGraphAttribute
    {
        public FontColor(string value) : base(value)
        {
        }
        public static FontColor Aliceblue => new FontColor("aliceblue");
        public static FontColor Antiquewhite => new FontColor("antiquewhite");
        public static FontColor Aqua => new FontColor("aqua");
        public static FontColor Aquamarine => new FontColor("aquamarine");
        public static FontColor Azure => new FontColor("azure");
        public static FontColor Beige => new FontColor("beige");
        public static FontColor Bisque => new FontColor("bisque");
        public static FontColor Black => new FontColor("black");
        public static FontColor Blanchedalmond => new FontColor("blanchedalmond");
        public static FontColor Blue => new FontColor("blue");
        public static FontColor Blueviolet => new FontColor("blueviolet");
        public static FontColor Brown => new FontColor("brown");
        public static FontColor Burlywood => new FontColor("burlywood");
        public static FontColor Cadetblue => new FontColor("cadetblue");
        public static FontColor Chartreuse => new FontColor("chartreuse");
        public static FontColor Chocolate => new FontColor("chocolate");
        public static FontColor Coral => new FontColor("coral");
        public static FontColor Cornflowerblue => new FontColor("cornflowerblue");
        public static FontColor Cornsilk => new FontColor("cornsilk");
        public static FontColor Crimson => new FontColor("crimson");
        public static FontColor Cyan => new FontColor("cyan");
        public static FontColor Darkblue => new FontColor("darkblue");
        public static FontColor Darkcyan => new FontColor("darkcyan");
        public static FontColor Darkgoldenrod => new FontColor("darkgoldenrod");
        public static FontColor Darkgray => new FontColor("darkgray");
        public static FontColor Darkgreen => new FontColor("darkgreen");
        public static FontColor Darkgrey => new FontColor("darkgrey");
        public static FontColor Darkkhaki => new FontColor("darkkhaki");
        public static FontColor Darkmagenta => new FontColor("darkmagenta");
        public static FontColor Darkolivegreen => new FontColor("darkolivegreen");
        public static FontColor Darkorange => new FontColor("darkorange");
        public static FontColor Darkorchid => new FontColor("darkorchid");
        public static FontColor Darkred => new FontColor("darkred");
        public static FontColor Darksalmon => new FontColor("darksalmon");
        public static FontColor Darkseagreen => new FontColor("darkseagreen");
        public static FontColor Darkslateblue => new FontColor("darkslateblue");
        public static FontColor Darkslategray => new FontColor("darkslategray");
        public static FontColor Darkslategrey => new FontColor("darkslategrey");
        public static FontColor Darkturquoise => new FontColor("darkturquoise");
        public static FontColor Darkviolet => new FontColor("darkviolet");
        public static FontColor Deeppink => new FontColor("deeppink");
        public static FontColor Deepskyblue => new FontColor("deepskyblue");
        public static FontColor Dimgray => new FontColor("dimgray");
        public static FontColor Dimgrey => new FontColor("dimgrey");
        public static FontColor Dodgerblue => new FontColor("dodgerblue");
        public static FontColor Firebrick => new FontColor("firebrick");
        public static FontColor Floralwhite => new FontColor("floralwhite");
        public static FontColor Forestgreen => new FontColor("forestgreen");
        public static FontColor Fuchsia => new FontColor("fuchsia");
        public static FontColor Gainsboro => new FontColor("gainsboro");
        public static FontColor Ghostwhite => new FontColor("ghostwhite");
        public static FontColor Gold => new FontColor("gold");
        public static FontColor Goldenrod => new FontColor("goldenrod");
        public static FontColor Gray => new FontColor("gray");
        public static FontColor Green => new FontColor("green");
        public static FontColor Greenyellow => new FontColor("greenyellow");
        public static FontColor Grey => new FontColor("grey");
        public static FontColor Honeydew => new FontColor("honeydew");
        public static FontColor Hotpink => new FontColor("hotpink");
        public static FontColor Indianred => new FontColor("indianred");
        public static FontColor Indigo => new FontColor("indigo");
        public static FontColor Ivory => new FontColor("ivory");
        public static FontColor Khaki => new FontColor("khaki");
        public static FontColor Lavender => new FontColor("lavender");
        public static FontColor Lavenderblush => new FontColor("lavenderblush");
        public static FontColor Lawngreen => new FontColor("lawngreen");
        public static FontColor Lemonchiffon => new FontColor("lemonchiffon");
        public static FontColor Lightblue => new FontColor("lightblue");
        public static FontColor Lightcoral => new FontColor("lightcoral");
        public static FontColor Lightcyan => new FontColor("lightcyan");
        public static FontColor Lightgoldenrodyellow => new FontColor("lightgoldenrodyellow");
        public static FontColor Lightgray => new FontColor("lightgray");
        public static FontColor Lightgreen => new FontColor("lightgreen");
        public static FontColor Lightgrey => new FontColor("lightgrey");
        public static FontColor Lightpink => new FontColor("lightpink");
        public static FontColor Lightsalmon => new FontColor("lightsalmon");
        public static FontColor Lightseagreen => new FontColor("lightseagreen");
        public static FontColor Lightskyblue => new FontColor("lightskyblue");
        public static FontColor Lightslategray => new FontColor("lightslategray");
        public static FontColor Lightslategrey => new FontColor("lightslategrey");
        public static FontColor Lightsteelblue => new FontColor("lightsteelblue");
        public static FontColor Lightyellow => new FontColor("lightyellow");
        public static FontColor Lime => new FontColor("lime");
        public static FontColor Limegreen => new FontColor("limegreen");
        public static FontColor Linen => new FontColor("linen");
        public static FontColor Magenta => new FontColor("magenta");
        public static FontColor Maroon => new FontColor("maroon");
        public static FontColor Mediumaquamarine => new FontColor("mediumaquamarine");
        public static FontColor Mediumblue => new FontColor("mediumblue");
        public static FontColor Mediumorchid => new FontColor("mediumorchid");
        public static FontColor Mediumpurple => new FontColor("mediumpurple");
        public static FontColor Mediumseagreen => new FontColor("mediumseagreen");
        public static FontColor Mediumslateblue => new FontColor("mediumslateblue");
        public static FontColor Mediumspringgreen => new FontColor("mediumspringgreen");
        public static FontColor Mediumturquoise => new FontColor("mediumturquoise");
        public static FontColor Mediumvioletred => new FontColor("mediumvioletred");
        public static FontColor Midnightblue => new FontColor("midnightblue");
        public static FontColor Mintcream => new FontColor("mintcream");
        public static FontColor Mistyrose => new FontColor("mistyrose");
        public static FontColor Moccasin => new FontColor("moccasin");
        public static FontColor Navajowhite => new FontColor("navajowhite");
        public static FontColor Navy => new FontColor("navy");
        public static FontColor Oldlace => new FontColor("oldlace");
        public static FontColor Olive => new FontColor("olive");
        public static FontColor Olivedrab => new FontColor("olivedrab");
        public static FontColor Orange => new FontColor("orange");
        public static FontColor Orangered => new FontColor("orangered");
        public static FontColor Orchid => new FontColor("orchid");
        public static FontColor Palegoldenrod => new FontColor("palegoldenrod");
        public static FontColor Palegreen => new FontColor("palegreen");
        public static FontColor Paleturquoise => new FontColor("paleturquoise");
        public static FontColor Palevioletred => new FontColor("palevioletred");
        public static FontColor Papayawhip => new FontColor("papayawhip");
        public static FontColor Peachpuff => new FontColor("peachpuff");
        public static FontColor Peru => new FontColor("peru");
        public static FontColor Pink => new FontColor("pink");
        public static FontColor Plum => new FontColor("plum");
        public static FontColor Powderblue => new FontColor("powderblue");
        public static FontColor Purple => new FontColor("purple");
        public static FontColor Red => new FontColor("red");
        public static FontColor Rosybrown => new FontColor("rosybrown");
        public static FontColor Royalblue => new FontColor("royalblue");
        public static FontColor Saddlebrown => new FontColor("saddlebrown");
        public static FontColor Salmon => new FontColor("salmon");
        public static FontColor Sandybrown => new FontColor("sandybrown");
        public static FontColor Seagreen => new FontColor("seagreen");
        public static FontColor Seashell => new FontColor("seashell");
        public static FontColor Sienna => new FontColor("sienna");
        public static FontColor Silver => new FontColor("silver");
        public static FontColor Skyblue => new FontColor("skyblue");
        public static FontColor Slateblue => new FontColor("slateblue");
        public static FontColor Slategray => new FontColor("slategray");
        public static FontColor Slategrey => new FontColor("slategrey");
        public static FontColor Snow => new FontColor("snow");
        public static FontColor Springgreen => new FontColor("springgreen");
        public static FontColor Steelblue => new FontColor("steelblue");
        public static FontColor Tan => new FontColor("tan");
        public static FontColor Teal => new FontColor("teal");
        public static FontColor Thistle => new FontColor("thistle");
        public static FontColor Tomato => new FontColor("tomato");
        public static FontColor Turquoise => new FontColor("turquoise");
        public static FontColor Violet => new FontColor("violet");
        public static FontColor Wheat => new FontColor("wheat");
        public static FontColor White => new FontColor("white");
        public static FontColor Whitesmoke => new FontColor("whitesmoke");
        public static FontColor Yellow => new FontColor("yellow");
        public static FontColor Yellowgreen => new FontColor("yellowgreen");

        public static FontColor RGB(int red, int green, int blue) => new FontColor($"#{red:x2}{green:x2}{blue:x2}");
        public static FontColor RGBA(int red, int green, int blue, int alpha) => new FontColor($"#{red:x2}{green:x2}{blue:x2}{alpha:x2}");

    }
}