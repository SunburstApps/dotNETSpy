using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dotNETSpy.Controls
{
    public class DoubleBufferedPanel : Panel
    {
        protected override void OnCreateControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            base.OnCreateControl();
        }
    }
}
