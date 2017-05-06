using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dotNETSpy.Controls
{
    [Designer("System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class DropDownButton : Button
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Image = Properties.Resources.DropDownButtonArrow;
            ImageAlign = ContentAlignment.MiddleRight;
            TextImageRelation = TextImageRelation.TextBeforeImage;
        }

        public ContextMenuStrip Menu { get; set; } = null;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Menu?.Show(this, new Point(0, ClientRectangle.Height));
        }
    }
}
