using PdfSharp.Fonts;
using System.IO;

namespace Simulador.Models
{
    public class MyFontResolver : IFontResolver
    {
        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName == "Arial")
            {
                if (isBold && isItalic) return new FontResolverInfo("Arial#BoldItalic");
                if (isBold) return new FontResolverInfo("Arial#Bold");
                if (isItalic) return new FontResolverInfo("Arial#Italic");
                return new FontResolverInfo("Arial#Regular");
            }
            return null;
        }

        public byte[] GetFont(string faceName)
        {
            switch (faceName)
            {
                case "Arial#Regular":
                    return File.ReadAllBytes("C:\\Users\\User\\Desktop\\arial.ttf");
            }
            return null;
        }
    }
}
