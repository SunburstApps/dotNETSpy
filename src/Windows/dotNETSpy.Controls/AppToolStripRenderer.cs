using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dotNETSpy.Controls
{
    public sealed class AppToolStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            // Override the default (and quite ugly) .NET checkmark bitmap
            ToolStripMenuItem menuItem = e.Item as ToolStripMenuItem;
            if ((menuItem != null) && menuItem.Checked && menuItem.Image == null)
            {
                e.Graphics.DrawImage(Properties.Resources.Checkmark, e.ImageRectangle);
            }
            else
            {
                base.OnRenderItemCheck(e);
            }
        }
    }
}
