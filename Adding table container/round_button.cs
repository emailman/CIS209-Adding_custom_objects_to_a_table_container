using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class RoundButton : Button
{
    protected override void OnResize(EventArgs e)
    {
        using (var path = new GraphicsPath())
        {
            path.AddEllipse(new Rectangle(0, 0, this.Width, this.Height));
            this.Region = new Region(path);
        }
        base.OnResize(e);
    }
}
