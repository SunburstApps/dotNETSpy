using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dotNETSpy.Controls
{
    public static class ControlExtensions
    {
        public static void SetElevationRequiredState(this ButtonBase btn, bool required = true)
        {
            if (Environment.OSVersion.Version.Major < 6) throw new PlatformNotSupportedException();

            const int BCM_SETSHIELD = 0x160C;
            btn.SendMessage(BCM_SETSHIELD, IntPtr.Zero, (IntPtr)(required ? 1 : 0));
            btn.Invalidate();
        }

        public static void InvokeOnAllChildren(this Control ctrl, Action<Control> action)
        {
            action(ctrl);
            foreach (Control child in ctrl.Controls) child.InvokeOnAllChildren(action);
        }

        public static IntPtr SendMessage(this Control ctrl, int msg, IntPtr wParam, IntPtr lParam)
        {
            if (!ctrl.IsHandleCreated) throw new InvalidOperationException("Control must have a handle (HWND) associated with it.");
            return NativeSendMessaage(ctrl.Handle, msg, wParam, lParam);
        }

        public static void EnableVisualTheme(this ListView ctrl) => SetWindowTheme(ctrl.Handle, "Explorer", null);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern IntPtr NativeSendMessaage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string appName, string componentName);
    }
}
