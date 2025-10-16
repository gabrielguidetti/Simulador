using PdfSharp.Fonts;
using System;
using System.IO;
using System.Reflection;

namespace Simulador.Models
{
    public class MyFontResolver : IFontResolver
    {
        public byte[] GetFont(string faceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            string resourceName = "Simulador.Src.arial.ttf";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
                return new FontResolverInfo("Arial#");

            return null;
        }
    }
}
