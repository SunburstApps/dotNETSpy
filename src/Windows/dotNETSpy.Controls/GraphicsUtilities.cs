using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace dotNETSpy.Controls
{
    public static class GraphicsUtilities
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleDC(IntPtr hWnd);

        public static Graphics GetOffscreenGraphics()
        {
            return Graphics.FromHdc(CreateCompatibleDC(IntPtr.Zero));
        }
    }
}
