using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

public class PerplexLabel : Control
{
	public PerplexLabel()
	{
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.FromArgb(205, 205, 205));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ad: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0102: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			((Control)this).OnPaint(e);
			val2.Clear(((Control)this).get_BackColor());
			Font val3 = new Font("Tahoma", 9f, (FontStyle)1);
			val2.set_CompositingQuality((CompositingQuality)2);
			val2.set_SmoothingMode((SmoothingMode)2);
			string text = ((Control)this).get_Text();
			SolidBrush val4 = new SolidBrush(Color.FromArgb(5, 5, 5));
			RectangleF rectangleF = new Rectangle(1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val5 = new StringFormat();
			val5.set_Alignment((StringAlignment)0);
			val5.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text, val3, (Brush)val4, rectangleF, val5);
			string text2 = ((Control)this).get_Text();
			SolidBrush val6 = new SolidBrush(Color.FromArgb(205, 205, 205));
			RectangleF rectangleF2 = new Rectangle(0, -1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val7 = new StringFormat();
			val7.set_Alignment((StringAlignment)0);
			val7.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text2, val3, (Brush)val6, rectangleF2, val7);
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				((Image)val).Clone(),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
