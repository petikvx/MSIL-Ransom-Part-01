using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class LXGroupBox : ContainerControl
{
	public enum HeaderLine
	{
		Enabled,
		Disabled
	}

	private HeaderLine headerLine_0;

	public HeaderLine Header_Line
	{
		get
		{
			return headerLine_0;
		}
		set
		{
			headerLine_0 = value;
			((Control)this).Invalidate();
		}
	}

	public LXGroupBox()
	{
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.FromArgb(205, 205, 205));
		((Control)this).set_Size(new Size(174, 115));
		headerLine_0 = HeaderLine.Enabled;
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		((Control)this).OnPaint(paintEventArgs_0);
		val2.Clear(((Control)this).get_BackColor());
		Font val3 = new Font(" ", 8f, (FontStyle)0);
		val2.set_SmoothingMode((SmoothingMode)2);
		Color[] color_ = new Color[9]
		{
			Color.FromArgb(20, 20, 20),
			Color.FromArgb(45, 45, 45),
			Color.FromArgb(40, 40, 40),
			Color.FromArgb(45, 45, 45),
			Color.FromArgb(46, 46, 46),
			Color.FromArgb(47, 47, 47),
			Color.FromArgb(48, 48, 48),
			Color.FromArgb(49, 49, 49),
			Color.FromArgb(50, 50, 50)
		};
		val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(50, 50, 50)), rectangle);
		Class2.smethod_2(val2, rectangle, color_);
		switch (headerLine_0)
		{
		case HeaderLine.Enabled:
			val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 16, 29, ((Control)this).get_Width() - 17, 29);
			val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(20, 20, 20))), 15, 30, ((Control)this).get_Width() - 16, 30);
			val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 16, 31, ((Control)this).get_Width() - 17, 31);
			break;
		}
		string text = ((Control)this).get_Text();
		Brush silver = Brushes.get_Silver();
		RectangleF rectangleF = new Rectangle(0, 3, ((Control)this).get_Width() - 1, 27);
		StringFormat val4 = new StringFormat();
		val4.set_Alignment((StringAlignment)1);
		val4.set_LineAlignment((StringAlignment)1);
		val2.DrawString(text, val3, silver, rectangleF, val4);
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
