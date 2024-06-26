﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using static SDUI.NativeMethods;

namespace SDUI.Helpers
{
    public class FontManager
    {
        private static readonly PrivateFontCollection privateFontCollection = new();
        public static Font Inter = GetFont(Resources.InterFont, 16f, FontStyle.Regular);

        private static Font GetFont(byte[] fontResource, float size, FontStyle style)
        {
            int dataLength = fontResource.Length;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontResource, 0, fontPtr, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(fontPtr, (uint)fontResource.Length, IntPtr.Zero, ref cFonts);
            privateFontCollection.AddMemoryFont(fontPtr, dataLength);

            var family = privateFontCollection.Families.FirstOrDefault(p => p.IsStyleAvailable(style));

            return new(family, size, style, GraphicsUnit.Pixel);
        }
    }
}
