using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

public class PerplexGroupBox : ContainerControl
{
	public PerplexGroupBox()
	{
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_DoubleBuffered(true);
	}

	public static Bitmap loadresource(string resname)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager("resources", Assembly.GetExecutingAssembly());
		return (Bitmap)resourceManager.GetObject(resname);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014b: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		checked
		{
			Rectangle rectangle = new Rectangle(4, 25, ((Control)this).get_Width() - 9, ((Control)this).get_Height() - 30);
			Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			((Control)this).OnPaint(e);
			val2.Clear(Color.Transparent);
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.set_CompositingQuality((CompositingQuality)2);
			Pen val3 = new Pen(Color.Black);
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle2, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 30, 30), 90f);
			val2.FillPath((Brush)(object)val4, Draw.RoundRect(rectangle2, 3));
			val2.DrawPath(new Pen(Brushes.get_Black()), Draw.RoundRect(rectangle2, 3));
			LinearGradientBrush val5 = new LinearGradientBrush(rectangle, Color.FromArgb(46, 46, 46), Color.FromArgb(50, 55, 58), 120f);
			val2.FillPath((Brush)(object)val5, Draw.RoundRect(rectangle, 3));
			val2.DrawPath(val3, Draw.RoundRect(rectangle, 3));
			Font val6 = new Font("Tahoma", 9f, (FontStyle)1);
			string text = ((Control)this).get_Text();
			SolidBrush val7 = new SolidBrush(Color.WhiteSmoke);
			StringFormat val8 = new StringFormat();
			val8.set_Alignment((StringAlignment)1);
			val8.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text, val6, (Brush)val7, 67f, 14f, val8);
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
