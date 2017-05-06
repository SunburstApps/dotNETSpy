using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dotNETSpy.Controls
{
    [ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class FixedLinkLabel : LinkLabel
    {
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (PointInLink(e.X, e.Y) != null) OverrideCursor = FixedHandCursor;
            else OverrideCursor = Cursors.Default;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr LoadCursor(IntPtr hModule, IntPtr cursorId);
        public static readonly Cursor FixedHandCursor = new Cursor(LoadCursor(IntPtr.Zero, new IntPtr(32649)));
    }
}
