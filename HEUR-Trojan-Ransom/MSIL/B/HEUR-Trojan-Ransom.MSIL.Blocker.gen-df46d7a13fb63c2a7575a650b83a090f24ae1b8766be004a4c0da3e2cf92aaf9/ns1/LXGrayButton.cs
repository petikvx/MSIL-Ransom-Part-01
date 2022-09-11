using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class LXGrayButton : Control
{
	internal Enum0 enum0_0;

	protected override void vmethod_0(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
		enum0_0 = Enum0.const_2;
		((Control)this).Invalidate();
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		enum0_0 = Enum0.const_1;
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseEnter(eventArgs_0);
		enum0_0 = Enum0.const_1;
		((Control)this).Invalidate();
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
		enum0_0 = Enum0.const_0;
		((Control)this).Invalidate();
	}

	public LXGrayButton()
	{
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.FromArgb(55, 55, 55));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_4(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		((Control)this).OnPaint(paintEventArgs_0);
		val2.Clear(((Control)this).get_BackColor());
		Font val3 = new Font(" ", 8f, (FontStyle)0);
		val2.set_SmoothingMode((SmoothingMode)2);
		val2.FillPath((Brush)new SolidBrush(Color.FromArgb(75, 75, 75)), Class1.smethod_0(rectangle_, 3));
		val2.DrawPath(new Pen((Brush)new SolidBrush(Color.FromArgb(25, 25, 25))), Class1.smethod_0(rectangle_, 3));
		val2.DrawPath(new Pen((Brush)new SolidBrush(Color.FromArgb(95, 95, 95))), Class1.smethod_0(new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3), 3));
		switch (enum0_0)
		{
		case Enum0.const_0:
		{
			string text3 = ((Control)this).get_Text();
			Brush silver = Brushes.get_Silver();
			RectangleF rectangleF3 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val6 = new StringFormat();
			val6.set_Alignment((StringAlignment)1);
			val6.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text3, val3, silver, rectangleF3, val6);
			break;
		}
		case Enum0.const_1:
		{
			string text2 = ((Control)this).get_Text();
			Brush white = Brushes.get_White();
			RectangleF rectangleF2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val5 = new StringFormat();
			val5.set_Alignment((StringAlignment)1);
			val5.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text2, val3, white, rectangleF2, val5);
			break;
		}
		case Enum0.const_2:
		{
			string text = ((Control)this).get_Text();
			Brush gray = Brushes.get_Gray();
			RectangleF rectangleF = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val4 = new StringFormat();
			val4.set_Alignment((StringAlignment)1);
			val4.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text, val3, gray, rectangleF, val4);
			break;
		}
		}
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
