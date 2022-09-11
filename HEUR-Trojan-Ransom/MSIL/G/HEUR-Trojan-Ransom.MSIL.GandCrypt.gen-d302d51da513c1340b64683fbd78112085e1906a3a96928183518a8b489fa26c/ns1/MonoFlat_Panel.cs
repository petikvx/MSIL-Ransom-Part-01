using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns1;

public class MonoFlat_Panel : ContainerControl
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 124)]
	private struct Struct4
	{
	}

	private GraphicsPath graphicsPath_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[62];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public MonoFlat_Panel()
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
		//IL_0012: Expected O, but got Unknown
		((Control)this).OnResize(eventArgs_0);
		graphicsPath_0 = new GraphicsPath();
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

	static MonoFlat_Panel()
	{
		char[] array = new char[8];
		array[7] = '㉭';
		array[5] = '\u094b';
		array[3] = '\u20fa';
		array[2] = '㨵';
		array[6] = '㎨';
		array[4] = '⨅';
		array[0] = '㤅';
		array[1] = 'ㄹ';
		array_1 = new string[11];
		object_0 = array;
	}
}
