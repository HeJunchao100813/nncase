﻿namespace DotBuilder.Attributes
{
    // see http://www.graphviz.org/content/color-names
    public class Color : Attribute, INodeAttribute, IEdgeAttribute, IGraphAttribute
    {
        public Color(string value) : base(value)
        {
        }

        public static Color Aliceblue => new Color("aliceblue");
        public static Color Antiquewhite => new Color("antiquewhite");
        public static Color Aqua => new Color("aqua");
        public static Color Aquamarine => new Color("aquamarine");
        public static Color Azure => new Color("azure");
        public static Color Beige => new Color("beige");
        public static Color Bisque => new Color("bisque");
        public static Color Black => new Color("black");
        public static Color Blanchedalmond => new Color("blanchedalmond");
        public static Color Blue => new Color("blue");
        public static Color Blueviolet => new Color("blueviolet");
        public static Color Brown => new Color("brown");
        public static Color Burlywood => new Color("burlywood");
        public static Color Cadetblue => new Color("cadetblue");
        public static Color Chartreuse => new Color("chartreuse");
        public static Color Chocolate => new Color("chocolate");
        public static Color Coral => new Color("coral");
        public static Color Cornflowerblue => new Color("cornflowerblue");
        public static Color Cornsilk => new Color("cornsilk");
        public static Color Crimson => new Color("crimson");
        public static Color Cyan => new Color("cyan");
        public static Color Darkblue => new Color("darkblue");
        public static Color Darkcyan => new Color("darkcyan");
        public static Color Darkgoldenrod => new Color("darkgoldenrod");
        public static Color Darkgray => new Color("darkgray");
        public static Color Darkgreen => new Color("darkgreen");
        public static Color Darkgrey => new Color("darkgrey");
        public static Color Darkkhaki => new Color("darkkhaki");
        public static Color Darkmagenta => new Color("darkmagenta");
        public static Color Darkolivegreen => new Color("darkolivegreen");
        public static Color Darkorange => new Color("darkorange");
        public static Color Darkorchid => new Color("darkorchid");
        public static Color Darkred => new Color("darkred");
        public static Color Darksalmon => new Color("darksalmon");
        public static Color Darkseagreen => new Color("darkseagreen");
        public static Color Darkslateblue => new Color("darkslateblue");
        public static Color Darkslategray => new Color("darkslategray");
        public static Color Darkslategrey => new Color("darkslategrey");
        public static Color Darkturquoise => new Color("darkturquoise");
        public static Color Darkviolet => new Color("darkviolet");
        public static Color Deeppink => new Color("deeppink");
        public static Color Deepskyblue => new Color("deepskyblue");
        public static Color Dimgray => new Color("dimgray");
        public static Color Dimgrey => new Color("dimgrey");
        public static Color Dodgerblue => new Color("dodgerblue");
        public static Color Firebrick => new Color("firebrick");
        public static Color Floralwhite => new Color("floralwhite");
        public static Color Forestgreen => new Color("forestgreen");
        public static Color Fuchsia => new Color("fuchsia");
        public static Color Gainsboro => new Color("gainsboro");
        public static Color Ghostwhite => new Color("ghostwhite");
        public static Color Gold => new Color("gold");
        public static Color Goldenrod => new Color("goldenrod");
        public static Color Gray => new Color("gray");
        public static Color Green => new Color("green");
        public static Color Greenyellow => new Color("greenyellow");
        public static Color Grey => new Color("grey");
        public static Color Honeydew => new Color("honeydew");
        public static Color Hotpink => new Color("hotpink");
        public static Color Indianred => new Color("indianred");
        public static Color Indigo => new Color("indigo");
        public static Color Ivory => new Color("ivory");
        public static Color Khaki => new Color("khaki");
        public static Color Lavender => new Color("lavender");
        public static Color Lavenderblush => new Color("lavenderblush");
        public static Color Lawngreen => new Color("lawngreen");
        public static Color Lemonchiffon => new Color("lemonchiffon");
        public static Color Lightblue => new Color("lightblue");
        public static Color Lightcoral => new Color("lightcoral");
        public static Color Lightcyan => new Color("lightcyan");
        public static Color Lightgoldenrodyellow => new Color("lightgoldenrodyellow");
        public static Color Lightgray => new Color("lightgray");
        public static Color Lightgreen => new Color("lightgreen");
        public static Color Lightgrey => new Color("lightgrey");
        public static Color Lightpink => new Color("lightpink");
        public static Color Lightsalmon => new Color("lightsalmon");
        public static Color Lightseagreen => new Color("lightseagreen");
        public static Color Lightskyblue => new Color("lightskyblue");
        public static Color Lightslategray => new Color("lightslategray");
        public static Color Lightslategrey => new Color("lightslategrey");
        public static Color Lightsteelblue => new Color("lightsteelblue");
        public static Color Lightyellow => new Color("lightyellow");
        public static Color Lime => new Color("lime");
        public static Color Limegreen => new Color("limegreen");
        public static Color Linen => new Color("linen");
        public static Color Magenta => new Color("magenta");
        public static Color Maroon => new Color("maroon");
        public static Color Mediumaquamarine => new Color("mediumaquamarine");
        public static Color Mediumblue => new Color("mediumblue");
        public static Color Mediumorchid => new Color("mediumorchid");
        public static Color Mediumpurple => new Color("mediumpurple");
        public static Color Mediumseagreen => new Color("mediumseagreen");
        public static Color Mediumslateblue => new Color("mediumslateblue");
        public static Color Mediumspringgreen => new Color("mediumspringgreen");
        public static Color Mediumturquoise => new Color("mediumturquoise");
        public static Color Mediumvioletred => new Color("mediumvioletred");
        public static Color Midnightblue => new Color("midnightblue");
        public static Color Mintcream => new Color("mintcream");
        public static Color Mistyrose => new Color("mistyrose");
        public static Color Moccasin => new Color("moccasin");
        public static Color Navajowhite => new Color("navajowhite");
        public static Color Navy => new Color("navy");
        public static Color Oldlace => new Color("oldlace");
        public static Color Olive => new Color("olive");
        public static Color Olivedrab => new Color("olivedrab");
        public static Color Orange => new Color("orange");
        public static Color Orangered => new Color("orangered");
        public static Color Orchid => new Color("orchid");
        public static Color Palegoldenrod => new Color("palegoldenrod");
        public static Color Palegreen => new Color("palegreen");
        public static Color Paleturquoise => new Color("paleturquoise");
        public static Color Palevioletred => new Color("palevioletred");
        public static Color Papayawhip => new Color("papayawhip");
        public static Color Peachpuff => new Color("peachpuff");
        public static Color Peru => new Color("peru");
        public static Color Pink => new Color("pink");
        public static Color Plum => new Color("plum");
        public static Color Powderblue => new Color("powderblue");
        public static Color Purple => new Color("purple");
        public static Color Red => new Color("red");
        public static Color Rosybrown => new Color("rosybrown");
        public static Color Royalblue => new Color("royalblue");
        public static Color Saddlebrown => new Color("saddlebrown");
        public static Color Salmon => new Color("salmon");
        public static Color Sandybrown => new Color("sandybrown");
        public static Color Seagreen => new Color("seagreen");
        public static Color Seashell => new Color("seashell");
        public static Color Sienna => new Color("sienna");
        public static Color Silver => new Color("silver");
        public static Color Skyblue => new Color("skyblue");
        public static Color Slateblue => new Color("slateblue");
        public static Color Slategray => new Color("slategray");
        public static Color Slategrey => new Color("slategrey");
        public static Color Snow => new Color("snow");
        public static Color Springgreen => new Color("springgreen");
        public static Color Steelblue => new Color("steelblue");
        public static Color Tan => new Color("tan");
        public static Color Teal => new Color("teal");
        public static Color Thistle => new Color("thistle");
        public static Color Tomato => new Color("tomato");
        public static Color Turquoise => new Color("turquoise");
        public static Color Violet => new Color("violet");
        public static Color Wheat => new Color("wheat");
        public static Color White => new Color("white");
        public static Color Whitesmoke => new Color("whitesmoke");
        public static Color Yellow => new Color("yellow");
        public static Color Yellowgreen => new Color("yellowgreen");

        public static Color RGB(int red, int green, int blue) => new Color($"#{red:x2}{green:x2}{blue:x2}");
        public static Color RGBA(int red, int green, int blue, int alpha) => new Color($"#{red:x2}{green:x2}{blue:x2}{alpha:x2}");
    }
}