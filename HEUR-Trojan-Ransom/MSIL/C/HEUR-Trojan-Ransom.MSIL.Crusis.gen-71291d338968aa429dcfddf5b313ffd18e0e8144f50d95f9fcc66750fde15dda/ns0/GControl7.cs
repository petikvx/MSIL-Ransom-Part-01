using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0;

public class GControl7 : ContainerControl
{
	internal GraphicsPath graphicsPath_0;

	public GControl7()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).set_BackColor(Color.FromArgb(39, 51, 63));
		((Control)this).set_Size(new Size(187, 117));
		((Control)this).set_Padding(new Padding(5, 5, 5, 5));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		((Control)this).OnResize(eventArgs_0);
		GraphicsPath val = (graphicsPath_0 = new GraphicsPath());
		graphicsPath_0.AddArc(0, 0, 10, 10, 180f, 90f);
		graphicsPath_0.AddArc(((Control)this).get_Width() - 11, 0, 10, 10, -90f, 90f);
		graphicsPath_0.AddArc(((Control)this).get_Width() - 11, ((Control)this).get_Height() - 11, 10, 10, 0f, 90f);
		graphicsPath_0.AddArc(0, ((Control)this).get_Height() - 11, 10, 10, 90f, 90f);
		graphicsPath_0.CloseAllFigures();
	}

	protected override void vmethod_1(PaintEventArgs paintEventArgs_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics obj = Graphics.FromImage((Image)(object)val);
		obj.set_SmoothingMode((SmoothingMode)2);
		obj.Clear(Color.FromArgb(32, 41, 50));
		obj.FillPath((Brush)new SolidBrush(Color.FromArgb(39, 51, 63)), graphicsPath_0);
		obj.DrawPath(new Pen(Color.FromArgb(39, 51, 63)), graphicsPath_0);
		obj.Dispose();
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		((Image)val).Dispose();
	}
}
