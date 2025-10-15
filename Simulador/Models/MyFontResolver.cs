using PdfSharp.Fonts;
using System;
using System.IO;
using System.Reflection;

namespace Simulador.Models
{
    public class MyFontResolver : IFontResolver
    {
        /*public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
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
        }*/

        public byte[] GetFont(string faceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // nome do recurso: [namespace do projeto].[pasta].[arquivo]
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
